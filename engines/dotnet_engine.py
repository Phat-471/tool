import os
import shutil
import subprocess
from pathlib import Path
from typing import Dict, Any, Optional
from engines.base import BaseDecompiler
from config import TOOLS_DIR

class DotNetDecompiler(BaseDecompiler):
    """Engine dịch ngược .NET Assembly (.dll, .exe) sử dụng ILSpy CLI (ilspycmd) kết hợp de4dot."""

    def __init__(self):
        super().__init__("ILSpy .NET Decompiler")

    def get_executable_path(self) -> Optional[str]:
        # 1. Tìm trong thư mục tools/ của dự án
        local_exe = TOOLS_DIR / "ilspycmd.exe"
        if local_exe.is_file():
            return str(local_exe.resolve())

        # 2. Tìm trong PATH hệ thống
        system_exe = shutil.which("ilspycmd")
        if system_exe:
            return system_exe

        return None

    def get_de4dot_executable(self) -> Optional[str]:
        """Kiểm tra công cụ de4dot để gỡ làm rối code .NET."""
        # 1. tools/de4dot/de4dot.exe
        p1 = TOOLS_DIR / "de4dot" / "de4dot.exe"
        if p1.is_file():
            return str(p1.resolve())

        # 2. tools/de4dot.exe
        p2 = TOOLS_DIR / "de4dot.exe"
        if p2.is_file():
            return str(p2.resolve())

        # 3. PATH
        return shutil.which("de4dot")

    def is_available(self) -> bool:
        return self.get_executable_path() is not None

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

        # Bước 1: Thử dịch trực tiếp bằng ILSpy
        cmd = [executable, "-p", "-o", str(out_path.resolve()), input_path]
        try:
            result = subprocess.run(
                cmd,
                capture_output=True,
                text=True,
                encoding="utf-8",
                timeout=300,
            )

            # Kiểm tra xem có file .cs nào được sinh ra không
            cs_files = list(out_path.rglob("*.cs"))
            if result.returncode == 0 or cs_files:
                from core.solution_generator import SolutionGenerator
                sln_file = SolutionGenerator.generate_solution_for_directory(str(out_path))
                sln_msg = f" (Đã tạo Solution: {Path(sln_file).name})" if sln_file else ""

                return {
                    "success": True,
                    "output_dir": str(out_path.resolve()),
                    "message": f"Dịch ngược C# thành công ({len(cs_files)} tệp){sln_msg}.",
                    "stdout": result.stdout,
                    "stderr": "",
                }

            err_text = (result.stderr or "") + (result.stdout or "")

            # Bước 2: Nếu gặp lỗi Metadata (Obfuscated) -> Thử dùng de4dot gỡ làm rối chuyên sâu
            if "BadImageFormatException" in err_text or "Illegal tables" in err_text or result.returncode != 0:
                de4dot_bin = self.get_de4dot_executable()

                if de4dot_bin:
                    cleaned_file = out_path / f"{Path(input_path).stem}_cleaned.dll"
                    try:
                        # Thêm tham số --strtyp delegate để giải mã chuỗi động (Dynamic String Decryption)
                        fix_cmd = [de4dot_bin, input_path, "-o", str(cleaned_file), "--strtyp", "delegate"]
                        subprocess.run(fix_cmd, capture_output=True, text=True, timeout=180)

                        if cleaned_file.exists() and cleaned_file.stat().st_size > 0:
                            # Dịch lại file đã làm sạch
                            retry_cmd = [executable, "-p", "-o", str(out_path.resolve()), str(cleaned_file)]
                            retry_res = subprocess.run(retry_cmd, capture_output=True, text=True, timeout=300)

                            cleaned_cs_files = list(out_path.rglob("*.cs"))
                            if cleaned_cs_files:
                                from core.solution_generator import SolutionGenerator
                                sln_file = SolutionGenerator.generate_solution_for_directory(str(out_path))
                                sln_msg = f" & Tạo file Solution ({Path(sln_file).name})" if sln_file else ""

                                return {
                                    "success": True,
                                    "output_dir": str(out_path.resolve()),
                                    "message": f"✅ Đã tự động gỡ làm rối bằng de4dot và dịch ngược thành công {len(cleaned_cs_files)} tệp mã nguồn C#{sln_msg}!",
                                    "stdout": retry_res.stdout,
                                    "stderr": "",
                                }
                    except Exception as e_deobf:
                        err_text += f"\nLỗi de4dot: {str(e_deobf)}"

                # Nếu không có de4dot hoặc cả 2 đều không xuất được file .cs
                friendly_msg = (
                    "⚠️ File .NET bị làm rối nặng hoặc lỗi Metadata:\n\n"
                    f"Chi tiết: {err_text[:300]}...\n\n"
                    "👉 Hãy kiểm tra tab 'Phân tích & Strings' để xem cấu trúc chuỗi và dữ liệu của file."
                )
                return {
                    "success": False,
                    "message": friendly_msg,
                    "stdout": result.stdout,
                    "stderr": result.stderr,
                }

            return {
                "success": False,
                "message": f"Lỗi ilspycmd (Exit code {e.returncode}):\n{e.stderr or e.stdout}",
                "stdout": e.stdout,
                "stderr": e.stderr,
            }
        except subprocess.TimeoutExpired:
            return {
                "success": False,
                "message": "Quá thời gian xử lý (Timeout > 300s).",
            }
        except Exception as e:
            return {
                "success": False,
                "message": f"Lỗi không xác định: {str(e)}",
            }
