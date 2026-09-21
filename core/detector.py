import os
from pathlib import Path
from typing import Dict, Any

class FileDetector:
    """Nhận diện cấu trúc tệp và phân loại Engine xử lý phù hợp (.NET, Native C/C++, Java, Python)."""

    @classmethod
    def is_dotnet_assembly(cls, file_path: str) -> bool:
        """Kiểm tra tệp PE có phải là .NET Assembly (có CLR / COM+ Header hoặc import mscoree.dll) hay không."""
        try:
            import pefile
            pe = pefile.PE(file_path)

            # 1. Kiểm tra IMAGE_DIRECTORY_ENTRY_COM_DESCRIPTOR (Index 14)
            com_idx = 14
            if hasattr(pe, "OPTIONAL_HEADER") and len(pe.OPTIONAL_HEADER.DATA_DIRECTORY) > com_idx:
                com_dir = pe.OPTIONAL_HEADER.DATA_DIRECTORY[com_idx]
                if com_dir.VirtualAddress > 0 and com_dir.Size > 0:
                    pe.close()
                    return True

            # 2. Kiểm tra Import Table: file .NET luôn import mscoree.dll -> _CorDllMain / _CorExeMain
            if hasattr(pe, "DIRECTORY_ENTRY_IMPORT"):
                for entry in pe.DIRECTORY_ENTRY_IMPORT:
                    dll_name = entry.dll.decode("utf-8", errors="ignore").lower() if entry.dll else ""
                    if "mscoree.dll" in dll_name:
                        pe.close()
                        return True

            # 3. Kiểm tra các Section đặc trưng của .NET
            for section in pe.sections:
                sec_name = section.Name.decode("utf-8", errors="ignore").strip("\x00").lower()
                if ".cormeta" in sec_name or ".clr" in sec_name:
                    pe.close()
                    return True

            pe.close()
        except Exception:
            pass

        # 4. Quét chuỗi nhị phân (quét theo chunk để không bỏ sót file lớn)
        try:
            with open(file_path, "rb") as f:
                while True:
                    chunk = f.read(1024 * 1024)
                    if not chunk:
                        break
                    if b"mscoree.dll" in chunk or b"_CorDllMain" in chunk or b"_CorExeMain" in chunk:
                        return True
        except Exception:
            pass

        return False

    @classmethod
    def detect(cls, file_path: str) -> Dict[str, Any]:
        """
        Phân tích header byte và cấu trúc để xác định chính xác loại file và engine.
        """
        p = Path(file_path)
        if not p.exists():
            return {"error": "File không tồn tại"}

        ext = p.suffix.lower()
        header = b""

        try:
            with open(p, "rb") as f:
                header = f.read(4)
        except Exception as e:
            return {"error": f"Không thể đọc file: {str(e)}"}

        file_type = "UNKNOWN"
        engine = "unknown"
        language = "plaintext"

        # 1. Tệp Windows PE (.dll, .exe)
        if ext in [".dll", ".exe"] or header.startswith(b"MZ"):
            is_exe = ext == ".exe"

            # 1.0 Kiểm tra tệp thực thi tự giải nén (SFX Archive: WinRAR, 7-Zip, Zip SFX)
            if is_exe:
                try:
                    from core.sfx_extractor import SFXExtractor
                    is_sfx, sfx_desc, _ = SFXExtractor.detect_sfx(str(p))
                    if is_sfx:
                        return {
                            "file_type": sfx_desc,
                            "engine": "sfx",
                            "language": "csharp",
                            "filename": p.name,
                            "path": str(p.resolve()),
                        }
                except Exception:
                    pass

            if cls.is_dotnet_assembly(str(p)):
                file_type = ".NET Executable (C# Managed Exe)" if is_exe else ".NET Assembly (C# Managed DLL)"
                engine = "dotnet"
                language = "csharp"
            else:
                # Kiểm tra xem có phải file đóng gói PyInstaller hay không
                is_py = False
                try:
                    from core.pyinstaller_extractor import PyInstallerExtractor
                    if PyInstallerExtractor.is_pyinstaller_exe(str(p)):
                        file_type = "Python Executable (PyInstaller Packed)"
                        engine = "python"
                        language = "python"
                        is_py = True
                except Exception:
                    pass

                if not is_py:
                    # Kiểm tra dấu hiệu các trình biên dịch & đóng gói Native phổ biến
                    try:
                        with open(p, "rb") as f_pe:
                            sample = f_pe.read(4 * 1024 * 1024)
                        if b"Go buildinf:" in sample or b"/runtime/proc.go" in sample:
                            file_type = "Go Native Executable (Golang Binary)"
                            engine = "native"
                            language = "c"
                        elif b"rust_panic" in sample or b"library\\std\\src" in sample:
                            file_type = "Rust Native Executable (Rust Binary)"
                            engine = "native"
                            language = "c"
                        elif b"Inno Setup Setup Data" in sample:
                            file_type = "Inno Setup Installer (.exe)"
                            engine = "native"
                            language = "c"
                        elif b"NullsoftInst" in sample:
                            file_type = "NSIS Installer (.exe)"
                            engine = "native"
                            language = "c"
                        elif b"AU3!EA06" in sample or b"AutoIt" in sample:
                            file_type = "AutoIt Compiled Script (.exe)"
                            engine = "native"
                            language = "c"
                        else:
                            file_type = "Native Windows Executable (C/C++ PE)" if is_exe else "Native Windows Library (C/C++ DLL)"
                            engine = "native"
                            language = "c"
                    except Exception:
                        file_type = "Native Windows Binary (C/C++ Unmanaged)"
                        engine = "native"
                        language = "c"

        # 2. Tệp Android / Java (.apk, .jar)
        elif ext == ".apk":
            file_type = "Android Package (APK)"
            engine = "java"
            language = "java"
        elif ext == ".jar":
            file_type = "Java Archive (JAR)"
            engine = "java"
            language = "java"

        # 3. Tệp Python Bytecode (.pyc)
        elif ext == ".pyc":
            file_type = "Python Bytecode (PYC)"
            engine = "python"
            language = "python"

        # 4. Nhận diện theo Magic Bytes nếu đuôi file bị đổi
        elif header.startswith(b"PK\x03\x04"):
            file_type = "Zip Package (APK/JAR)"
            engine = "java"
            language = "java"

        return {
            "file_type": file_type,
            "engine": engine,
            "language": language,
            "filename": p.name,
            "path": str(p.resolve()),
        }
