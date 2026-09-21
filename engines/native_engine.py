import os
from pathlib import Path
from typing import Dict, Any, Optional
from engines.base import BaseDecompiler

class NativePEEngine(BaseDecompiler):
    """
    Engine phân tích tệp Native Windows Executable / DLL (C/C++):
    - Trích xuất bảng hàm xuất (Export Table -> exports.h)
    - Trích xuất bảng hàm nhập và thư viện phụ thuộc (Import Table -> imports.txt)
    - Phân tích cấu trúc PE Sections và thông tin kiến trúc máy tính
    """

    def __init__(self):
        super().__init__("Native PE (C/C++) Analyzer")

    def is_available(self) -> bool:
        try:
            import pefile
            return True
        except ImportError:
            return False

    def get_executable_path(self) -> Optional[str]:
        return "pefile (Built-in Python Engine)"

    def decompile(self, input_path: str, output_dir: str, **kwargs) -> Dict[str, Any]:
        out_path = Path(output_dir)
        out_path.mkdir(parents=True, exist_ok=True)

        try:
            import pefile
            pe = pefile.PE(input_path)
        except Exception as e:
            return {
                "success": False,
                "message": f"Không thể phân tích cấu trúc PE: {str(e)}",
            }

        target_name = Path(input_path).stem

        # 1. Trích xuất bảng Export (Exported Functions -> exports.h)
        exports_file = out_path / "exports.h"
        exported_count = 0
        with open(exports_file, "w", encoding="utf-8") as f_exp:
            f_exp.write(f"// =========================================================\n")
            f_exp.write(f"// Bảng hàm Export (C Header) trích xuất từ: {Path(input_path).name}\n")
            f_exp.write(f"// =========================================================\n\n")
            f_exp.write('#ifdef __cplusplus\nextern "C" {\n#endif\n\n')

            if hasattr(pe, "DIRECTORY_ENTRY_EXPORT"):
                for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
                    name = exp.name.decode("utf-8", errors="ignore") if exp.name else f"Ordinal_{exp.ordinal}"
                    f_exp.write(f"// Ordinal: {exp.ordinal} | RVA: 0x{exp.address:08X}\n")
                    f_exp.write(f"__declspec(dllexport) void* {name}();\n\n")
                    exported_count += 1
            else:
                f_exp.write("// File không chứa bảng Export (Không xuất hàm ra ngoài)\n")

            f_exp.write('\n#ifdef __cplusplus\n}\n#endif\n')

        # 2. Trích xuất bảng Import (Import Table -> imports.txt)
        imports_file = out_path / "imports.txt"
        imported_dll_count = 0
        with open(imports_file, "w", encoding="utf-8") as f_imp:
            f_imp.write(f"DANH SÁCH THƯ VIỆN VÀ HÀM NHẬP (IMPORTS) - {Path(input_path).name}\n")
            f_imp.write("=" * 65 + "\n\n")

            if hasattr(pe, "DIRECTORY_ENTRY_IMPORT"):
                for entry in pe.DIRECTORY_ENTRY_IMPORT:
                    dll_name = entry.dll.decode("utf-8", errors="ignore")
                    f_imp.write(f"📦 [{dll_name}]\n")
                    imported_dll_count += 1
                    for imp in entry.imports:
                        func_name = imp.name.decode("utf-8", errors="ignore") if imp.name else f"Ordinal {imp.ordinal}"
                        f_imp.write(f"   ├── {func_name}\n")
                    f_imp.write("\n")
            else:
                f_imp.write("Không tìm thấy bảng Import.\n")

        # 3. Phân tích Header & Sections (pe_summary.txt)
        summary_file = out_path / "pe_summary.txt"
        arch = "x64 (64-bit)" if pe.FILE_HEADER.Machine == 0x8664 else "x86 (32-bit)" if pe.FILE_HEADER.Machine == 0x014c else f"0x{pe.FILE_HEADER.Machine:X}"
        subsystem_val = getattr(pe.OPTIONAL_HEADER, "Subsystem", 0) if hasattr(pe, "OPTIONAL_HEADER") else 0
        subsystem_desc = (
            "Windows GUI (Ứng dụng giao diện đồ họa)" if subsystem_val == 2
            else "Windows Console CUI (Ứng dụng dòng lệnh)" if subsystem_val == 3
            else f"Subsystem code: {subsystem_val}"
        )
        is_exe = Path(input_path).suffix.lower() == ".exe"
        pe_type = "Windows Executable (.exe)" if is_exe else "Dynamic Link Library (.dll)"

        with open(summary_file, "w", encoding="utf-8") as f_sum:
            f_sum.write(f"TỔNG QUAN PHÂN TÍCH TỆP NATIVE - {Path(input_path).name}\n")
            f_sum.write("=" * 65 + "\n")
            f_sum.write(f"- Định dạng: {pe_type}\n")
            f_sum.write(f"- Kiến trúc (Architecture): {arch}\n")
            f_sum.write(f"- Subsystem: {subsystem_desc}\n")
            f_sum.write(f"- Số lượng hàm Export: {exported_count}\n")
            f_sum.write(f"- Số lượng DLL phụ thuộc: {imported_dll_count}\n\n")

            f_sum.write("CÁC PHÂN ĐOẠN BỘ NHỚ (PE SECTIONS):\n")
            f_sum.write(f"{'Tên':<10} {'Virtual Size':<15} {'Raw Size':<15} {'Entropy'}\n")
            f_sum.write("-" * 55 + "\n")
            for section in pe.sections:
                sec_name = section.Name.decode("utf-8", errors="ignore").strip("\x00")
                entropy = section.get_entropy()
                f_sum.write(f"{sec_name:<10} 0x{section.Misc_VirtualSize:<13X} 0x{section.SizeOfRawData:<13X} {entropy:.2f}\n")

        pe.close()

        # 4. Sinh file hợp ngữ disassembly.asm cho EntryPoint và các hàm Export
        disasm_file = out_path / "disassembly.asm"
        has_disasm = False
        try:
            from core.disassembler import NativeDisassembler
            has_disasm = NativeDisassembler.generate_disassembly_file(input_path, disasm_file)
        except Exception:
            pass

        disasm_msg = " + Hợp ngữ x86/x64 (disassembly.asm)" if has_disasm else ""

        return {
            "success": True,
            "output_dir": str(out_path.resolve()),
            "message": (
                f"✅ Phân tích Native PE thành công ({exported_count} exports, "
                f"{imported_dll_count} DLL phụ thuộc){disasm_msg}."
            ),
            "stdout": "",
            "stderr": "",
        }
