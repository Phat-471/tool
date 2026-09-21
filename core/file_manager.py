import os
import shutil
import zipfile
from pathlib import Path
from typing import Dict, List, Optional
from config import UPLOADS_DIR, OUTPUT_DIR, SUPPORTED_EXTENSIONS

class FileManager:
    """Quản lý các thao tác tệp: lưu trữ, quét thư mục, nén ZIP."""

    @staticmethod
    def is_supported(file_path: str) -> bool:
        """Kiểm tra xem phần mở rộng của file có được hỗ trợ không."""
        ext = Path(file_path).suffix.lower()
        return ext in SUPPORTED_EXTENSIONS

    @staticmethod
    def get_file_info(file_path: str) -> dict:
        """Lấy thông tin chi tiết của file."""
        p = Path(file_path)
        if not p.exists():
            return {"exists": False}
        size_bytes = p.stat().st_size
        type_desc = SUPPORTED_EXTENSIONS.get(p.suffix.lower(), "Unknown")

        # Nhận diện chi tiết hơn cho tệp thực thi .exe
        if p.suffix.lower() == ".exe":
            try:
                from core.sfx_extractor import SFXExtractor
                is_sfx, sfx_desc, _ = SFXExtractor.detect_sfx(str(p))
                if is_sfx:
                    type_desc = sfx_desc
            except Exception:
                pass

        return {
            "exists": True,
            "filename": p.name,
            "ext": p.suffix.lower(),
            "size_kb": round(size_bytes / 1024, 2),
            "size_mb": round(size_bytes / (1024 * 1024), 2),
            "type_desc": type_desc,
            "path": str(p.resolve()),
        }

    @staticmethod
    def copy_to_uploads(source_path: str) -> str:
        """Sao chép file nguồn vào thư mục uploads của dự án."""
        src = Path(source_path)
        if not src.exists():
            raise FileNotFoundError(f"Không tìm thấy file nguồn: {source_path}")

        dest = UPLOADS_DIR / src.name
        shutil.copy2(src, dest)
        return str(dest.resolve())

    @staticmethod
    def clean_directory(dir_path: str) -> None:
        """Xóa sạch nội dung trong thư mục nếu đã tồn tại."""
        p = Path(dir_path)
        if p.exists() and p.is_dir():
            for item in p.iterdir():
                if item.is_dir():
                    shutil.rmtree(item, ignore_errors=True)
                else:
                    item.unlink(missing_ok=True)
        else:
            p.mkdir(parents=True, exist_ok=True)

    @staticmethod
    def scan_source_files(source_dir: str, include_all: bool = True) -> Dict[str, str]:
        """
        Quét toàn bộ các file mã nguồn và tài nguyên đã khôi phục.
        
        Trả về:
            Dict[str, str]: {đường_dẫn_tương_đối: đường_dẫn_tuyệt_đối}
        """
        result = {}
        src_path = Path(source_dir)
        if not src_path.exists():
            return result

        code_extensions = {
            ".cs", ".csproj", ".sln", ".config",
            ".java", ".smali", ".xml",
            ".py", ".pyc",
            ".asm", ".h", ".c", ".cpp",
            ".txt", ".json", ".iss", ".nsi", ".rc", ".manifest",
            ".lsp", ".fas", ".vlx", ".dcl", ".cui", ".cuix", ".mns", ".mnu",
            ".ini", ".cfg", ".conf", ".yaml", ".yml", ".properties",
            ".bat", ".cmd", ".ps1", ".vbs", ".sh",
            ".html", ".htm", ".css", ".js", ".ts",
            ".xls", ".xlsx", ".xlsm", ".dwg", ".dxf", ".wmf",
            ".dll", ".exe"
        }

        ignore_exts = {".tmp", ".temp", ".pdb"}

        # Gom danh sách tệp
        raw_items = []
        for root, _, files in os.walk(src_path):
            for file in files:
                f_path = Path(root) / file
                ext = f_path.suffix.lower()
                if ext in ignore_exts:
                    continue
                if include_all or ext in code_extensions:
                    rel_path = str(f_path.relative_to(src_path)).replace("\\", "/")
                    raw_items.append((f_path, rel_path, ext))

        # Ưu tiên sắp xếp:
        # 0: File mã nguồn C#, Java, Python, LISP
        # 1: File cấu hình, XML, JSON, TXT, Manifest
        # 2: File tài nguyên khác
        # 3: File nhị phân / hình ảnh
        def priority_key(item):
            _, rel, ext = item
            if ext in (".cs", ".java", ".py", ".lsp", ".asm", ".c", ".cpp", ".h"):
                prio = 0
            elif ext in (".xml", ".cui", ".cuix", ".json", ".txt", ".ini", ".cfg", ".bat", ".cmd", ".config", ".csproj", ".sln"):
                prio = 1
            elif ext in (".png", ".jpg", ".jpeg", ".ico", ".bmp", ".wmf", ".gif", ".dll", ".exe", ".so", ".dex"):
                prio = 3
            else:
                prio = 2
            return (prio, rel)

        raw_items.sort(key=priority_key)
        for f_path, rel_path, _ in raw_items:
            result[rel_path] = str(f_path.resolve())

        return result

    @staticmethod
    def create_zip(source_dir: str, output_zip_path: Optional[str] = None) -> str:
        """
        Nén toàn bộ thư mục kết quả thành file .zip.
        
        Trả về:
            str: Đường dẫn file zip đã tạo.
        """
        src = Path(source_dir)
        if not src.exists():
            raise FileNotFoundError(f"Thư mục nguồn không tồn tại: {source_dir}")

        if not output_zip_path:
            output_zip_path = str(OUTPUT_DIR / f"{src.name}_recovered.zip")

        with zipfile.ZipFile(output_zip_path, "w", zipfile.ZIP_DEFLATED) as zf:
            for root, _, files in os.walk(src):
                for file in files:
                    file_path = Path(root) / file
                    arcname = file_path.relative_to(src)
                    zf.write(file_path, arcname)

        return output_zip_path

    create_zip_archive = create_zip
