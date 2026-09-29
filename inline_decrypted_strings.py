import os
import re
import json
import sys
from pathlib import Path
from typing import Dict, Any, Optional

def csharp_escape(s: str) -> str:
    """Escape string C# để thay thế an toàn vào mã nguồn."""
    s = s.replace('\\', '\\\\')
    s = s.replace('"', '\\"')
    s = s.replace('\r', '\\r')
    s = s.replace('\n', '\\n')
    s = s.replace('\t', '\\t')
    return f'"{s}"'

def inline_strings(target_folder: str, strings_path: Optional[str] = None, keys_path: Optional[str] = None) -> Dict[str, Any]:
    """
    Quét toàn bộ tệp C# trong target_folder và thay thế tất cả các lời gọi
    b8ZYB8DbaTOhwfvx6YUN.QqFDbr6RL7F(...) thành chuỗi string literal rõ ràng.
    """
    target_path = Path(target_folder)
    if not target_path.exists():
        return {"success": False, "message": f"Thư mục không tồn tại: {target_folder}"}

    # Tìm file all_decrypted_strings.json
    if not strings_path or not Path(strings_path).exists():
        candidates = [
            Path("dumps/acad_13008/all_decrypted_strings.json"),
            Path("output/all_decrypted_strings.json")
        ]
        for c in candidates:
            if c.exists():
                strings_path = str(c)
                break

    # Tìm file module_fields_key.json
    if not keys_path or not Path(keys_path).exists():
        candidates = [
            Path("dumps/acad_13008/module_fields_key.json"),
            Path("output/module_fields_key.json")
        ]
        for c in candidates:
            if c.exists():
                keys_path = str(c)
                break

    if not strings_path or not Path(strings_path).exists():
        return {"success": False, "message": "Không tìm thấy all_decrypted_strings.json"}
    if not keys_path or not Path(keys_path).exists():
        return {"success": False, "message": "Không tìm thấy module_fields_key.json"}

    with open(strings_path, "r", encoding="utf-8") as f:
        strings = json.load(f)
    with open(keys_path, "r", encoding="utf-8") as f:
        keys = json.load(f)

    # Regex nhận diện lời gọi giải mã chuỗi
    pattern_xor = re.compile(
        r'b8ZYB8DbaTOhwfvx6YUN\.QqFDbr6RL7F\(\s*(0x[0-9a-fA-F]+|\d+)\s*\^\s*_003CModule_003E[^\.]*\.[^\.]*\.(m_[0-9a-fA-F]+)\s*\)'
    )
    pattern_direct = re.compile(
        r'b8ZYB8DbaTOhwfvx6YUN\.QqFDbr6RL7F\(\s*(0x[0-9a-fA-F]+|\d+)\s*\)'
    )

    replaced_count = 0
    modified_files = []

    for cs_file in target_path.rglob("*.cs"):
        try:
            content = cs_file.read_text(encoding="utf-8", errors="replace")
        except Exception:
            continue

        orig_content = content
        file_replaced = 0

        def replacer_xor(m):
            nonlocal replaced_count, file_replaced
            raw_val = m.group(1)
            field_name = m.group(2)
            val = int(raw_val, 16) if raw_val.startswith("0x") else int(raw_val)
            key_val = keys.get(field_name, 0)
            offset = val ^ key_val
            resolved = strings.get(str(offset))
            if resolved is not None:
                replaced_count += 1
                file_replaced += 1
                return csharp_escape(resolved)
            return m.group(0)

        def replacer_direct(m):
            nonlocal replaced_count, file_replaced
            raw_val = m.group(1)
            offset = int(raw_val, 16) if raw_val.startswith("0x") else int(raw_val)
            resolved = strings.get(str(offset))
            if resolved is not None:
                replaced_count += 1
                file_replaced += 1
                return csharp_escape(resolved)
            return m.group(0)

        content = pattern_xor.sub(replacer_xor, content)
        content = pattern_direct.sub(replacer_direct, content)

        if content != orig_content:
            cs_file.write_text(content, encoding="utf-8")
            modified_files.append({"file": cs_file.name, "replaced": file_replaced})

    return {
        "success": True,
        "replaced_count": replaced_count,
        "modified_files": len(modified_files),
        "details": modified_files
    }

if __name__ == "__main__":
    target = sys.argv[1] if len(sys.argv) > 1 else r"output/Kata_pro64_Cad2013_clean_source"
    print(f"🔧 Đang giải mã và thay thế chuỗi trong: {target}...")
    res = inline_strings(target)
    if res.get("success"):
        print(f"✅ Hoàn tất! Đã thay thế {res['replaced_count']} chuỗi trong {res['modified_files']} tệp C#.")
        for item in res.get("details", [])[:10]:
            print(f"  - {item['file']}: {item['replaced']} chuỗi")
    else:
        print(f"❌ Thất bại: {res.get('message')}")
