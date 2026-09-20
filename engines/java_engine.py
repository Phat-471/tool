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

        cmd = [
            executable,
            "--deobf",
            "--show-bad-code",
            "-d", str(out_path.resolve()),
            input_path,
        ]

        try:
            result = subprocess.run(
                cmd,
                capture_output=True,
                text=True,
                encoding="utf-8",
                errors="replace",
                timeout=600,
            )

            # Đếm số lượng file .java trích xuất được
            java_files = list(out_path.rglob("*.java"))
            if not java_files and result.returncode != 0:
                return {
                    "success": False,
                    "message": f"Lỗi JADX (Exit code {result.returncode}): {result.stderr or result.stdout}",
                    "stdout": result.stdout,
                    "stderr": result.stderr,
                }

            # 1. Trích xuất AndroidManifest.xml & strings.xml nếu có
            android_notes = self._extract_android_metadata(out_path)

            # 2. Quét và giải mã chuỗi trên toàn bộ file .java
            enh_msg = ""
            try:
                from core.string_decryptor import StringDecryptor
                inv = StringDecryptor.enhance_decompiled_directory(str(out_path))
                dec_count = inv.get("total_decoded_base64", 0) + inv.get("total_decoded_bytes", 0)
                if dec_count > 0:
                    enh_msg = f" (Đã giải mã {dec_count} chuỗi, {len(inv.get('urls', []))} URLs)"
            except Exception:
                pass

            return {
                "success": True,
                "output_dir": str(out_path.resolve()),
                "message": (
                    f"✅ Dịch ngược APK/Java thành công – "
                    f"{len(java_files)} tệp .java (Chế độ deobfuscator đã bật){enh_msg}{android_notes}."
                ),
                "stdout": result.stdout or "",
                "stderr": "",
            }
        except subprocess.TimeoutExpired:
            return {"success": False, "message": "Quá thời gian thực thi JADX (>600s)."}
        except Exception as e:
            return {"success": False, "message": f"Lỗi thực thi JADX: {str(e)}"}

    def _extract_android_metadata(self, out_path: Path) -> str:
        """Trích xuất thông tin cơ bản từ AndroidManifest.xml và res/values/strings.xml."""
        manifest_files = list(out_path.rglob("AndroidManifest.xml"))
        notes = []
        if manifest_files:
            try:
                manifest_text = manifest_files[0].read_text(encoding="utf-8", errors="replace")
                import re
                pkg_match = re.search(r'package\s*=\s*"([^"]+)"', manifest_text)
                if pkg_match:
                    notes.append(f"Package: {pkg_match.group(1)}")
                perms = re.findall(r'uses-permission.*?android:name\s*=\s*"([^"]+)"', manifest_text)
                if perms:
                    notes.append(f"{len(perms)} quyền Android")
            except Exception:
                pass
        return f" [{', '.join(notes)}]" if notes else ""
