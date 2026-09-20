import os
from pathlib import Path
from typing import Any, Dict, List, Set, Tuple

from config import SUPPORTED_EXTENSIONS
from core.detector import FileDetector
from core.obfuscator_detector import ObfuscatorDetector


class SmartFolderScanner:
    """
    Bộ quét và phân loại tệp thông minh cho thư mục cài đặt ứng dụng:
    - Quét đệ quy toàn bộ thư mục tìm các file (.dll, .exe, .apk, .jar, .pyc)
    - Tự động nhận diện và lọc bỏ các thư viện chuẩn của hệ thống / bên thứ 3 (System.*, Microsoft.*, mscorlib...)
    - Phân loại rõ ràng:
        1. Target App Files (Ứng dụng chính & File bị Obfuscate)
        2. Framework / Third-party Libraries (Thư viện chuẩn)
    """

    # Danh sách các tiền tố thư viện chuẩn của Microsoft .NET / Windows / Third-party phổ biến
    SYSTEM_FRAMEWORK_PREFIXES = (
        "system.",
        "microsoft.",
        "mscorlib",
        "netstandard",
        "windowsbase",
        "presentationcore",
        "presentationframework",
        "newtonsoft.json",
        "bouncycastle",
        "sqlite",
        "entityframework",
        "autofac",
        "unity.",
        "castle.",
        "log4net",
        "nlog",
        "serilog",
        "restsharp",
        "protobuf",
        "grpc.",
        "automapper",
        "fluentvalidation",
        "mediatr",
        "quartz",
        "sharpziplib",
        "icsharpcode.",
        "mono.cecil",
        "costura",
        "fody",
    )

    @classmethod
    def is_framework_library(cls, file_name: str) -> bool:
        """Kiểm tra xem file có phải là thư viện chuẩn / bên thứ 3 phổ biến hay không."""
        lower = file_name.lower()
        return any(lower.startswith(prefix) for prefix in cls.SYSTEM_FRAMEWORK_PREFIXES)

    @classmethod
    def scan_directory(cls, dir_path: str, max_files: int = 500) -> Dict[str, Any]:
        """
        Quét toàn bộ thư mục và phân loại các tệp nhị phân tìm thấy:
        Returns:
            {
                "total_found": int,
                "target_files": [...],      # 🎯 Ứng dụng chính (khuyến nghị dịch)
                "framework_files": [...],   # ⚙️ Thư viện chuẩn (có thể bỏ qua)
                "other_binaries": [...],
            }
        """
        p = Path(dir_path)
        if not p.is_dir():
            return {"error": f"Thư mục không tồn tại: {dir_path}"}

        target_files: List[Dict[str, Any]] = []
        framework_files: List[Dict[str, Any]] = []
        other_binaries: List[Dict[str, Any]] = []

        count = 0
        for root, _, files in os.walk(dir_path):
            for file in files:
                if count >= max_files:
                    break

                file_path = Path(root) / file
                ext = file_path.suffix.lower()

                # Chỉ kiểm tra các định dạng được hệ thống hỗ trợ
                if ext not in SUPPORTED_EXTENSIONS:
                    continue

                count += 1
                try:
                    size_kb = round(file_path.stat().st_size / 1024, 2)
                except Exception:
                    size_kb = 0.0

                # Nhận diện cơ bản định dạng
                detection = FileDetector.detect(str(file_path))
                file_type = detection.get("file_type", "Unknown")
                engine = detection.get("engine", "unknown")

                # Kiểm tra xem có bị Obfuscate không (nếu là .NET)
                is_obfuscated = False
                obf_name = ""
                if engine == "dotnet":
                    try:
                        profile = ObfuscatorDetector.detect(str(file_path))
                        if profile and profile.is_detected:
                            is_obfuscated = True
                            obf_name = profile.name
                    except Exception:
                        pass

                is_framework = cls.is_framework_library(file)

                info = {
                    "path": str(file_path.resolve()),
                    "filename": file,
                    "rel_path": str(file_path.relative_to(p)),
                    "size_kb": size_kb,
                    "file_type": file_type,
                    "engine": engine,
                    "is_obfuscated": is_obfuscated,
                    "obf_name": obf_name,
                    "is_framework": is_framework,
                    # Mặc định tick chọn nếu là file ứng dụng chính hoặc bị obfuscate
                    "selected": not is_framework or is_obfuscated,
                }

                if is_obfuscated or not is_framework:
                    target_files.append(info)
                elif is_framework:
                    framework_files.append(info)
                else:
                    other_binaries.append(info)

        return {
            "folder_path": str(p.resolve()),
            "folder_name": p.name,
            "total_found": count,
            "target_files": target_files,
            "framework_files": framework_files,
            "other_binaries": other_binaries,
        }
