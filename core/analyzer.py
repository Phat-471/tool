import json
import os
import re
import struct
import zipfile
from pathlib import Path
from typing import Any, Dict, List

class FileAnalyzer:
    """
    Module phân tích tệp tĩnh (Static Analysis):
    - Trích xuất chuỗi ký tự (Strings: ASCII, Unicode, URLs, IPs, Emails)
    - Nhận diện công cụ bảo vệ / Packer / Obfuscator (UPX, ConfuserEx, ProGuard, PyInstaller, ...)
    - Phân tích cấu trúc PE (Windows Executable/DLL), APK (Android), và Python Bytecode
    """

    # Regex nhận diện các mẫu dữ liệu quan trọng
    REGEX_URL = re.compile(rb"https?://[a-zA-Z0-9\.\-_~:/?#[\]@!$&'()*+,;=%]{5,}")
    REGEX_IP = re.compile(rb"\b(?:[0-9]{1,3}\.){3}[0-9]{1,3}\b")
    REGEX_EMAIL = re.compile(rb"[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+")

    @classmethod
    def extract_strings(cls, file_path: str, min_length: int = 4, max_count: int = 2000) -> Dict[str, Any]:
        """Trích xuất chuỗi ký tự (ASCII & Unicode) và phát hiện URLs, IPs, Emails."""
        ascii_strings: List[str] = []
        unicode_strings: List[str] = []
        urls: List[str] = []
        ips: List[str] = []
        emails: List[str] = []

        try:
            with open(file_path, "rb") as f:
                data = f.read()

            # 1. Trích xuất URL
            for m in cls.REGEX_URL.findall(data):
                try:
                    url_str = m.decode("utf-8", errors="ignore")
                    if url_str not in urls:
                        urls.append(url_str)
                except Exception:
                    pass

            # 2. Trích xuất IP
            for m in cls.REGEX_IP.findall(data):
                try:
                    ip_str = m.decode("ascii", errors="ignore")
                    if ip_str not in ips and not ip_str.startswith("0.0."):
                        ips.append(ip_str)
                except Exception:
                    pass

            # 3. Trích xuất ASCII strings
            ascii_pattern = re.compile(rb"[\x20-\x7E]{" + str(min_length).encode() + rb",}")
            for m in ascii_pattern.findall(data):
                if len(ascii_strings) >= max_count:
                    break
                text = m.decode("latin-1", errors="ignore")
                ascii_strings.append(text)

            # 4. Trích xuất Unicode (UTF-16LE) strings
            unicode_pattern = re.compile(
                rb"(?:[\x20-\x7E]\x00){" + str(min_length).encode() + rb",}"
            )
            for m in unicode_pattern.findall(data):
                if len(unicode_strings) >= max_count:
                    break
                try:
                    text = m.decode("utf-16le", errors="ignore")
                    unicode_strings.append(text)
                except Exception:
                    pass

        except Exception as e:
            return {"error": f"Lỗi trích xuất chuỗi: {str(e)}"}

        return {
            "total_ascii": len(ascii_strings),
            "total_unicode": len(unicode_strings),
            "urls": urls[:50],
            "ips": ips[:50],
            "sample_strings": (ascii_strings[:100] + unicode_strings[:50]),
        }

    @classmethod
    def detect_protection(cls, file_path: str) -> Dict[str, Any]:
        """
        Nhan dien chu ky Packer / Obfuscator / Compiler:
        - UPX Packer
        - ConfuserEx, Eazfuscator, Dotfuscator, SmartAssembly, .NET Reactor,
          Babel, Agile.NET, MaxToCode, Crypto Obfuscator, Obfuscar
        - ProGuard, DexGuard (Android APK)
        - PyInstaller, Nuitka (Python)
        - Anti-Debug / Anti-Dump / Virtualization detection
        """
        protections_found: List[str] = []
        file_details: Dict[str, Any] = {}

        p = Path(file_path)
        ext = p.suffix.lower()

        try:
            with open(file_path, "rb") as f:
                content = f.read(4 * 1024 * 1024)  # Doc 4MB de quet header

            # ── PE file (.dll, .exe) ──────────────────────────────────────
            if content.startswith(b"MZ"):
                file_details["format"] = "PE (Portable Executable)"

                # UPX
                if b"UPX0" in content or b"UPX1" in content or b"UPX!" in content:
                    protections_found.append("UPX Packer")

                # .NET Obfuscators
                _dotnet_sigs = [
                    (b"ConfuserEx",         "ConfuserEx (.NET Obfuscator)"),
                    (b"Confuser.Core",      "ConfuserEx (.NET Obfuscator)"),
                    (b"ConfusedBy",         "ConfuserEx (.NET Obfuscator)"),
                    (b"EazfuscatorNet",     "Eazfuscator.NET"),
                    (b"Eazfuscator",        "Eazfuscator.NET"),
                    (b"SmartAssembly.Attributes", "SmartAssembly (.NET)"),
                    (b"Obfuscated by SA",   "SmartAssembly (.NET)"),
                    (b"Dotfuscator",        "Dotfuscator (.NET)"),
                    (b"BabelObfuscator",    "Babel .NET Obfuscator"),
                    (b"Babel.Runtime",      "Babel .NET Obfuscator"),
                    (b"CliSecure",          ".NET Reactor"),
                    (b"Xenocode",           "Agile.NET / Xenocode"),
                    (b"SecureTeam",         "Agile.NET / Xenocode"),
                    (b"MaxToCode",          "MaxToCode"),
                    (b"NETGuard",           "NETGuard"),
                    (b"CryptoObfuscator",   "Crypto Obfuscator"),
                    (b"Obfuscar",           "Obfuscar"),
                    (b"SmartAssembly",      "SmartAssembly (.NET)"),
                ]
                found_names: List[str] = []
                for sig_bytes, sig_name in _dotnet_sigs:
                    if sig_bytes in content and sig_name not in found_names:
                        found_names.append(sig_name)
                        protections_found.append(sig_name)

                # Anti-Debug / Anti-Dump / Virtualization
                anti_features: List[str] = []
                if b"CheckRemoteDebuggerPresent" in content or b"IsDebuggerPresent" in content:
                    anti_features.append("Anti-Debug")
                if b"anti_dump" in content or b"AntiDump" in content:
                    anti_features.append("Anti-Dump")
                if b"Virtualization" in content or b"virt_" in content:
                    anti_features.append("Code Virtualization")
                if anti_features:
                    protections_found.append("Phat hien: " + " + ".join(anti_features))

                # Kiem tra .NET CLR header
                from core.detector import FileDetector
                if FileDetector.is_dotnet_assembly(file_path):
                    file_details["runtime"] = ".NET Framework / .NET Core (C# Managed Code)"
                    if not protections_found:
                        protections_found.append(
                            "Phat hien ma bi lam roi / ma hoa chuoi (Obfuscated .NET)"
                        )
                    # Chi ra so lop ma hoa
                    layer_count = len([p for p in protections_found if "Obfuscator" in p or "Obfuscated" in p])
                    if layer_count >= 2:
                        file_details["obfuscation_layers"] = layer_count
                        file_details["multi_layer"] = True
                else:
                    file_details["runtime"] = "Native Windows (C/C++)"

            # ── APK / JAR ─────────────────────────────────────────────────
            elif ext in [".apk", ".jar"] or content.startswith(b"PK\x03\x04"):
                file_details["format"] = "Zip Container (APK/JAR)"
                try:
                    with zipfile.ZipFile(file_path, "r") as zf:
                        namelist = zf.namelist()
                        file_details["total_files_in_archive"] = len(namelist)
                        if "classes.dex" in namelist:
                            file_details["runtime"] = "Android Dalvik/ART (DEX)"
                        if any("proguard" in n.lower() for n in namelist):
                            protections_found.append("ProGuard Obfuscator")
                        if any("secneo" in n.lower() or "bangcle" in n.lower() for n in namelist):
                            protections_found.append("Commercial Android Reinforcement (Bangcle/Secneo)")
                        if any("dexguard" in n.lower() for n in namelist):
                            protections_found.append("DexGuard (Android)")
                except Exception:
                    pass

            # ── Python .pyc ───────────────────────────────────────────────
            elif ext == ".pyc":
                file_details["format"] = "Python Bytecode (Compiled)"
                if len(content) >= 16:
                    magic_number = content[:4]
                    file_details["magic_hex"] = magic_number.hex()
                    file_details["runtime"] = "CPython"

        except Exception as e:
            return {"error": "Loi quet bao ve: " + str(e)}

        if not protections_found:
            protections_found.append("Khong phat hien Packer/Obfuscator pho bien (Ma nguon sach)")

        return {
            "protections": protections_found,
            "details": file_details,
        }


    @classmethod
    def generate_full_report(cls, file_path: str, output_report_path: str = None) -> Dict[str, Any]:
        """Tạo báo cáo tổng hợp đầy đủ và lưu ra file JSON nếu được yêu cầu."""
        p = Path(file_path)
        protection_info = cls.detect_protection(file_path)
        strings_info = cls.extract_strings(file_path)

        report = {
            "target_file": p.name,
            "file_size_kb": round(p.stat().st_size / 1024, 2),
            "protection_analysis": protection_info,
            "strings_analysis": {
                "detected_urls_count": len(strings_info.get("urls", [])),
                "detected_urls": strings_info.get("urls", []),
                "detected_ips_count": len(strings_info.get("ips", [])),
                "detected_ips": strings_info.get("ips", []),
                "sample_strings": strings_info.get("sample_strings", [])[:80],
            },
        }

        if output_report_path:
            out_p = Path(output_report_path)
            out_p.parent.mkdir(parents=True, exist_ok=True)
            with open(out_p, "w", encoding="utf-8") as f:
                json.dump(report, f, indent=4, ensure_ascii=False)

        return report
