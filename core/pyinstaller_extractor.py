import os
import struct
import zlib
from pathlib import Path
from typing import Any, Dict, List, Optional, Tuple


class PyInstallerExtractor:
    """
    Module bóc tách tệp thực thi Windows (.exe) được đóng gói bằng PyInstaller:
    1. Quét tìm chữ ký PyInstaller (Magic cookie: MEI\\x0c\\x0b\\x0a\\x0b\\x0e).
    2. Đọc cấu trúc CArchive Header và Table of Contents (TOC).
    3. Giải nén các tệp .pyc nhúng (zlib compressed) và khôi phục mã bytecode.
    4. Tự động vá 16 bytes Magic Header cho file .pyc để công cụ dịch ngược (pycdc) đọc được.
    """

    # Cookie nhận diện PyInstaller (thường nằm ở cuối file PE)
    PYINSTALLER_COOKIE = b"MEI\x0c\x0b\x0a\x0b\x0e"

    # Bảng tra cứu Magic Header chuẩn của các phiên bản Python (.pyc)
    PYTHON_MAGIC_MAP = {
        (3, 8):  b"\x55\x0d\x0d\x0a\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00",
        (3, 9):  b"\x61\x0d\x0d\x0a\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00",
        (3, 10): b"\x6f\x0d\x0d\x0a\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00",
        (3, 11): b"\xa7\x0d\x0d\x0a\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00",
        (3, 12): b"\xcb\x0d\x0d\x0a\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00",
    }
    # Mặc định dùng magic của Python 3.10/3.11 nếu không xác định được
    DEFAULT_MAGIC = b"\xa7\x0d\x0d\x0a\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00\x00"

    @classmethod
    def is_pyinstaller_exe(cls, file_path: str) -> bool:
        """Kiểm tra xem tệp .exe có phải do PyInstaller tạo ra không."""
        p = Path(file_path)
        if not p.is_file():
            return False

        try:
            with open(file_path, "rb") as f:
                # Quét nhanh 64KB cuối file (nơi thường chứa cookie)
                f.seek(0, os.SEEK_END)
                size = f.tell()
                scan_len = min(size, 64 * 1024)
                f.seek(size - scan_len)
                tail = f.read(scan_len)

                if cls.PYINSTALLER_COOKIE in tail or b"pyi-windows-exec" in tail:
                    return True

                # Nếu chưa thấy, quét toàn bộ tệp (giới hạn 50MB)
                if size < 50 * 1024 * 1024:
                    f.seek(0)
                    content = f.read()
                    if cls.PYINSTALLER_COOKIE in content or b"pyi-windows-exec" in content:
                        return True
        except Exception:
            pass

        return False

    @classmethod
    def detect_python_version(cls, data: bytes) -> bytes:
        """Thử dò tìm phiên bản Python nhúng (ví dụ: python310.dll, python311.dll)."""
        for ver, magic in cls.PYTHON_MAGIC_MAP.items():
            dll_pattern = f"python{ver[0]}{ver[1]}.dll".encode()
            if dll_pattern in data.lower():
                return magic
        return cls.DEFAULT_MAGIC

    @classmethod
    def extract(cls, file_path: str, output_dir: Path) -> Dict[str, Any]:
        """
        Bóc tách các tệp .pyc từ file PyInstaller .exe:
        - Tìm cookie và header CArchive
        - Giải nén từng entry trong TOC
        - Ghi ra các file .pyc hoàn chỉnh có kèm 16 bytes magic header
        """
        output_dir.mkdir(parents=True, exist_ok=True)
        pyc_dir = output_dir / "pyc_extracted"
        pyc_dir.mkdir(parents=True, exist_ok=True)

        extracted_files: List[str] = []
        user_scripts: List[str] = []

        try:
            with open(file_path, "rb") as f:
                data = f.read()
        except Exception as exc:
            return {
                "success": False,
                "message": f"Không thể đọc file: {exc}",
                "extracted_files": [],
            }

        magic_header = cls.detect_python_version(data)

        # 1. Định vị cookie PyInstaller
        cookie_pos = data.rfind(cls.PYINSTALLER_COOKIE)
        if cookie_pos == -1:
            return {
                "success": False,
                "message": "Không tìm thấy PyInstaller cookie hợp lệ.",
                "extracted_files": [],
            }

        try:
            # Cấu trúc PyInstaller Cookie Header (trước hoặc tại cookie_pos)
            # Cookie: 8s (MEI\x0c\x0b\x0a\x0b\x0e), length (I), toc_offset (I), toc_len (I), pyvers (I), pylibname (64s)
            # Thử unpack header ở vị trí cookie_pos
            header_data = data[cookie_pos:cookie_pos + 88]
            if len(header_data) >= 24:
                magic, length, toc_offset, toc_len, pyvers = struct.unpack_from("<8sIIII", header_data, 0)
                
                # Tính toán vị trí bắt đầu của CArchive
                archive_start = cookie_pos - length
                if archive_start >= 0 and toc_offset < length:
                    actual_toc_pos = archive_start + toc_offset
                    toc_data = data[actual_toc_pos:actual_toc_pos + toc_len]
                    
                    # Đọc các entry trong TOC
                    idx = 0
                    while idx < len(toc_data):
                        # Entry: structLen (I), pos (I), len (I), uncompressedLen (I), cmprFlag (B), typeFlag (c), name (string)
                        if idx + 18 > len(toc_data):
                            break
                        entry_len, entry_pos, entry_sz, uncmpr_sz, cmpr_flag, type_flag = struct.unpack_from(
                            "<IIIcBc", toc_data, idx
                        )
                        name_raw = toc_data[idx + 18:idx + entry_len]
                        name = name_raw.split(b"\x00")[0].decode("utf-8", errors="replace").strip()
                        idx += entry_len

                        if not name:
                            continue

                        # Trích xuất payload của entry
                        raw_payload = data[archive_start + entry_pos:archive_start + entry_pos + entry_sz]
                        if cmpr_flag == 1 or cmpr_flag == 2:
                            try:
                                payload = zlib.decompress(raw_payload)
                            except Exception:
                                payload = raw_payload
                        else:
                            payload = raw_payload

                        # Nếu là script Python hoặc bytecode (type 's' hoặc 'm')
                        if type_flag in (b"s", b"m") or name.endswith(".py") or not "." in name:
                            out_name = name if name.endswith(".pyc") else (name + ".pyc")
                            out_file = pyc_dir / out_name
                            out_file.parent.mkdir(parents=True, exist_ok=True)

                            # Nếu thiếu magic header, ghép magic header vào đầu
                            if not payload.startswith(magic_header[:4]):
                                full_pyc = magic_header + payload
                            else:
                                full_pyc = payload

                            out_file.write_bytes(full_pyc)
                            extracted_files.append(str(out_file))

                            # Phân loại script chính của người dùng (không phải thư viện chuẩn)
                            if not name.startswith("pyi_") and not name.startswith("pkg_resources") and not name.startswith("importlib"):
                                user_scripts.append(str(out_file))
        except Exception:
            pass

        # 2. Fallback: Nếu phân tích CArchive TOC bị lỗi hoặc bị obfuscate
        # Quét tìm các zlib block chứa Python bytecode độc lập
        if not extracted_files:
            idx = 0
            block_idx = 0
            while idx < len(data) - 100:
                # Byte 0x78 (zlib magic header: 0x78 0x9c hoặc 0x78 0x01 hoặc 0x78 0xda)
                if data[idx] == 0x78 and data[idx + 1] in (0x01, 0x9C, 0xDA):
                    try:
                        decomp = zlib.decompress(data[idx:idx + 512 * 1024])
                        # Kiểm tra xem có phải Python code object (chứa chuỗi đặc trưng hoặc opcode)
                        if len(decomp) > 50 and (b"co_code" in decomp or b"co_name" in decomp or b"\x63\x00\x00\x00" in decomp[:16]):
                            out_file = pyc_dir / f"extracted_script_{block_idx}.pyc"
                            out_file.write_bytes(magic_header + decomp)
                            extracted_files.append(str(out_file))
                            user_scripts.append(str(out_file))
                            block_idx += 1
                            idx += len(decomp) // 2
                    except Exception:
                        pass
                idx += 1

        return {
            "success": len(extracted_files) > 0,
            "total_extracted": len(extracted_files),
            "user_scripts_count": len(user_scripts),
            "pyc_directory": str(pyc_dir),
            "extracted_files": extracted_files,
            "user_scripts": user_scripts,
            "message": f"Đã trích xuất thành công {len(extracted_files)} tệp .pyc ({len(user_scripts)} mã nguồn chính).",
        }
