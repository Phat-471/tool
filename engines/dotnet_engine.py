import shutil
import struct
import subprocess
from datetime import datetime
from pathlib import Path
from typing import Any, Dict, List, Optional, Tuple

from engines.base import BaseDecompiler
from config import TOOLS_DIR

# ── Chuỗi nhận diện lỗi BadImageFormatException từ đầu ra ilspycmd ──────────
_BAD_IMAGE_MARKERS: List[str] = [
    "BadImageFormatException",
    "Illegal tables",
    "compressed metadata",
    "Invalid PE",
    "Unknown metadata",
    "Could not load file or assembly",
    "Metadata decode error",
]


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
    # ILSpy invocation helper  (với xử lý ngoại lệ đầy đủ)
    # ------------------------------------------------------------------

    def _is_bad_image_error(self, text: str) -> bool:
        """Kiểm tra xem chuỗi đầu ra có chứa dấu hiệu BadImageFormatException."""
        return any(marker in text for marker in _BAD_IMAGE_MARKERS)

    def _run_ilspy(
        self, executable: str, target_path: str, out_path: Path
    ) -> Tuple[bool, str, str, str]:
        """Chạy ilspycmd, bắt ngoại lệ đầy đủ và trả về (success, message, stdout, stderr).

        Luồng xử lý ngoại lệ:
          - TimeoutExpired  → thông báo timeout, không crash
          - FileNotFoundError → ilspycmd không tìm thấy
          - BadImageFormatException (trong stdout/stderr) → trả về flag để caller xử lý
          - Exception khác → ghi log, trả về thất bại an toàn
        """
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
            return False, "[TIMEOUT] Quá thời gian xử lý ILSpy (>300s).", "", ""
        except FileNotFoundError:
            return False, f"[NOT_FOUND] Không tìm thấy ilspycmd tại: {executable}", "", ""
        except PermissionError:
            return False, "[PERMISSION] Không có quyền chạy ilspycmd.", "", ""
        except OSError as exc:
            return False, f"[OS_ERROR] Lỗi hệ điều hành khi gọi ilspycmd: {exc}", "", ""
        except Exception as exc:
            return False, f"[UNKNOWN] Lỗi không xác định khi gọi ilspycmd: {exc}", "", ""

        stdout_text = result.stdout or ""
        stderr_text = result.stderr or ""
        err_combined = stderr_text + stdout_text

        # Kiểm tra file .cs được tạo ra
        cs_files = list(out_path.rglob("*.cs"))
        if (result.returncode == 0 or cs_files) and not self._is_bad_image_error(err_combined):
            return True, f"{len(cs_files)} tệp .cs được trích xuất.", stdout_text, ""

        # Gắn tag [BAD_IMAGE] để caller nhận diện chính xác loại lỗi
        if self._is_bad_image_error(err_combined):
            err_combined = "[BAD_IMAGE] " + err_combined

        return False, err_combined, stdout_text, stderr_text

    # ------------------------------------------------------------------
    # Fallback 1: dnSpy CLI
    # ------------------------------------------------------------------

    def get_dnspy_executable(self) -> Optional[str]:
        """Tìm dnSpy CLI (dnspyconsole.exe hoặc dnspy.exe) trong tools/ và PATH."""
        candidates = [
            TOOLS_DIR / "dnspy" / "dnspyconsole.exe",
            TOOLS_DIR / "dnspy" / "dnspy.exe",
            TOOLS_DIR / "dnspyconsole.exe",
            TOOLS_DIR / "dnspy.exe",
        ]
        for p in candidates:
            if p.is_file():
                return str(p.resolve())
        # Thử tìm trong PATH
        for name in ("dnspyconsole", "dnspy"):
            found = shutil.which(name)
            if found:
                return found
        return None

    def _try_dnspy_cli(
        self, input_path: str, out_path: Path
    ) -> Tuple[bool, str]:
        """Cố gắng dịch ngược bằng dnSpy CLI khi ILSpy gặp BadImageFormatException.

        dnSpy hỗ trợ nhiều định dạng .NET bị làm rối hơn ILSpy.
        Trả về (success, message).
        """
        dnspy_bin = self.get_dnspy_executable()
        if not dnspy_bin:
            return False, "⚠️ Không tìm thấy dnSpy CLI – bỏ qua bước này."

        dnspy_out = out_path / "dnspy_output"
        dnspy_out.mkdir(parents=True, exist_ok=True)

        # dnspyconsole dịch ngược assembly sang thư mục output
        cmd = [
            dnspy_bin,
            "--output", str(dnspy_out),
            "--lang", "csharp",
            input_path,
        ]

        try:
            proc = subprocess.run(
                cmd,
                capture_output=True,
                text=True,
                encoding="utf-8",
                errors="replace",
                timeout=300,
            )
        except subprocess.TimeoutExpired:
            return False, "⚠️ dnSpy CLI quá thời gian (timeout 300s)."
        except FileNotFoundError:
            return False, f"⚠️ Không tìm thấy dnSpy tại: {dnspy_bin}"
        except Exception as exc:
            return False, f"⚠️ dnSpy CLI gặp lỗi: {exc}"

        cs_files = list(dnspy_out.rglob("*.cs"))
        if cs_files:
            return True, (
                f"✅ dnSpy CLI dịch ngược thành công {len(cs_files)} tệp .cs "
                f"→ {dnspy_out}"
            )

        err = (proc.stderr or "") + (proc.stdout or "")
        return False, f"⚠️ dnSpy CLI không tạo được file .cs. Output:\n{err[:500]}"

    # ------------------------------------------------------------------
    # Fallback 2: Trích xuất cấu trúc PE và ghi báo cáo
    # ------------------------------------------------------------------

    def _write_pe_report(self, input_path: str, out_path: Path) -> str:
        """Phân tích cấu trúc PE thuần Python và ghi báo cáo pe_summary.txt.

        Không phụ thuộc vào công cụ ngoài. Trích xuất:
        - DOS Header, PE Signature, COFF Header
        - Optional Header (Architecture, EntryPoint, ImageBase…)
        - Danh sách Section Headers
        - Strings in-memory (printable ASCII ≥ 6 ký tự)
        """
        report_path = out_path / "pe_summary.txt"
        lines: List[str] = []

        def ln(text: str = "") -> None:
            lines.append(text)

        ln("=" * 70)
        ln("  PE STRUCTURE ANALYSIS REPORT")
        ln(f"  File   : {input_path}")
        ln(f"  Tạo lúc: {datetime.now().strftime('%Y-%m-%d %H:%M:%S')}")
        ln("=" * 70)

        try:
            data = Path(input_path).read_bytes()
        except Exception as exc:
            ln(f"[LỖI] Không thể đọc file: {exc}")
            report_path.write_text("\n".join(lines), encoding="utf-8")
            return str(report_path)

        # ── DOS Header ────────────────────────────────────────────────
        if len(data) < 64 or data[:2] != b"MZ":
            ln("[LỖI] Không phải file PE hợp lệ (thiếu MZ signature).")
            report_path.write_text("\n".join(lines), encoding="utf-8")
            return str(report_path)

        e_lfanew = struct.unpack_from("<I", data, 0x3C)[0]
        ln("\n── DOS HEADER ──")
        ln(f"  Magic            : MZ (0x4D5A)")
        ln(f"  e_lfanew (PE ptr): 0x{e_lfanew:08X}")

        # ── PE Signature ──────────────────────────────────────────────
        if len(data) < e_lfanew + 4 or data[e_lfanew:e_lfanew + 4] != b"PE\x00\x00":
            ln("[LỖI] Không tìm thấy PE signature hợp lệ.")
            report_path.write_text("\n".join(lines), encoding="utf-8")
            return str(report_path)

        # ── COFF Header ───────────────────────────────────────────────
        coff_offset = e_lfanew + 4
        machine, num_sections, time_stamp, _, _, opt_hdr_size, characteristics = \
            struct.unpack_from("<HHIIIHH", data, coff_offset)

        _MACHINE_MAP = {
            0x014C: "x86 (Intel 386)",
            0x8664: "x86-64 (AMD64)",
            0x01C4: "ARM Thumb-2",
            0xAA64: "ARM64",
        }
        ts_str = datetime.utcfromtimestamp(time_stamp).strftime("%Y-%m-%d %H:%M:%S UTC") \
            if time_stamp else "N/A"

        ln("\n── COFF HEADER ──")
        ln(f"  Machine          : 0x{machine:04X}  ({_MACHINE_MAP.get(machine, 'Unknown')})")
        ln(f"  NumberOfSections : {num_sections}")
        ln(f"  TimeDateStamp    : {ts_str}")
        ln(f"  OptionalHdrSize  : {opt_hdr_size} bytes")
        ln(f"  Characteristics  : 0x{characteristics:04X}")

        # ── Optional Header ───────────────────────────────────────────
        opt_offset = coff_offset + 20
        if opt_hdr_size >= 28 and len(data) > opt_offset + 2:
            magic = struct.unpack_from("<H", data, opt_offset)[0]
            is_pe64 = magic == 0x20B
            arch_label = "PE32+ (64-bit)" if is_pe64 else "PE32 (32-bit)"

            if is_pe64 and len(data) >= opt_offset + 24:
                entry_point, = struct.unpack_from("<I", data, opt_offset + 16)
                image_base, = struct.unpack_from("<Q", data, opt_offset + 24)
            elif len(data) >= opt_offset + 32:
                entry_point, = struct.unpack_from("<I", data, opt_offset + 16)
                image_base, = struct.unpack_from("<I", data, opt_offset + 28)
            else:
                entry_point = image_base = 0

            ln("\n── OPTIONAL HEADER ──")
            ln(f"  Magic (Arch)     : 0x{magic:04X}  {arch_label}")
            ln(f"  EntryPoint (RVA) : 0x{entry_point:08X}")
            ln(f"  ImageBase        : 0x{image_base:016X}")

        # ── Section Headers ───────────────────────────────────────────
        sect_offset = opt_offset + opt_hdr_size
        ln("\n── SECTION HEADERS ──")
        ln(f"  {'Name':<10} {'VAddr':>10} {'VSize':>10} {'RawSize':>10} {'Chars':>12}")
        ln("  " + "-" * 56)

        for i in range(num_sections):
            s = sect_offset + i * 40
            if s + 40 > len(data):
                break
            raw_name = data[s:s + 8].rstrip(b"\x00")
            try:
                name = raw_name.decode("ascii", errors="replace")
            except Exception:
                name = "???"
            vsize, vaddr, raw_size = struct.unpack_from("<III", data, s + 8)[:3]
            chars, = struct.unpack_from("<I", data, s + 36)
            ln(f"  {name:<10} 0x{vaddr:08X} 0x{vsize:08X} 0x{raw_size:08X} 0x{chars:08X}")

        # ── String Extraction (printable ASCII ≥ 6 ký tự) ────────────
        ln("\n── EXTRACTED STRINGS (ASCII ≥ 6 chars, max 200) ──")
        strings_found: List[str] = []
        current: List[int] = []
        for byte in data:
            if 0x20 <= byte < 0x7F:  # printable ASCII
                current.append(byte)
            else:
                if len(current) >= 6:
                    strings_found.append(bytes(current).decode("ascii", errors="replace"))
                current = []
            if len(strings_found) >= 200:
                break
        for s in strings_found:
            ln(f"  {s}")

        ln("\n" + "=" * 70)
        ln("  END OF REPORT")
        ln("=" * 70)

        report_path.write_text("\n".join(lines), encoding="utf-8")
        return str(report_path)

    # ------------------------------------------------------------------
    # Fallback cuối: NativePEEngine + _write_pe_report
    # ------------------------------------------------------------------

    def _fallback_pe_analysis(
        self, input_path: str, output_dir: str, prev_stderr: str
    ) -> Dict[str, Any]:
        """Fallback cuối: chạy NativePEEngine rồi tự viết báo cáo PE thuần Python.

        Hàm này KHÔNG BAO GIỜ raise exception ra ngoài – mọi lỗi đều được
        bắt và ghi vào kết quả trả về.
        """
        out_path = Path(output_dir)
        out_path.mkdir(parents=True, exist_ok=True)
        messages: List[str] = []

        # Thử NativePEEngine (exports, imports, strings)
        try:
            from engines.native_engine import NativePEEngine
            NativePEEngine().decompile(input_path, output_dir)
            messages.append("✅ NativePEEngine trích xuất Exports/Imports thành công.")
        except Exception as exc:
            messages.append(f"⚠️ NativePEEngine thất bại: {exc}")

        # Luôn viết báo cáo PE thuần Python (không phụ thuộc công cụ)
        try:
            report_file = self._write_pe_report(input_path, out_path)
            messages.append(f"✅ Đã ghi báo cáo cấu trúc PE → {Path(report_file).name}")
        except Exception as exc:
            messages.append(f"⚠️ Không ghi được pe_summary.txt: {exc}")

        summary = (
            "⚠️ File gặp lỗi Metadata (BadImageFormatException).\n"
            "Hệ thống đã tự động chuyển hướng:\n"
            + "\n".join(f"  • {m}" for m in messages)
        )

        return {
            "success": True,
            "output_dir": output_dir,
            "message": summary,
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
        is_bad_image = "[BAD_IMAGE]" in err_text or self._is_bad_image_error(err_text)

        # ── Bước 2a: BadImageFormatException → thử de4dot trước ──────
        if is_bad_image or not ok:
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

        # ── Bước 2b: BadImageFormatException → thử dnSpy CLI ─────────
        if is_bad_image:
            ok_dnspy, msg_dnspy = self._try_dnspy_cli(input_path, out_path)
            if ok_dnspy:
                sln_msg = self._try_generate_solution(out_path)
                return {
                    "success": True,
                    "output_dir": str(out_path.resolve()),
                    "message": f"{msg_dnspy}{sln_msg}",
                    "stdout": "",
                    "stderr": "",
                }
            err_text += f"\n[dnSpy] {msg_dnspy}"

        # ── Bước 3: Fallback cuối → trích xuất cấu trúc PE ───────────
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
