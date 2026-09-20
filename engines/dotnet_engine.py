import shutil
import subprocess
from pathlib import Path
from typing import Any, Dict, Optional, Tuple

from engines.base import BaseDecompiler
from config import TOOLS_DIR


class DotNetDecompiler(BaseDecompiler):
    """Engine dịch ngược .NET Assembly (.dll, .exe) sử dụng ILSpy CLI (ilspycmd) kết hợp de4dot."""

    def __init__(self):
        super().__init__("ILSpy .NET Decompiler")

    # ------------------------------------------------------------------
    # Tool discovery
    # ------------------------------------------------------------------

    def get_executable_path(self) -> Optional[str]:
        """Trả về đường dẫn tới ilspycmd, ưu tiên thư mục tools/ của dự án."""
        local_exe = TOOLS_DIR / "ilspycmd.exe"
        if local_exe.is_file():
            return str(local_exe.resolve())
        return shutil.which("ilspycmd")

    def get_de4dot_executable(self) -> Optional[str]:
        """Trả về đường dẫn tới de4dot, kiểm tra nhiều vị trí."""
        for candidate in [
            TOOLS_DIR / "de4dot" / "de4dot.exe",
            TOOLS_DIR / "de4dot.exe",
        ]:
            if candidate.is_file():
                return str(candidate.resolve())
        return shutil.which("de4dot")

    def is_available(self) -> bool:
        return self.get_executable_path() is not None

    # ------------------------------------------------------------------
    # Pre-processing: de4dot
    # ------------------------------------------------------------------

    def _preprocess_with_de4dot(
        self, input_path: str, work_dir: Path
    ) -> Tuple[Optional[str], str]:
        """Chạy de4dot để gỡ làm rối file DLL trước khi dịch ngược.

        Returns:
            (cleaned_path, log_message)
            - cleaned_path: đường dẫn file đã làm sạch, hoặc None nếu thất bại.
            - log_message : mô tả kết quả.
        """
        de4dot_bin = self.get_de4dot_executable()
        if not de4dot_bin:
            return None, "⚠️ Không tìm thấy de4dot – bỏ qua bước gỡ làm rối."

        stem = Path(input_path).stem
        cleaned_file = work_dir / f"{stem}_cleaned.dll"

        # Thử với --strtyp delegate trước (giải mã chuỗi động của ConfuserEx),
        # sau đó thử lại không có tham số đặc biệt.
        cmds_to_try = [
            [de4dot_bin, input_path, "-o", str(cleaned_file), "--strtyp", "delegate"],
            [de4dot_bin, input_path, "-o", str(cleaned_file)],
        ]

        for cmd in cmds_to_try:
            try:
                subprocess.run(
                    cmd,
                    capture_output=True,
                    text=True,
                    encoding="utf-8",
                    errors="replace",
                    timeout=180,
                )
                if cleaned_file.exists() and cleaned_file.stat().st_size > 0:
                    return str(cleaned_file), (
                        f"✅ de4dot xử lý thành công → {cleaned_file.name}"
                    )
            except subprocess.TimeoutExpired:
                return None, "⚠️ de4dot quá thời gian (timeout 180s)."
            except Exception as exc:
                return None, f"⚠️ de4dot gặp lỗi: {exc}"

        return None, "⚠️ de4dot không tạo được file đã làm sạch."

    # ------------------------------------------------------------------
    # ILSpy invocation helper
    # ------------------------------------------------------------------

    def _run_ilspy(
        self, executable: str, target_path: str, out_path: Path
    ) -> Tuple[bool, str, str, str]:
        """Chạy ilspycmd và trả về (success, message, stdout, stderr)."""
        cmd = [executable, "-p", "-o", str(out_path.resolve()), target_path]
        try:
            result = subprocess.run(
                cmd,
                capture_output=True,
                text=True,
                encoding="utf-8",
                errors="replace",
                timeout=300,
            )
        except subprocess.TimeoutExpired:
            return False, "Quá thời gian xử lý ILSpy (timeout 300s).", "", ""
        except Exception as exc:
            return False, f"Lỗi khi gọi ilspycmd: {exc}", "", ""

        cs_files = list(out_path.rglob("*.cs"))
        if result.returncode == 0 or cs_files:
            return True, f"{len(cs_files)} tệp .cs được trích xuất.", result.stdout, ""

        err_combined = (result.stderr or "") + (result.stdout or "")
        return False, err_combined, result.stdout, result.stderr

    # ------------------------------------------------------------------
    # Fallback: trích xuất cấu trúc PE
    # ------------------------------------------------------------------

    def _fallback_pe_analysis(
        self, input_path: str, output_dir: str, prev_stderr: str
    ) -> Dict[str, Any]:
        """Chuyển hướng sang NativePEEngine khi không thể dịch ngược .NET."""
        try:
            from engines.native_engine import NativePEEngine
            NativePEEngine().decompile(input_path, output_dir)
            return {
                "success": True,
                "output_dir": output_dir,
                "message": (
                    "⚠️ File gặp lỗi Metadata (BadImageFormatException). "
                    "Hệ thống đã tự động chuyển hướng – trích xuất cấu trúc PE "
                    "và ghi vào tệp 'pe_summary.txt'."
                ),
                "stdout": "",
                "stderr": prev_stderr,
            }
        except Exception as exc:
            return {
                "success": False,
                "message": f"Lỗi phân tích PE fallback: {exc}",
                "stdout": "",
                "stderr": prev_stderr,
            }

    # ------------------------------------------------------------------
    # Public entry point
    # ------------------------------------------------------------------

    def decompile(self, input_path: str, output_dir: str, **kwargs) -> Dict[str, Any]:
        executable = self.get_executable_path()
        if not executable:
            return {
                "success": False,
                "message": (
                    "Không tìm thấy công cụ 'ilspycmd'.\n"
                    "- Cách 1: Chạy lệnh `dotnet tool install -g ilspycmd`\n"
                    f"- Cách 2: Copy file `ilspycmd.exe` vào thư mục `{TOOLS_DIR}`"
                ),
            }

        out_path = Path(output_dir)
        out_path.mkdir(parents=True, exist_ok=True)

        # ── Bước 1: Thử dịch trực tiếp bằng ILSpy ────────────────────
        ok, msg, stdout, stderr = self._run_ilspy(executable, input_path, out_path)

        if ok:
            sln_msg = self._try_generate_solution(out_path)
            return {
                "success": True,
                "output_dir": str(out_path.resolve()),
                "message": f"✅ Dịch ngược C# thành công – {msg}{sln_msg}",
                "stdout": stdout,
                "stderr": "",
            }

        err_text = msg  # stderr + stdout gộp lại từ _run_ilspy

        # ── Bước 2: Nếu gặp lỗi Metadata / Obfuscated → dùng de4dot ──
        needs_deobf = (
            "BadImageFormatException" in err_text
            or "Illegal tables" in err_text
            or "compressed metadata" in err_text
        )

        if needs_deobf or not ok:
            cleaned_path, de4dot_log = self._preprocess_with_de4dot(input_path, out_path)

            if cleaned_path:
                ok2, msg2, stdout2, _ = self._run_ilspy(executable, cleaned_path, out_path)
                if ok2:
                    sln_msg = self._try_generate_solution(out_path)
                    return {
                        "success": True,
                        "output_dir": str(out_path.resolve()),
                        "message": (
                            f"✅ Đã tự động gỡ làm rối (de4dot) và dịch ngược thành công – "
                            f"{msg2}{sln_msg}"
                        ),
                        "stdout": stdout2,
                        "stderr": "",
                    }
                err_text += f"\n[de4dot] {de4dot_log}\n[ILSpy retry] {msg2}"
            else:
                err_text += f"\n[de4dot] {de4dot_log}"

        # ── Bước 3: Fallback → phân tích cấu trúc PE ─────────────────
        return self._fallback_pe_analysis(input_path, output_dir, err_text)

    # ------------------------------------------------------------------
    # Helpers
    # ------------------------------------------------------------------

    def _try_generate_solution(self, out_path: Path) -> str:
        """Tạo file .sln nếu có module SolutionGenerator."""
        try:
            from core.solution_generator import SolutionGenerator
            sln_file = SolutionGenerator.generate_solution_for_directory(str(out_path))
            if sln_file:
                return f" (Đã tạo Solution: {Path(sln_file).name})"
        except Exception:
            pass
        return ""
