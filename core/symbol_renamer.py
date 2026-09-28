"""
core/symbol_renamer.py
Module chuyên sâu tự động gỡ rối mã nguồn (Deobfuscator) & Chuẩn hóa định danh (Symbol Renamer)
cho mã nguồn C# và các ngôn ngữ sau khi dịch ngược.

Khắc phục triệt để:
1. Tên thư mục bị mã hóa rác (ví dụ: ajhmisBcZrLc4u5dRKZn, AOvG6sBO4iXLpJ2US7m2 -> UI, CadServices, Module_01...)
   Đồng thời đồng bộ hóa toàn bộ lệnh 'namespace' và 'using' trên toàn bộ dự án.
2. Tên tệp .cs bị mã hóa rác (ví dụ: A130wmGstfbANh7SujrO.cs -> AppDelegate_001.cs, LoginForm.cs...)
3. Tên lớp, struct, interface, delegate, enum bị làm rối -> Chuẩn hóa theo tiêu đề Form, chức năng hoặc số thứ tự.
4. Tên biến, backing fields, controls (WinForms, WPF, [AccessedThroughProperty("...")]) -> Khôi phục chính xác tên gốc.
5. Tên hàm / phương thức bị làm rối (uQ4DbMFRj7Q, IveTMUdyS5E, LyqDDLONXGe -> HandleEvent_..., ExecuteAction_..., GetString_...)
6. Đồng bộ toàn bộ tệp dự án (.csproj, .sln) và xuất báo cáo chi tiết renaming_report.json.
"""

import os
import re
import json
import shutil
from pathlib import Path
from typing import Any, Dict, List, Optional, Set, Tuple


class SymbolRenamer:
    """Bộ công cụ tối thượng gỡ rối mã nguồn C# và chuẩn hóa toàn diện cấu trúc thư mục, tệp, hàm, biến."""

    # Regex nhận diện [AccessedThroughProperty("TênGốc")]
    REGEX_ACCESSED_THROUGH = re.compile(
        r'\[AccessedThroughProperty\s*\(\s*"(?P<prop>[^"]+)"\s*\)\]'
        r'(?:\s*\[[^\]]+\])*'
        r'\s*(?P<modifiers>(?:public|private|protected|internal|static|readonly|volatile|\s)+)'
        r'\s+(?P<type>[A-Za-z0-9_<>\[\],.\s]+?)'
        r'\s+(?P<field>[A-Za-z0-9_]+)\s*;',
        re.MULTILINE
    )

    # Regex nhận diện backing field tự sinh thông thường của C#:
    REGEX_BACKING_FIELD = re.compile(
        r'\[CompilerGenerated\]\s*(?P<modifiers>(?:public|private|protected|internal|static|readonly|\s)+)'
        r'\s+(?P<type>[A-Za-z0-9_<>\[\],.\s]+?)'
        r'\s+<(?P<prop>[A-Za-z0-9_]+)>k__BackingField\s*;',
        re.MULTILINE
    )

    # Regex tìm khai báo class/interface/struct/enum/record
    REGEX_TYPE_DECL = re.compile(
        r'(?P<modifiers>(?:public|private|protected|internal|abstract|sealed|static|partial|\s)*)'
        r'\b(?P<kind>class|interface|struct|enum|record)\s+(?P<name>[A-Za-z0-9_]+)'
        r'(?:\s*<[^>]+>)?'
        r'(?:\s*:\s*(?P<base>[A-Za-z0-9_<>.,\s]+))?'
        r'\s*[\{;]',
        re.MULTILINE
    )

    # Regex tìm khai báo delegate
    REGEX_DELEGATE_DECL = re.compile(
        r'(?P<modifiers>(?:public|private|protected|internal|\s)*)'
        r'\bdelegate\s+(?P<ret_type>[A-Za-z0-9_<>\[\],.\s]+?)'
        r'\s+(?P<name>[A-Za-z0-9_]+)'
        r'(?:\s*<[^>]+>)?'
        r'\s*\((?P<params>[^)]*)\)\s*;',
        re.MULTILINE
    )

    # Regex tìm khai báo namespace
    REGEX_NAMESPACE = re.compile(
        r'\bnamespace\s+(?P<ns>[A-Za-z0-9_.]+)\s*[\{;]',
        re.MULTILINE
    )

    # Regex tìm lệnh using
    REGEX_USING = re.compile(
        r'\busing\s+(?P<ns>[A-Za-z0-9_.]+)\s*;',
        re.MULTILINE
    )

    # Regex tìm Title của Windows Form: this.Text = "Tiêu đề";
    REGEX_FORM_TEXT = re.compile(
        r'(?:this\.)?Text\s*=\s*"(?P<title>[^"]+)";'
    )

    # Regex tìm lệnh AutoCAD Command: [CommandMethod("MyCommand")]
    REGEX_AUTOCAD_CMD = re.compile(
        r'\[CommandMethod\s*\(\s*"(?P<cmd>[^"]+)"',
        re.MULTILINE
    )

    # Regex tìm khai báo field: private [static] Type name;
    REGEX_FIELD_DECL = re.compile(
        r'(?P<modifiers>(?:public|private|protected|internal|static|readonly|volatile|\s)+)'
        r'\s+(?P<type>[A-Za-z0-9_<>\[\],.]+)'
        r'\s+(?P<name>[A-Za-z0-9_]+)\s*;',
        re.MULTILINE
    )

    # Regex tìm khai báo method:
    REGEX_METHOD_DECL = re.compile(
        r'(?P<modifiers>(?:public|private|protected|internal|static|virtual|override|async|\s)+)'
        r'\s+(?P<ret_type>[A-Za-z0-9_<>\[\],.\s]+?)'
        r'\s+(?P<name>[A-Za-z0-9_]+)'
        r'(?:\s*<[^>]+>)?'
        r'\s*\((?P<params>[^)]*)\)\s*(?:where[^{]+)?[\{;]',
        re.MULTILINE
    )

    # Các từ khóa C# chuẩn
    CSHARP_KEYWORDS = {
        "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char",
        "checked", "class", "const", "continue", "decimal", "default", "delegate",
        "do", "double", "else", "enum", "event", "explicit", "extern", "false",
        "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit",
        "in", "int", "interface", "internal", "is", "lock", "long", "namespace",
        "new", "null", "object", "operator", "out", "override", "params", "private",
        "protected", "public", "readonly", "ref", "return", "sbyte", "sealed",
        "short", "sizeof", "stackalloc", "static", "string", "struct", "switch",
        "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked",
        "unsafe", "ushort", "using", "virtual", "void", "volatile", "while", "record"
    }

    # Các từ vựng lập trình thông dụng không coi là obfuscated
    KNOWN_TERMS = {
        "sha256", "sha512", "sha1", "md5", "win32", "win64", "x86", "x64",
        "ipv4", "ipv6", "base64", "utf8", "utf16", "utf32", "ascii",
        "i", "j", "k", "n", "x", "y", "z", "e", "id", "db", "ui", "ok", "ms",
        "fs", "io", "to", "at", "dx", "dy", "dz", "pt", "cad", "acad", "autocad",
        "color", "width", "height", "length", "size", "data", "info", "flag",
        "count", "index", "value", "key", "node", "item", "temp", "result"
    }

    COMMON_ENGLISH_WORDS = [
        "form", "button", "label", "text", "timer", "click", "data", "view",
        "manager", "service", "control", "item", "list", "table", "client",
        "server", "request", "response", "model", "helper", "util", "page",
        "dialog", "panel", "box", "grid", "event", "command", "cad", "layer",
        "block", "drawing", "point", "line", "entity", "attribute", "config",
        "setting", "user", "file", "path", "stream", "reader", "writer", "string",
        "app", "main", "core", "tool", "export", "import", "report", "calc",
        "system", "common", "handler", "factory", "provider", "worker", "job"
    ]

    @classmethod
    def is_obfuscated_name(cls, name: str) -> bool:
        """
        Kiểm tra độ tin cậy cao xem một tên định danh có bị làm rối hay không.
        Bao gồm:
        - Chuỗi ngẫu nhiên chữ hoa, thường kết hợp số (ajhmisBcZrLc4u5dRKZn, AOvG6sBO4iXLpJ2US7m2, uQ4DbMFRj7Q)
        - Chuỗi ngẫu nhiên toàn chữ cái nhưng tráo đổi chữ hoa thường bất thường (LyqDDLONXGe, CUwDDzkpuuL)
        - Cụm phụ âm bất thường >= 4 phụ âm liên tiếp (dnUDFwhWrBF, zkp...)
        - Decompiler artifacts (<>c, _0x, A_0, Getstatic_8, Class_iemCcl...)
        - Tên 1-2 ký tự vô nghĩa (ngoại trừ loop/coordinate vars)
        """
        if not name or name.lower() in cls.CSHARP_KEYWORDS or name.lower() in cls.KNOWN_TERMS:
            return False

        # 1. Ký tự không phải ASCII hoặc ký tự điều khiển
        try:
            name.encode("ascii")
        except UnicodeEncodeError:
            return True

        # 2. Decompiler artifacts hoặc compiler-generated
        if name.startswith("<>") or name.startswith("_0x") or "__" in name or name.startswith("$$"):
            return True
        if name.startswith("Class_N_003CModule") or name.startswith("Class_VB_AnonymousType"):
            return False

        # 3. Tiền tố ghép decompiler như Class_iemCclBOqq1tsAdH9mtk, Getstatic_8
        if name.startswith("Class_") and len(name) >= 12:
            return True
        if re.match(r'^(?:Getstatic|ExecuteAction|HandleEvent|smethod|method|field|class|Delegate)_\d+$', name):
            return False  # Tên đã chuẩn hóa tạm thời

        # 4. Tên 1-2 ký tự lạ
        if len(name) <= 2 and name.lower() not in cls.KNOWN_TERMS:
            return True

        # 5. Mẫu artifact dạng A_0, fld_1, int_0
        if re.match(r'^[A-Za-z]_[0-9]+$', name):
            return True

        # 6. Kiểm tra các từ tiếng Anh có nghĩa rõ ràng
        name_lower = name.lower()
        has_english_word = any(w in name_lower for w in cls.COMMON_ENGLISH_WORDS)
        if has_english_word:
            # Nếu là từ ghép thông thường như CadManager, UserControl không chứa số lộn xộn
            if not any(c.isdigit() for c in name) and len(name) < 25:
                # Kiểm tra xem có cấu trúc PascalCase hợp lệ không
                pascal_words = re.findall(r'[A-Z][a-z0-9]*', name)
                if pascal_words and "".join(pascal_words) == name:
                    return False

        # 7. Chuỗi ngẫu nhiên có cả chữ hoa, chữ thường và chữ số (độ dài >= 6)
        has_upper = any(c.isupper() for c in name)
        has_lower = any(c.islower() for c in name)
        has_digit = any(c.isdigit() for c in name)

        if len(name) >= 6 and has_upper and has_lower and has_digit:
            return True

        # 8. Chuỗi dài ngẫu nhiên >= 14 ký tự
        if len(name) >= 14 and not has_english_word:
            return True

        # 9. Cụm phụ âm bất thường (4 phụ âm trở lên liên tiếp)
        # Tiếng Anh/Việt hiếm khi có 4 phụ âm liên tiếp trong một từ đơn
        consonants = re.search(r'[bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ]{4,}', name)
        if consonants and not any(k in name_lower for k in ["struct", "length", "string"]):
            return True

        # 10. Tráo đổi chữ hoa thường bất thường:
        # Ví dụ: chữ thường xen kẽ 2+ chữ hoa rồi chữ thường (LyqDDLONXGe, CUwDDzkpuuL)
        if len(name) >= 6:
            if re.search(r'[a-z][A-Z]{2,}[a-z]', name) or re.search(r'[A-Z]{2,}[a-z][A-Z]', name):
                return True

        # 11. Tỷ lệ nguyên âm cực thấp (< 20%) ở chuỗi dài >= 6
        if len(name) >= 6:
            vowels = sum(1 for c in name_lower if c in "aeiouy")
            if vowels / len(name) < 0.20:
                return True

        return False

    @classmethod
    def clean_identifier(cls, raw: str) -> str:
        """Tạo tên định danh C# hợp lệ từ chuỗi bất kỳ."""
        # Chuyển đổi tiếng Việt có dấu thành không dấu
        accent_map = {
            'à': 'a', 'á': 'a', 'ả': 'a', 'ã': 'a', 'ạ': 'a',
            'ă': 'a', 'ằ': 'a', 'ắ': 'a', 'ẳ': 'a', 'ẵ': 'a', 'ặ': 'a',
            'â': 'a', 'ầ': 'a', 'ấ': 'a', 'ẩ': 'a', 'ẫ': 'a', 'ậ': 'a',
            'è': 'e', 'é': 'e', 'ẻ': 'e', 'ẽ': 'e', 'ẹ': 'e',
            'ê': 'e', 'ề': 'e', 'ế': 'e', 'ể': 'e', 'ễ': 'e', 'ệ': 'e',
            'ì': 'i', 'í': 'i', 'ỉ': 'i', 'ĩ': 'i', 'ị': 'i',
            'ò': 'o', 'ó': 'o', 'ỏ': 'o', 'õ': 'o', 'ọ': 'o',
            'ô': 'o', 'ồ': 'o', 'ố': 'o', 'ổ': 'o', 'ỗ': 'o', 'ộ': 'o',
            'ơ': 'o', 'ờ': 'o', 'ớ': 'o', 'ở': 'o', 'ỡ': 'o', 'ợ': 'o',
            'ù': 'u', 'ú': 'u', 'ủ': 'u', 'ũ': 'u', 'ụ': 'u',
            'ư': 'u', 'ừ': 'u', 'ứ': 'u', 'ử': 'u', 'ữ': 'u', 'ự': 'u',
            'ỳ': 'y', 'ý': 'y', 'ỷ': 'y', 'ỹ': 'y', 'ỵ': 'y',
            'đ': 'd',
            'À': 'A', 'Á': 'A', 'Ả': 'A', 'Ã': 'A', 'Ạ': 'A',
            'Ă': 'A', 'Ằ': 'A', 'Ắ': 'A', 'Ẳ': 'A', 'Ẵ': 'A', 'Ặ': 'A',
            'Â': 'A', 'Ầ': 'A', 'Ấ': 'A', 'Ẩ': 'A', 'Ẫ': 'A', 'Ậ': 'A',
            'È': 'E', 'É': 'E', 'Ẻ': 'E', 'Ẽ': 'E', 'Ẹ': 'E',
            'Ê': 'E', 'Ề': 'E', 'Ế': 'E', 'Ể': 'E', 'Ễ': 'E', 'Ệ': 'E',
            'Ì': 'I', 'Í': 'I', 'Ỉ': 'I', 'Ĩ': 'I', 'Ị': 'I',
            'Ò': 'O', 'Ó': 'O', 'Ỏ': 'O', 'Õ': 'O', 'Ọ': 'O',
            'Ô': 'O', 'Ồ': 'O', 'Ố': 'O', 'Ổ': 'O', 'Ỗ': 'O', 'Ộ': 'O',
            'Ơ': 'O', 'Ờ': 'O', 'Ớ': 'O', 'Ở': 'O', 'Ỡ': 'O', 'Ợ': 'O',
            'Ù': 'U', 'Ú': 'U', 'Ủ': 'U', 'Ũ': 'U', 'Ụ': 'U',
            'Ư': 'U', 'Ừ': 'U', 'Ứ': 'U', 'Ử': 'U', 'Ữ': 'U', 'Ự': 'U',
            'Ỳ': 'Y', 'Ý': 'Y', 'Ỷ': 'Y', 'Ỹ': 'Y', 'Ỵ': 'Y',
            'Đ': 'D'
        }
        res = []
        for ch in raw:
            res.append(accent_map.get(ch, ch))
        normalized = "".join(res)

        # Tách các từ và viết hoa chữ cái đầu (PascalCase)
        words = re.findall(r'[A-Za-z0-9]+', normalized)
        if not words:
            return "Item"
        cleaned = "".join(w.capitalize() for w in words)
        if cleaned[0].isdigit():
            cleaned = f"Item_{cleaned}"
        return cleaned

    # ------------------------------------------------------------------
    # 1. Khôi phục Controls & Backing Fields
    # ------------------------------------------------------------------
    @classmethod
    def restore_accessed_through_properties(cls, content: str) -> Tuple[str, List[Dict[str, str]]]:
        """Khôi phục các biến control có thuộc tính [AccessedThroughProperty("TênGốc")]."""
        replacements: List[Dict[str, str]] = []
        renamed_map: Dict[str, str] = {}

        for match in cls.REGEX_ACCESSED_THROUGH.finditer(content):
            prop_name = match.group("prop").strip()
            field_name = match.group("field").strip()
            field_type = match.group("type").strip()

            if not prop_name or not field_name or prop_name == field_name:
                continue

            new_field_name = f"_{cls.clean_identifier(prop_name)}"
            renamed_map[field_name] = new_field_name

            replacements.append({
                "type": "control_backing_field",
                "old_name": field_name,
                "new_name": new_field_name,
                "property_name": prop_name,
                "control_type": field_type
            })

        for match in cls.REGEX_BACKING_FIELD.finditer(content):
            prop_name = match.group("prop").strip()
            old_field = f"<{prop_name}>k__BackingField"
            new_field = f"_{cls.clean_identifier(prop_name)}"
            renamed_map[old_field] = new_field
            replacements.append({
                "type": "property_backing_field",
                "old_name": old_field,
                "new_name": new_field,
                "property_name": prop_name,
                "control_type": match.group("type").strip()
            })

        updated_content = content
        for old_name, new_name in renamed_map.items():
            if old_name.startswith("<"):
                updated_content = updated_content.replace(old_name, new_field)
            else:
                pattern = r'\b' + re.escape(old_name) + r'\b'
                updated_content = re.sub(pattern, new_name, updated_content)

        return updated_content, replacements

    # ------------------------------------------------------------------
    # 2. Nhận diện chủ đề thư mục (Domain / Layer Theme)
    # ------------------------------------------------------------------
    @classmethod
    def detect_folder_theme(cls, cs_texts: List[str], folder_index: int) -> str:
        """Phân tích các tệp .cs trong thư mục để đặt tên thư mục & namespace có ý nghĩa."""
        combined = " ".join(cs_texts[:10])  # Phân tích tối đa 10 file đầu

        # 1. Giao diện người dùng
        if any(w in combined for w in ["System.Windows.Forms", "System.Windows.Controls", "InitializeComponent", "Form", "UserControl", "MetroForm"]):
            return "UI" if folder_index == 1 else f"UI_Module_{folder_index:02d}"

        # 2. Tương tác CAD / AutoCAD API
        if any(w in combined for w in ["Autodesk.AutoCAD", "GrxCAD", "ZwCAD", "CommandMethod", "EditorInput", "DatabaseServices"]):
            return "CadEngine" if folder_index == 1 else f"CadServices_{folder_index:02d}"

        # 3. Cơ sở dữ liệu / Lưu trữ
        if any(w in combined for w in ["System.Data", "SqlClient", "OleDb", "SQLite", "Repository", "DbContext"]):
            return "DataModels" if folder_index == 1 else f"Data_{folder_index:02d}"

        # 4. Bảo mật / Mã hóa / Bản quyền
        if any(w in combined for w in ["License", "CryptoStream", "Rijndael", "MD5Crypto", "Security", "HashAlgorithm"]):
            return "Security" if folder_index == 1 else f"Licensing_{folder_index:02d}"

        # 5. Xuất / Nhập báo cáo / Excel / PDF
        if any(w in combined for w in ["iTextSharp", "PdfPig", "Excel", "Export", "Report"]):
            return "Reports" if folder_index == 1 else f"Export_{folder_index:02d}"

        # 6. Delegates
        if combined.count("delegate ") >= 3:
            return f"Delegates_{folder_index:02d}"

        # Mặc định: Module_01, Module_02...
        return f"Module_{folder_index:02d}"

    # ------------------------------------------------------------------
    # 3. Chuẩn hóa tên Hàm và Biến cục bộ trong từng File
    # ------------------------------------------------------------------
    @classmethod
    def clean_obfuscated_methods_and_fields(cls, content: str) -> Tuple[str, List[Dict[str, str]]]:
        """Chuẩn hóa tên các trường và hàm có tên bị làm rối trong file."""
        renames: List[Dict[str, str]] = []
        renamed_map: Dict[str, str] = {}

        # 3.1 Field declaration
        field_idx = 1
        for match in cls.REGEX_FIELD_DECL.finditer(content):
            field_name = match.group("name")
            field_type = match.group("type")

            if not cls.is_obfuscated_name(field_name):
                continue

            type_clean = cls.clean_identifier(field_type.split(".")[-1].replace("[]", "Array"))
            if type_clean.startswith("I") and len(type_clean) > 2 and type_clean[1].isupper():
                type_clean = type_clean[1:]

            new_name = f"_{type_clean[:1].lower()}{type_clean[1:]}_{field_idx}"
            field_idx += 1

            renamed_map[field_name] = new_name
            renames.append({
                "type": "field",
                "old_name": field_name,
                "new_name": new_name,
                "field_type": field_type
            })

        # 3.2 Method declaration
        method_idx = 1
        for match in cls.REGEX_METHOD_DECL.finditer(content):
            method_name = match.group("name")
            ret_type = match.group("ret_type").strip()
            params = match.group("params")

            if not cls.is_obfuscated_name(method_name):
                continue

            # Phân loại method
            if "EventArgs" in params:
                new_name = f"HandleEvent_{method_idx}"
            elif ret_type.lower() == "void":
                new_name = f"ExecuteAction_{method_idx}"
            elif ret_type.lower() == "bool":
                new_name = f"IsValid_{method_idx}"
            else:
                clean_ret = cls.clean_identifier(ret_type.split(".")[-1])
                new_name = f"Get{clean_ret}_{method_idx}"
            method_idx += 1

            renamed_map[method_name] = new_name
            renames.append({
                "type": "method",
                "old_name": method_name,
                "new_name": new_name,
                "return_type": ret_type
            })

        # 3.3 Tham số compiler tự sinh như type_0, int_0, string_0
        param_pattern = re.compile(r'\b(?P<type>[A-Za-z0-9_<>]+)\s+(?P<pname>[a-z]+_[0-9]+)\b')
        for match in param_pattern.finditer(content):
            ptype = match.group("type")
            pname = match.group("pname")
            c_type = cls.clean_identifier(ptype.split(".")[-1])
            new_pname = f"{c_type[:1].lower()}{c_type[1:]}Param"
            if new_pname != pname and pname not in renamed_map:
                renamed_map[pname] = new_pname

        updated_content = content
        for old_name, new_name in renamed_map.items():
            pattern = r'\b' + re.escape(old_name) + r'\b'
            updated_content = re.sub(pattern, new_name, updated_content)

        return updated_content, renames

    # ------------------------------------------------------------------
    # 4. Quét toàn bộ Dự án: Chuẩn hóa Thư mục, Tệp, Lớp, Hàm & Biến
    # ------------------------------------------------------------------
    @classmethod
    def enhance_and_rename_directory(cls, source_dir: str) -> Dict[str, Any]:
        """
        Quy trình chuẩn hóa và gỡ rối toàn diện cấp độ Dự án (Project-wide):
        Giai đoạn 1: Chuẩn hóa và đổi tên các thư mục bị mã hóa rác (ajhmisBcZrLc4u5dRKZn...) -> đồng bộ namespace & using.
        Giai đoạn 2: Quét toàn bộ các lớp, struct, delegate, form để xây dựng bảng ánh xạ định danh toàn cục.
        Giai đoạn 3: Cập nhật nội dung mã nguồn (.cs) với các định danh mới và khử tên biến/hàm rác.
        Giai đoạn 4: Đổi tên các file .cs đồng bộ với tên lớp/delegate mới.
        Giai đoạn 5: Đồng bộ tệp .csproj và .sln, xuất renaming_report.json.
        """
        dir_path = Path(source_dir)
        if not dir_path.exists():
            return {"success": False, "message": "Thư mục không tồn tại."}

        report: Dict[str, Any] = {
            "total_files_processed": 0,
            "controls_restored": 0,
            "classes_renamed": 0,
            "fields_renamed": 0,
            "methods_renamed": 0,
            "files_renamed": 0,
            "directories_renamed": 0,
            "details": {
                "directories": [],
                "files": [],
                "classes": [],
                "controls": [],
                "fields": [],
                "methods": []
            }
        }

        # Bảng ánh xạ toàn cục: old_symbol -> new_symbol
        global_type_map: Dict[str, str] = {}
        global_ns_map: Dict[str, str] = {}
        file_rename_map: Dict[str, str] = {}

        # ══════════════════════════════════════════════════════════════
        # GIAI ĐOẠN 1: Chuẩn hóa Tên Thư mục & Namespace
        # ══════════════════════════════════════════════════════════════
        subdirs = [p for p in dir_path.iterdir() if p.is_dir() and not p.name.startswith((".", "obj", "bin"))]
        obf_dirs = [d for d in subdirs if cls.is_obfuscated_name(d.name)]

        used_dir_names: Set[str] = {d.name for d in subdirs if not cls.is_obfuscated_name(d.name)}
        folder_counter = 1

        for obf_dir in obf_dirs:
            cs_files_in_dir = list(obf_dir.glob("*.cs"))
            sample_texts = []
            for f in cs_files_in_dir[:10]:
                try:
                    sample_texts.append(f.read_text(encoding="utf-8", errors="ignore"))
                except Exception:
                    pass

            theme_name = cls.detect_folder_theme(sample_texts, folder_counter)
            folder_counter += 1

            # Đảm bảo tên duy nhất
            candidate_dir_name = theme_name
            dup_idx = 1
            while candidate_dir_name in used_dir_names:
                candidate_dir_name = f"{theme_name}_{dup_idx}"
                dup_idx += 1
            used_dir_names.add(candidate_dir_name)

            old_dir_name = obf_dir.name
            new_dir_path = obf_dir.parent / candidate_dir_name

            try:
                obf_dir.rename(new_dir_path)
                global_ns_map[old_dir_name] = candidate_dir_name
                report["directories_renamed"] += 1
                report["details"]["directories"].append({
                    "old_dir": old_dir_name,
                    "new_dir": candidate_dir_name
                })
            except Exception:
                pass

        # ══════════════════════════════════════════════════════════════
        # GIAI ĐOẠN 2: Quét toàn bộ Dự án để lập Bảng ánh xạ Type / Class / Delegate
        # ══════════════════════════════════════════════════════════════
        all_cs_files = list(dir_path.rglob("*.cs"))
        class_counter = 1
        delegate_counter = 1

        for cs_path in all_cs_files:
            try:
                content = cs_path.read_text(encoding="utf-8", errors="replace")
            except Exception:
                continue

            # 2.1 Kiểm tra delegate
            for del_m in cls.REGEX_DELEGATE_DECL.finditer(content):
                del_name = del_m.group("name")
                if cls.is_obfuscated_name(del_name):
                    new_del = f"AppDelegate_{delegate_counter:03d}"
                    delegate_counter += 1
                    global_type_map[del_name] = new_del

            # 2.2 Kiểm tra class / struct / interface / enum
            form_title_m = cls.REGEX_FORM_TEXT.search(content)
            form_title = form_title_m.group("title").strip() if form_title_m else None

            autocad_cmd_m = cls.REGEX_AUTOCAD_CMD.search(content)
            autocad_cmd = autocad_cmd_m.group("cmd").strip() if autocad_cmd_m else None

            for type_m in cls.REGEX_TYPE_DECL.finditer(content):
                kind = type_m.group("kind")
                type_name = type_m.group("name")
                base_type = type_m.group("base") or ""

                if not cls.is_obfuscated_name(type_name):
                    continue

                new_type_name = None
                if "static void Main(" in content:
                    new_type_name = "Program"
                elif autocad_cmd:
                    new_type_name = f"{cls.clean_identifier(autocad_cmd)}Command"
                elif any(f in base_type for f in ["Form", "UserControl", "MetroForm", "FormBase"]):
                    if form_title:
                        new_type_name = f"{cls.clean_identifier(form_title)}Form"
                    else:
                        new_type_name = f"AppForm_{class_counter:03d}"
                elif "ApplicationSettingsBase" in base_type:
                    new_type_name = "AppSettings"
                else:
                    new_type_name = f"App{kind.capitalize()}_{class_counter:03d}"
                    class_counter += 1

                if new_type_name and new_type_name != type_name:
                    global_type_map[type_name] = new_type_name
                    report["classes_renamed"] += 1
                    report["details"]["classes"].append({
                        "old_name": type_name,
                        "new_name": new_type_name,
                        "kind": kind
                    })

        # ══════════════════════════════════════════════════════════════
        # GIAI ĐOẠN 3: Áp dụng Chuẩn hóa vào Nội dung từng Tệp .cs
        # ══════════════════════════════════════════════════════════════
        for cs_path in all_cs_files:
            if not cs_path.exists():
                continue
            try:
                content = cs_path.read_text(encoding="utf-8", errors="replace")
            except Exception:
                continue

            report["total_files_processed"] += 1
            modified = False

            # 3.1 Khôi phục controls & backing fields
            content, ctrl_res = cls.restore_accessed_through_properties(content)
            if ctrl_res:
                report["controls_restored"] += len(ctrl_res)
                report["details"]["controls"].extend(ctrl_res)
                modified = True

            # 3.2 Cập nhật Namespace và Using theo global_ns_map
            for old_ns, new_ns in global_ns_map.items():
                if old_ns in content:
                    # Thay thế namespace cũ
                    content = re.sub(r'\bnamespace\s+' + re.escape(old_ns) + r'\b', f"namespace {new_ns}", content)
                    content = re.sub(r'\busing\s+' + re.escape(old_ns) + r'\b', f"using {new_ns}", content)
                    content = re.sub(r'\b' + re.escape(old_ns) + r'\.', f"{new_ns}.", content)
                    modified = True

            # 3.3 Cập nhật các Loại dữ liệu / Lớp theo global_type_map
            for old_type, new_type in global_type_map.items():
                if old_type in content:
                    pattern = r'\b' + re.escape(old_type) + r'\b'
                    content = re.sub(pattern, new_type, content)
                    modified = True

            # 3.4 Chuẩn hóa tên hàm và biến cục bộ trong file
            content, fld_mth_res = cls.clean_obfuscated_methods_and_fields(content)
            if fld_mth_res:
                flds = [x for x in fld_mth_res if x.get("type") == "field"]
                mths = [x for x in fld_mth_res if x.get("type") == "method"]
                report["fields_renamed"] += len(flds)
                report["methods_renamed"] += len(mths)
                report["details"]["fields"].extend(flds)
                report["details"]["methods"].extend(mths)
                modified = True

            # Ghi lại tệp đã xử lý
            if modified:
                try:
                    cs_path.write_text(content, encoding="utf-8")
                except Exception:
                    pass

        # ══════════════════════════════════════════════════════════════
        # GIAI ĐOẠN 4: Đổi tên Tệp .cs đồng bộ với Class / Delegate mới
        # ══════════════════════════════════════════════════════════════
        # Quét lại danh sách tệp .cs (bao gồm cả các thư mục đã được đổi tên)
        current_cs_files = list(dir_path.rglob("*.cs"))
        for cs_path in current_cs_files:
            stem = cs_path.stem
            target_new_stem = global_type_map.get(stem)

            if not target_new_stem and cls.is_obfuscated_name(stem):
                # Kiểm tra bên trong tệp xem có class nào đã được đổi tên không
                try:
                    txt = cs_path.read_text(encoding="utf-8", errors="ignore")
                    m = cls.REGEX_TYPE_DECL.search(txt) or cls.REGEX_DELEGATE_DECL.search(txt)
                    if m:
                        cname = m.group("name")
                        if not cls.is_obfuscated_name(cname):
                            target_new_stem = cname
                except Exception:
                    pass

            if target_new_stem and target_new_stem != stem:
                new_file_name = f"{cls.clean_identifier(target_new_stem)}.cs"
                new_file_path = cs_path.parent / new_file_name

                if not new_file_path.exists() or new_file_path == cs_path:
                    try:
                        cs_path.rename(new_file_path)
                        file_rename_map[cs_path.name] = new_file_name
                        report["files_renamed"] += 1
                        report["details"]["files"].append({
                            "old_file": cs_path.name,
                            "new_file": new_file_name
                        })
                    except Exception:
                        pass

        # ══════════════════════════════════════════════════════════════
        # GIAI ĐOẠN 5: Đồng bộ hóa Dự án .csproj & .sln
        # ══════════════════════════════════════════════════════════════
        for proj_file in list(dir_path.rglob("*.csproj")) + list(dir_path.rglob("*.sln")):
            try:
                p_text = proj_file.read_text(encoding="utf-8", errors="replace")
                p_modified = False

                # Cập nhật thư mục
                for old_d, new_d in global_ns_map.items():
                    if old_d in p_text:
                        p_text = p_text.replace(f"{old_d}\\", f"{new_d}\\").replace(f"{old_d}/", f"{new_d}/")
                        p_modified = True

                # Cập nhật tệp
                for old_f, new_f in file_rename_map.items():
                    if old_f in p_text:
                        p_text = p_text.replace(old_f, new_f)
                        p_modified = True

                if p_modified:
                    proj_file.write_text(p_text, encoding="utf-8")
            except Exception:
                pass

        # Ghi báo cáo kết quả
        report_file = dir_path / "renaming_report.json"
        try:
            report_file.write_text(
                json.dumps(report, ensure_ascii=False, indent=2),
                encoding="utf-8"
            )
        except Exception:
            pass

        return report

    @classmethod
    def get_summary_text(cls, report: Dict[str, Any]) -> str:
        """Tạo chuỗi thông báo kết quả chuẩn hóa định danh mã nguồn."""
        parts = []
        if report.get("directories_renamed", 0) > 0:
            parts.append(f"đổi tên {report['directories_renamed']} thư mục")
        if report.get("files_renamed", 0) > 0:
            parts.append(f"đổi tên {report['files_renamed']} tệp")
        if report.get("classes_renamed", 0) > 0:
            parts.append(f"chuẩn hóa {report['classes_renamed']} lớp")
        if report.get("controls_restored", 0) > 0:
            parts.append(f"khôi phục {report['controls_restored']} controls")
        if report.get("fields_renamed", 0) > 0:
            parts.append(f"{report['fields_renamed']} biến")
        if report.get("methods_renamed", 0) > 0:
            parts.append(f"{report['methods_renamed']} hàm")

        if parts:
            return " (Đã giải mã & chuẩn hóa: " + ", ".join(parts) + ")"
        return ""
