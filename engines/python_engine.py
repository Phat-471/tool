import dis
import io
import marshal
import os
import shutil
import subprocess
from pathlib import Path
from typing import Dict, Any, Optional
from engines.base import BaseDecompiler
from config import TOOLS_DIR

class PythonDecompiler(BaseDecompiler):
    """
    Engine dịch ngược Python bytecode (.pyc):
    - Ưu tiên 1: pycdc (Decompyle++) trích xuất Python source code gốc (.py)
    - Ưu tiên 2: uncompyle6 (nếu cài qua pip)
    - Fallback: Module dis tích hợp sẵn trong Python để phân tích opcode / cấu trúc hàm
    """

    def __init__(self):
        super().__init__("Python Bytecode Decompiler")

    def get_executable_path(self) -> Optional[str]:
        local_pycdc = TOOLS_DIR / "pycdc.exe"
        if local_pycdc.is_file():
            return str(local_pycdc.resolve())

        system_pycdc = shutil.which("pycdc")
        if system_pycdc:
            return system_pycdc

        return None

    def is_available(self) -> bool:
        # Luôn khả dụng vì có fallback module dis tích hợp sẵn của Python
        return True

    def decompile_with_dis_fallback(self, input_path: str, output_file: Path) -> bool:
        """Fallback sử dụng module dis chuẩn của Python để phân tích cấu trúc bytecode."""
        try:
            with open(input_path, "rb") as f:
                # Bỏ qua 16 bytes header của file .pyc (Python 3.7+)
                f.seek(16)
                code_obj = marshal.load(f)

            dis_output = io.StringIO()
            dis_output.write(f"# Khôi phục từ bytecode Python: {Path(input_path).name}\n")
            dis_output.write(f"# Code Object: {code_obj.co_name}\n")
            dis_output.write(f"# Constants: {code_obj.co_consts}\n")
            dis_output.write(f"# Variable Names: {code_obj.co_varnames}\n")
            dis_output.write(f"# Names: {code_obj.co_names}\n\n")
            dis_output.write("# --- Chi tiết Bytecode Opcodes ---\n")
            dis.dis(code_obj, file=dis_output)

            with open(output_file, "w", encoding="utf-8") as f_out:
                f_out.write(dis_output.getvalue())

            return True
        except Exception:
            return False

    def decompile(self, input_path: str, output_dir: str, **kwargs) -> Dict[str, Any]:
        out_path = Path(output_dir)
        out_path.mkdir(parents=True, exist_ok=True)

        input_file = Path(input_path)
        output_file = out_path / f"{input_file.stem}_recovered.py"

        executable = self.get_executable_path()

        # 1. Thử dùng pycdc CLI
        if executable:
            try:
                with open(output_file, "w", encoding="utf-8") as f_out:
                    result = subprocess.run(
                        [executable, input_path],
                        stdout=f_out,
                        stderr=subprocess.PIPE,
                        text=True,
                        check=True,
                        timeout=120,
                    )
                return {
                    "success": True,
                    "output_dir": str(out_path.resolve()),
                    "message": f"Dịch ngược bằng pycdc thành công: {output_file.name}",
                    "stdout": "",
                    "stderr": result.stderr or "",
                }
            except Exception:
                pass  # Chuyển sang fallback

        # 2. Fallback: Dùng module dis chuẩn của Python
        if self.decompile_with_dis_fallback(input_path, output_file):
            return {
                "success": True,
                "output_dir": str(out_path.resolve()),
                "message": f"Đã phân tích cấu trúc bytecode thành công: {output_file.name}",
                "stdout": "",
                "stderr": "",
            }

        return {
            "success": False,
            "message": (
                "Không thể phân tích file .pyc.\n"
                f"- Bạn có thể copy 'pycdc.exe' vào '{TOOLS_DIR}' để hỗ trợ đầy đủ nhất."
            ),
        }
