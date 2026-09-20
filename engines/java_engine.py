import os
import shutil
import subprocess
from pathlib import Path
from typing import Dict, Any, Optional
from engines.base import BaseDecompiler
from config import TOOLS_DIR

class JavaDecompiler(BaseDecompiler):
    """Engine dịch ngược Android APK & Java JAR sử dụng JADX CLI."""

    def __init__(self):
        super().__init__("JADX Decompiler")

    def get_executable_path(self) -> Optional[str]:
        # 1. Tìm trong thư mục tools/ của dự án
        local_jadx = TOOLS_DIR / "jadx" / "bin" / ("jadx.bat" if os.name == "nt" else "jadx")
        if local_jadx.is_file():
            return str(local_jadx.resolve())

        # 2. Tìm trong PATH hệ thống
        system_jadx = shutil.which("jadx")
        if system_jadx:
            return system_jadx

        return None

    def is_available(self) -> bool:
        return self.get_executable_path() is not None

    def decompile(self, input_path: str, output_dir: str, **kwargs) -> Dict[str, Any]:
        executable = self.get_executable_path()
        if not executable:
            return {
                "success": False,
                "message": (
                    "Không tìm thấy công cụ 'jadx'.\n"
                    "- Tải bản release JADX và giải nén vào: "
                    f"'{TOOLS_DIR / 'jadx'}' (yêu cầu có file bin/jadx.bat)"
                ),
            }

        out_path = Path(output_dir)
        out_path.mkdir(parents=True, exist_ok=True)

        cmd = [executable, "-d", str(out_path.resolve()), input_path]

        try:
            result = subprocess.run(
                cmd,
                capture_output=True,
                text=True,
                encoding="utf-8",
                check=True,
                timeout=600,
            )
            return {
                "success": True,
                "output_dir": str(out_path.resolve()),
                "message": "Dịch ngược APK/Java thành công.",
                "stdout": result.stdout,
                "stderr": "",
            }
        except subprocess.CalledProcessError as e:
            return {
                "success": False,
                "message": f"Lỗi JADX (Exit code {e.returncode}): {e.stderr or e.stdout}",
                "stdout": e.stdout,
                "stderr": e.stderr,
            }
        except Exception as e:
            return {"success": False, "message": f"Lỗi thực thi JADX: {str(e)}"}
