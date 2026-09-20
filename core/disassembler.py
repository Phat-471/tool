import struct
from pathlib import Path
from typing import Any, Dict, List, Optional, Tuple


class NativeDisassembler:
    """
    Bộ giải mã Hợp ngữ (x86/x64 Disassembler) thuần Python cho Native PE (C/C++):
    - Đọc mã máy nhị phân tại EntryPoint và các hàm Export
    - Giải mã các opcode phổ biến (x86/x64: PUSH, MOV, SUB, ADD, CALL, JMP, RET, CMP, TEST, XOR, NOP...)
    - Ánh xạ các lệnh gọi API gián tiếp (FF 15 ... / FF 25 ...) sang tên hàm trong Import Table
    - Xuất tệp disassembly.asm phục vụ phân tích logic hàm
    """

    @classmethod
    def disassemble_function(
        cls,
        code: bytes,
        start_rva: int,
        is_64bit: bool = True,
        max_instructions: int = 60,
        import_map: Optional[Dict[int, str]] = None,
    ) -> List[str]:
        """Giải mã một khối mã máy thành danh sách các dòng hợp ngữ."""
        lines: List[str] = []
        offset = 0
        code_len = len(code)
        count = 0
        import_map = import_map or {}

        while offset < code_len and count < max_instructions:
            addr = start_rva + offset
            b = code[offset]
            insn_str = ""
            insn_len = 1

            # ── 1. Một byte đơn giản ──
            if b == 0x90:
                insn_str = "nop"
                insn_len = 1
            elif b == 0xCC:
                insn_str = "int3"
                insn_len = 1
            elif b == 0xC3:
                insn_str = "ret"
                insn_len = 1
            elif b == 0xC2 and offset + 2 < code_len:
                imm16 = struct.unpack_from("<H", code, offset + 1)[0]
                insn_str = f"ret 0x{imm16:X}"
                insn_len = 3
            elif b in (0x50, 0x51, 0x52, 0x53, 0x54, 0x55, 0x56, 0x57):
                regs = ["rax", "rcx", "rdx", "rbx", "rsp", "rbp", "rsi", "rdi"]
                insn_str = f"push {regs[b - 0x50]}"
                insn_len = 1
            elif b in (0x58, 0x59, 0x5A, 0x5B, 0x5C, 0x5D, 0x5E, 0x5F):
                regs = ["rax", "rcx", "rdx", "rbx", "rsp", "rbp", "rsi", "rdi"]
                insn_str = f"pop {regs[b - 0x58]}"
                insn_len = 1

            # ── 2. Call / Jmp Relative 32-bit (E8 / E9) ──
            elif b == 0xE8 and offset + 5 <= code_len:
                rel32 = struct.unpack_from("<i", code, offset + 1)[0]
                target = addr + 5 + rel32
                insn_str = f"call 0x{target:08X}"
                insn_len = 5
            elif b == 0xE9 and offset + 5 <= code_len:
                rel32 = struct.unpack_from("<i", code, offset + 1)[0]
                target = addr + 5 + rel32
                insn_str = f"jmp 0x{target:08X}"
                insn_len = 5
            elif b == 0xEB and offset + 2 <= code_len:
                rel8 = struct.unpack_from("<b", code, offset + 1)[0]
                target = addr + 2 + rel8
                insn_str = f"jmp 0x{target:08X}"
                insn_len = 2

            # ── 3. Conditional Jumps (74 JZ, 75 JNZ, etc.) ──
            elif 0x70 <= b <= 0x7F and offset + 2 <= code_len:
                jumps = [
                    "jo", "jno", "jb", "jnb", "jz", "jnz", "jbe", "jnbe",
                    "js", "jns", "jp", "jnp", "jl", "jnl", "jle", "jnle"
                ]
                jname = jumps[b - 0x70]
                rel8 = struct.unpack_from("<b", code, offset + 1)[0]
                target = addr + 2 + rel8
                insn_str = f"{jname} 0x{target:08X}"
                insn_len = 2

            # ── 4. Call / Jmp qua IAT (FF 15 / FF 25 RIP-relative) ──
            elif b == 0xFF and offset + 6 <= code_len:
                modrm = code[offset + 1]
                if modrm in (0x15, 0x25):  # call / jmp [rip + disp32]
                    disp32 = struct.unpack_from("<i", code, offset + 2)[0]
                    target_iat = addr + 6 + disp32
                    imp_name = import_map.get(target_iat, "")
                    target_label = f"[{imp_name}]" if imp_name else f"[0x{target_iat:08X}]"
                    op_name = "call" if modrm == 0x15 else "jmp"
                    insn_str = f"{op_name} qword ptr {target_label}"
                    insn_len = 6
                else:
                    insn_str = f"ff {modrm:02x}"
                    insn_len = 2

            # ── 5. REX.W prefix (48) trong x64 ──
            elif b == 0x48 and offset + 2 < code_len:
                op2 = code[offset + 1]
                if op2 == 0x83 and offset + 4 <= code_len:
                    modrm = code[offset + 2]
                    imm8 = code[offset + 3]
                    if modrm == 0xEC:
                        insn_str = f"sub rsp, 0x{imm8:02X}"
                        insn_len = 4
                    elif modrm == 0xC4:
                        insn_str = f"add rsp, 0x{imm8:02X}"
                        insn_len = 4
                    else:
                        insn_str = f"rex.w 83 {modrm:02x} {imm8:02x}"
                        insn_len = 4
                elif op2 == 0x89 and offset + 3 <= code_len:
                    modrm = code[offset + 2]
                    if modrm == 0xE5:
                        insn_str = "mov rbp, rsp"
                        insn_len = 3
                    else:
                        insn_str = f"mov r/m64, reg64 ({modrm:02X})"
                        insn_len = 3
                elif op2 == 0x31 and offset + 3 <= code_len:
                    modrm = code[offset + 2]
                    if modrm == 0xC0:
                        insn_str = "xor rax, rax"
                        insn_len = 3
                    else:
                        insn_str = f"xor r/m64, reg64 ({modrm:02X})"
                        insn_len = 3
                elif op2 == 0x8B and offset + 3 <= code_len:
                    modrm = code[offset + 2]
                    insn_str = f"mov reg64, r/m64 ({modrm:02X})"
                    insn_len = 3
                else:
                    insn_str = f"rex.w {op2:02x}"
                    insn_len = 2

            # ── 6. XOR eax, eax (31 C0 / 33 C0) ──
            elif b in (0x31, 0x33) and offset + 2 <= code_len and code[offset + 1] == 0xC0:
                insn_str = "xor eax, eax"
                insn_len = 2

            # ── 7. Fallback hiển thị Hex thô ──
            else:
                insn_str = f"db 0x{b:02X}"
                insn_len = 1

            raw_hex = " ".join(f"{code[offset + i]:02X}" for i in range(insn_len))
            lines.append(f"    {addr:08X}:  {raw_hex:<16}  {insn_str}")
            offset += insn_len
            count += 1

            # Dừng nếu gặp lệnh RET hoặc kết thúc hàm
            if insn_str.startswith("ret"):
                break

        return lines

    @classmethod
    def generate_disassembly_file(cls, pe_file_path: str, output_file: Path) -> bool:
        """Đọc file PE và sinh tệp disassembly.asm cho EntryPoint và Export Functions."""
        try:
            import pefile
            pe = pefile.PE(pe_file_path)
        except Exception:
            return False

        try:
            is_64bit = (pe.FILE_HEADER.Machine == 0x8664)
            image_base = pe.OPTIONAL_HEADER.ImageBase

            # Tạo bảng tra cứu Import Address Table (IAT)
            import_map: Dict[int, str] = {}
            if hasattr(pe, "DIRECTORY_ENTRY_IMPORT"):
                for entry in pe.DIRECTORY_ENTRY_IMPORT:
                    for imp in entry.imports:
                        if imp.address:
                            name = imp.name.decode("utf-8", errors="ignore") if imp.name else f"Ordinal_{imp.ordinal}"
                            import_map[imp.address] = name

            asm_lines: List[str] = [
                "; " + "=" * 76,
                f"; DISASSEMBLY LISTING - {Path(pe_file_path).name}",
                f"; Architecture : {'x64 (64-bit)' if is_64bit else 'x86 (32-bit)'}",
                f"; ImageBase    : 0x{image_base:016X}",
                "; " + "=" * 76,
                "",
            ]

            # 1. Entry Point
            entry_rva = pe.OPTIONAL_HEADER.AddressOfEntryPoint
            if entry_rva > 0:
                asm_lines.append(f"; --- [Entry Point: 0x{image_base + entry_rva:08X}] ---")
                asm_lines.append(f"EntryPoint:")
                code_data = pe.get_data(entry_rva, 128)
                if code_data:
                    insns = cls.disassemble_function(
                        code_data, image_base + entry_rva, is_64bit=is_64bit, import_map=import_map
                    )
                    asm_lines.extend(insns)
                asm_lines.append("")

            # 2. Export Functions
            if hasattr(pe, "DIRECTORY_ENTRY_EXPORT"):
                for exp in pe.DIRECTORY_ENTRY_EXPORT.symbols:
                    name = exp.name.decode("utf-8", errors="ignore") if exp.name else f"Ordinal_{exp.ordinal}"
                    func_rva = exp.address
                    func_addr = image_base + func_rva
                    asm_lines.append(f"; --- [Export: {name} | Ordinal: {exp.ordinal} | RVA: 0x{func_rva:08X}] ---")
                    asm_lines.append(f"{name}:")
                    code_data = pe.get_data(func_rva, 128)
                    if code_data:
                        insns = cls.disassemble_function(
                            code_data, func_addr, is_64bit=is_64bit, import_map=import_map
                        )
                        asm_lines.extend(insns)
                    asm_lines.append("")

            output_file.write_text("\n".join(asm_lines), encoding="utf-8")
            pe.close()
            return True
        except Exception:
            try:
                pe.close()
            except Exception:
                pass
            return False
