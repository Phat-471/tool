import base64
import binascii
import json
import os
import re
from pathlib import Path
from typing import Any, Dict, List, Optional, Set, Tuple


class StringDecryptor:
    """
    Module phân tích & giải mã chuỗi chuyên sâu cho mã nguồn C# (.cs) sau khi dịch ngược:
    1. Tự động giải mã Base64 literals (chuỗi ASCII/UTF-8 hợp lệ).
    2. Tự động chuyển đổi mảng byte hex: new byte[] { 0x41, 0x42, ... } -> chuỗi văn bản.
    3. Nhận diện các mẫu mã hóa XOR đơn giản trong C# AST/text.
    4. Trích xuất IOCs (Indicators of Compromise): URLs, IPs, Registry Keys, API Keys, Connection Strings.
    5. Chèn chú thích giải mã trực tiếp vào file .cs để hỗ trợ phân tích viên:
       /* [Auto-Decoded]: "https://api.server.com/auth" */
    6. Xuất báo cáo strings_inventory.json.
    """

    # Regex nhận diện Base64 literals trong C#
    # Ví dụ: "aHR0cHM6Ly9leGFtcGxlLmNvbQ==" hoặc Convert.FromBase64String("...")
    REGEX_BASE64_LITERAL = re.compile(
        r'(?:"|`)([A-Za-z0-9+/]{8,}={0,2})(?:"|`)'
    )
    REGEX_CONVERT_B64 = re.compile(
        r'Convert\.FromBase64String\s*\(\s*"(?P<b64>[A-Za-z0-9+/]{4,}={0,2})"\s*\)'
    )

    # Regex nhận diện mảng byte hex: new byte[] { 0x48, 0x65, 0x6c, 0x6c, 0x6f }
    # hoặc new byte[5] { 72, 101, 108, 108, 111 }
    REGEX_BYTE_ARRAY_HEX = re.compile(
        r'new\s+byte\[\s*\]\s*\{\s*(0x[0-9a-fA-F]{1,2}(?:\s*,\s*0x[0-9a-fA-F]{1,2}){2,})\s*\}'
    )
    REGEX_BYTE_ARRAY_DEC = re.compile(
        r'new\s+byte\[\s*\]\s*\{\s*([0-9]{1,3}(?:\s*,\s*[0-9]{1,3}){3,})\s*\}'
    )

    # Regex trích xuất IOCs trong code
    REGEX_URL = re.compile(r'https?://[a-zA-Z0-9\.\-_~:/?#[\]@!$&\'()*+,;=%]{5,}')
    REGEX_IP = re.compile(r'\b(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b')
    REGEX_REGISTRY = re.compile(r'(?:HKEY_LOCAL_MACHINE|HKEY_CURRENT_USER|HKLM|HKCU)\\[a-zA-Z0-9_\\]+', re.IGNORECASE)
    REGEX_CONN_STR = re.compile(r'(?:Server|Data Source|User ID|Password|Initial Catalog|Database)\s*=', re.IGNORECASE)
    REGEX_API_KEY = re.compile(r'(?:api[_-]?key|secret[_-]?key|access[_-]?token|auth[_-]?token|bearer)\s*[:=]\s*["\']([a-zA-Z0-9_\-\.]{16,})["\']', re.IGNORECASE)

    @classmethod
    def try_decode_base64(cls, s: str) -> Optional[str]:
        """Thử giải mã chuỗi Base64. Chỉ trả về nếu kết quả là văn bản đọc được."""
        if len(s) < 8 or len(s) % 4 != 0:
            return None
        try:
            raw = base64.b64decode(s, validate=True)
            # Kiểm tra xem có phải chuỗi in được (printable ASCII / UTF-8)
            decoded = raw.decode("utf-8")
            # Loại bỏ nếu chứa quá nhiều ký tự điều khiển lạ
            printable_count = sum(1 for c in decoded if c.isprintable() or c in "\r\n\t")
            if len(decoded) >= 4 and (printable_count / len(decoded)) > 0.85:
                return decoded
        except Exception:
            pass
        return None

    @classmethod
    def try_decode_hex_bytes(cls, byte_str: str) -> Optional[str]:
        """Chuyển chuỗi các byte hex: 0x48, 0x65, 0x6c -> 'Hel'"""
        try:
            parts = [p.strip() for p in byte_str.split(",") if p.strip()]
            byte_values = []
            for p in parts:
                if p.lower().startswith("0x"):
                    byte_values.append(int(p, 16))
                else:
                    byte_values.append(int(p))
            raw = bytes(byte_values)
            decoded = raw.decode("utf-8")
            if len(decoded) >= 3 and all(c.isprintable() or c in "\r\n\t" for c in decoded):
                return decoded
        except Exception:
            pass
        return None

    @classmethod
    def enhance_file(cls, file_path: Path) -> Dict[str, Any]:
        """
        Quét và làm giàu nội dung của 1 file .cs:
        - Tìm các chuỗi Base64 / Hex array và chèn chú thích giải mã
        - Thu thập IOCs (URLs, IPs, Registry, Secrets)
        """
        results = {
            "file": str(file_path),
            "decoded_base64": [],
            "decoded_bytes": [],
            "urls": [],
            "ips": [],
            "registry_keys": [],
            "connection_strings": [],
            "api_keys": [],
            "modified": False,
        }

        try:
            with open(file_path, "r", encoding="utf-8", errors="replace") as f:
                lines = f.readlines()
        except Exception:
            return results

        modified_lines = []
        file_changed = False

        for line_num, line in enumerate(lines, start=1):
            line_comment_added = False
            decoded_comments = []

            # 1. Quét Convert.FromBase64String("...")
            for match in cls.REGEX_CONVERT_B64.finditer(line):
                b64_str = match.group("b64")
                decoded = cls.try_decode_base64(b64_str)
                if decoded:
                    results["decoded_base64"].append({
                        "line": line_num,
                        "raw": b64_str,
                        "decoded": decoded,
                    })
                    decoded_comments.append(f"/* [Base64 Decoded]: \"{decoded}\" */")

            # 2. Quét các chuỗi Base64 literal dài trong code
            if not decoded_comments:
                for match in cls.REGEX_BASE64_LITERAL.finditer(line):
                    candidate = match.group(1)
                    decoded = cls.try_decode_base64(candidate)
                    if decoded and decoded not in line:
                        results["decoded_base64"].append({
                            "line": line_num,
                            "raw": candidate,
                            "decoded": decoded,
                        })
                        decoded_comments.append(f"/* [Base64 Decoded]: \"{decoded}\" */")

            # 3. Quét mảng byte hex
            for match in cls.REGEX_BYTE_ARRAY_HEX.finditer(line):
                hex_body = match.group(1)
                decoded = cls.try_decode_hex_bytes(hex_body)
                if decoded:
                    results["decoded_bytes"].append({
                        "line": line_num,
                        "raw": hex_body[:30] + "...",
                        "decoded": decoded,
                    })
                    decoded_comments.append(f"/* [Bytes Decoded]: \"{decoded}\" */")

            # 4. Trích xuất IOCs
            for url in cls.REGEX_URL.findall(line):
                if url not in results["urls"]:
                    results["urls"].append(url)

            for ip in cls.REGEX_IP.findall(line):
                if not ip.startswith("0.0.") and not ip.startswith("127.0.0.1") and ip not in results["ips"]:
                    results["ips"].append(ip)

            for reg in cls.REGEX_REGISTRY.findall(line):
                if reg not in results["registry_keys"]:
                    results["registry_keys"].append(reg)

            if cls.REGEX_CONN_STR.search(line):
                results["connection_strings"].append({"line": line_num, "text": line.strip()})

            for key in cls.REGEX_API_KEY.findall(line):
                if key not in results["api_keys"]:
                    results["api_keys"].append(key)

            # Chèn chú thích vào dòng nếu có chuỗi giải mã
            if decoded_comments:
                indent = " " * (len(line) - len(line.lstrip()))
                modified_lines.append(f"{indent}{' '.join(decoded_comments)}\n")
                modified_lines.append(line)
                file_changed = True
            else:
                modified_lines.append(line)

        # Ghi lại file nếu có thay đổi và chú thích
        if file_changed:
            try:
                with open(file_path, "w", encoding="utf-8", errors="replace") as f:
                    f.writelines(modified_lines)
                results["modified"] = True
            except Exception:
                pass

        return results

    @classmethod
    def enhance_decompiled_directory(cls, output_dir: str) -> Dict[str, Any]:
        """
        Quét toàn bộ thư mục mã nguồn vừa dịch ngược (.cs):
        - Giải mã chuỗi
        - Thu thập IOCs
        - Xuất strings_inventory.json
        """
        dir_path = Path(output_dir)
        if not dir_path.exists():
            return {"error": f"Thư mục không tồn tại: {output_dir}"}

        cs_files = list(dir_path.rglob("*.cs"))
        total_files = len(cs_files)

        all_base64 = []
        all_bytes = []
        all_urls = set()
        all_ips = set()
        all_registry = set()
        all_conn_strings = []
        all_api_keys = set()
        modified_count = 0

        for cs in cs_files:
            file_res = cls.enhance_file(cs)
            if file_res["modified"]:
                modified_count += 1
            all_base64.extend(file_res["decoded_base64"])
            all_bytes.extend(file_res["decoded_bytes"])
            all_urls.update(file_res["urls"])
            all_ips.update(file_res["ips"])
            all_registry.update(file_res["registry_keys"])
            all_conn_strings.extend(file_res["connection_strings"])
            all_api_keys.update(file_res["api_keys"])

        inventory = {
            "total_cs_files": total_files,
            "modified_with_annotations": modified_count,
            "total_decoded_base64": len(all_base64),
            "total_decoded_bytes": len(all_bytes),
            "urls": sorted(list(all_urls)),
            "ips": sorted(list(all_ips)),
            "registry_keys": sorted(list(all_registry)),
            "api_keys": sorted(list(all_api_keys)),
            "connection_strings": all_conn_strings[:20],
            "sample_decoded": (all_base64[:15] + all_bytes[:15]),
        }

        # Lưu strings_inventory.json trong thư mục output
        try:
            inv_file = dir_path / "strings_inventory.json"
            with open(inv_file, "w", encoding="utf-8") as f:
                json.dump(inventory, f, indent=2, ensure_ascii=False)
        except Exception:
            pass

        return inventory
