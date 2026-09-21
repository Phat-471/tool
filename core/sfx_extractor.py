import os
import shutil
import subprocess
import zipfile
from pathlib import Path
from typing import Any, Dict, List, Optional, Tuple

from config import TOOLS_DIR


class SFXExtractor:
    """
    Module nhận diện và bóc tách các tệp thực thi tự giải nén (SFX Executables / Archive Wrappers):
    - WinRAR SFX (.exe chứa RAR4 / RAR5 payload)
    - 7-Zip SFX (.exe chứa 7z payload)
    - Zip SFX (.exe chứa ZIP archive nhúng)
    """

    RAR_SIGNATURES = [
        (b"Rar!\x1a\x07\x01\x00", "RAR5 SFX"),
        (b"Rar!\x1a\x07\x00",     "RAR4 SFX"),
    ]
    SEVENZ_SIGNATURE = (b"7z\xbc\xaf\x27\x1c", "7-Zip SFX")
    ZIP_SIGNATURE = (b"PK\x03\x04", "Zip SFX")

    @classmethod
    def get_unrar_executable(cls) -> Optional[str]:
        """Tìm đường dẫn UnRAR.exe (ưu tiên tools/ dự án, sau đó đến WinRAR cài đặt và PATH)."""
        candidates = [
            TOOLS_DIR / "UnRAR.exe",
            TOOLS_DIR / "unrar.exe",
            Path(r"C:\Program Files\WinRAR\UnRAR.exe"),
            Path(r"C:\Program Files (x86)\WinRAR\UnRAR.exe"),
            Path(r"C:\Program Files\WinRAR\WinRAR.exe"),
        ]
        for c in candidates:
            if c.is_file():
                return str(c.resolve())
        return shutil.which("unrar") or shutil.which("winrar")

    @classmethod
    def detect_sfx(cls, file_path: str) -> Tuple[bool, str, int]:
        """
        Kiểm tra xem file .exe có chứa kho lưu trữ nhúng (SFX archive) hay không.
        Trả về: (is_sfx, sfx_type, offset)
        """
        p = Path(file_path)
        if not p.is_file():
            return False, "Not a file", -1

        try:
            file_size = p.stat().st_size
            if file_size < 1024:
                return False, "File too small", -1

            with open(file_path, "rb") as f:
                # Quét 32MB đầu tệp
                scan_len = min(file_size, 32 * 1024 * 1024)
                data = f.read(scan_len)

                # 1. Kiểm tra WinRAR SFX
                for sig, name in cls.RAR_SIGNATURES:
                    pos = data.find(sig)
                    if pos != -1 and pos >= 512:
                        return True, f"WinRAR Self-Extracting Executable ({name})", pos

                # 2. Kiểm tra 7-Zip SFX
                pos_7z = data.find(cls.SEVENZ_SIGNATURE[0])
                if pos_7z != -1 and pos_7z >= 512:
                    return True, "7-Zip Self-Extracting Executable (7z SFX)", pos_7z

                # 3. Kiểm tra Zip SFX (bỏ qua nếu pos < 512 vì đó là file zip thuần)
                pos_zip = data.find(cls.ZIP_SIGNATURE[0])
                if pos_zip != -1 and pos_zip >= 512:
                    return True, "Zip Self-Extracting Executable (Zip SFX)", pos_zip

        except Exception:
            pass

        return False, "Unknown", -1

    @classmethod
    def extract(cls, file_path: str, output_dir: Path) -> Dict[str, Any]:
        """
        Tự động bóc tách toàn bộ tệp bên trong SFX archive ra thư mục đích.
        """
        is_sfx, sfx_type, offset = cls.detect_sfx(file_path)
        if not is_sfx:
            return {
                "success": False,
                "message": f"Tệp không phải là SFX Archive hợp lệ: {sfx_type}",
                "extracted_files": [],
            }

        output_dir = output_dir.resolve()
        output_dir.mkdir(parents=True, exist_ok=True)
        payload_dir = output_dir

        extracted_files: List[str] = []
        dotnet_assemblies: List[str] = []

        # ── Trường hợp 1: WinRAR SFX ──────────────────────────────────
        if "WinRAR" in sfx_type or "RAR" in sfx_type:
            unrar_bin = cls.get_unrar_executable()
            if not unrar_bin:
                return {
                    "success": False,
                    "message": "Không tìm thấy công cụ UnRAR.exe để giải nén WinRAR SFX.",
                    "extracted_files": [],
                }

            cmd = [unrar_bin, "x", "-y", file_path, str(payload_dir) + os.sep]
            try:
                proc = subprocess.run(
                    cmd,
                    capture_output=True,
                    text=True,
                    errors="replace",
                    timeout=300,
                )
                if proc.returncode != 0:
                    return {
                        "success": False,
                        "message": f"UnRAR trả về lỗi (code {proc.returncode}): {proc.stderr[:300]}",
                        "extracted_files": [],
                    }
            except Exception as e:
                return {
                    "success": False,
                    "message": f"Lỗi khi chạy UnRAR: {str(e)}",
                    "extracted_files": [],
                }

        # ── Trường hợp 2: Zip SFX ─────────────────────────────────────
        elif "Zip" in sfx_type:
            try:
                # Python zipfile có thể đọc trực tiếp Zip SFX vì nó quét từ đuôi file
                with zipfile.ZipFile(file_path, "r") as zf:
                    zf.extractall(payload_dir)
            except Exception:
                # Nếu zipfile không đọc được từ đầu file exe, thử cắt từ offset
                try:
                    with open(file_path, "rb") as f_in:
                        f_in.seek(offset)
                        import io
                        zip_stream = io.BytesIO(f_in.read())
                        with zipfile.ZipFile(zip_stream, "r") as zf:
                            zf.extractall(payload_dir)
                except Exception as e:
                    return {
                        "success": False,
                        "message": f"Không thể giải nén Zip SFX: {str(e)}",
                        "extracted_files": [],
                    }

        # ── Trường hợp 3: 7-Zip SFX ───────────────────────────────────
        elif "7-Zip" in sfx_type:
            seven_zip = shutil.which("7z") or shutil.which("7za")
            if not seven_zip:
                seven_zip_paths = [
                    Path(r"C:\Program Files\7-Zip\7z.exe"),
                    Path(r"C:\Program Files (x86)\7-Zip\7z.exe"),
                ]
                for p in seven_zip_paths:
                    if p.is_file():
                        seven_zip = str(p.resolve())
                        break

            if seven_zip:
                cmd = [seven_zip, "x", "-y", f"-o{payload_dir}", file_path]
                subprocess.run(cmd, capture_output=True, timeout=300)

        # Quét lại danh sách toàn bộ các tệp vừa giải nén
        for f in payload_dir.rglob("*"):
            if f.is_file() and f.name != "sfx_manifest.txt":
                f_res = str(f.resolve())
                extracted_files.append(f_res)
                if f.suffix.lower() in (".dll", ".exe"):
                    dotnet_assemblies.append(f_res)

        # Tạo báo cáo tóm tắt bóc tách sfx_manifest.txt
        manifest_file = output_dir / "sfx_manifest.txt"
        with open(manifest_file, "w", encoding="utf-8") as f_man:
            f_man.write("=================================================================\n")
            f_man.write(f"BÁO CÁO BÓC TÁCH KHO LƯU TRỮ TỰ GIẢI NÉN (SFX ARCHIVE)\n")
            f_man.write(f"Tệp gốc: {Path(file_path).name}\n")
            f_man.write(f"Định dạng SFX: {sfx_type}\n")
            f_man.write(f"Vị trí Payload trong file PE: 0x{offset:X} ({offset:,} bytes)\n")
            f_man.write(f"Tổng số tệp khôi phục: {len(extracted_files)}\n")
            f_man.write(f"Số lượng Module / DLL nhị phân: {len(dotnet_assemblies)}\n")
            f_man.write("=================================================================\n\n")
            f_man.write("DANH SÁCH CÁC TỆP ĐÃ KHÔI PHỤC:\n")
            for f_path_str in extracted_files:
                rel = Path(f_path_str).relative_to(payload_dir)
                sz = Path(f_path_str).stat().st_size
                f_man.write(f"- {str(rel):<60} ({sz:,} bytes)\n")

        return {
            "success": len(extracted_files) > 0,
            "sfx_type": sfx_type,
            "offset": offset,
            "total_extracted": len(extracted_files),
            "payload_dir": str(payload_dir),
            "extracted_files": extracted_files,
            "dotnet_assemblies": dotnet_assemblies,
            "manifest_file": str(manifest_file),
            "message": f"Đã bóc tách thành công {len(extracted_files)} tệp từ kho lưu trữ {sfx_type}!",
        }
