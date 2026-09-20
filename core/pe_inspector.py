import math
import os
import struct
from pathlib import Path
from typing import Any, Dict, List, Optional, Tuple


class PEInspector:
    """
    Module phân tích cấu trúc PE (Portable Executable) & .NET Metadata chuyên sâu:
    - Tính toán Shannon Entropy cho từng Section (phát hiện vùng nén / mã hóa > 7.0)
    - Trích xuất Section Headers (.text, .rsrc, .reloc, .cmeah, etc.)
    - Nhận diện .NET CLR Header (COR20 Header)
    - Nhận diện tài nguyên nhúng (Manifest Resources, Costura.Fody, Confuser resources)
    - Đánh giá chỉ số rủi ro bảo vệ (Protection Score / Packed Indicator)
    """

    @staticmethod
    def calculate_entropy(data: bytes) -> float:
        """Tính toán Shannon Entropy của chuỗi byte (giá trị từ 0.0 đến 8.0)."""
        if not data:
            return 0.0
        entropy = 0.0
        length = len(data)
        byte_counts = [0] * 256
        for b in data:
            byte_counts[b] += 1
        for count in byte_counts:
            if count > 0:
                p = count / length
                entropy -= p * math.log2(p)
        return round(entropy, 3)

    @classmethod
    def analyze_pe(cls, file_path: str) -> Dict[str, Any]:
        """Phân tích toàn diện cấu trúc file PE."""
        results: Dict[str, Any] = {
            "is_pe": False,
            "is_dotnet": False,
            "sections": [],
            "overall_entropy": 0.0,
            "has_high_entropy": False,
            "dotnet_header": {},
            "warnings": [],
        }

        p = Path(file_path)
        if not p.is_file():
            results["warnings"].append(f"Tệp không tồn tại: {file_path}")
            return results

        try:
            with open(file_path, "rb") as f:
                data = f.read()
        except Exception as exc:
            results["warnings"].append(f"Không thể đọc tệp: {exc}")
            return results

        if len(data) < 64 or data[:2] != b"MZ":
            return results

        results["is_pe"] = True
        results["overall_entropy"] = cls.calculate_entropy(data)

        # Đọc e_lfanew
        pe_offset = struct.unpack_from("<I", data, 0x3C)[0]
        if pe_offset + 4 > len(data) or data[pe_offset:pe_offset + 4] != b"PE\x00\x00":
            results["warnings"].append("Chữ ký PE không hợp lệ.")
            return results

        # COFF Header (20 bytes sau "PE\0\0")
        coff_offset = pe_offset + 4
        machine, num_sections, time_date_stamp, sym_ptr, num_sym, opt_hdr_size, characteristics = (
            struct.unpack_from("<HHIIIHH", data, coff_offset)
        )

        results["machine"] = "x64 (AMD64)" if machine == 0x8664 else ("x86 (i386)" if machine == 0x014c else hex(machine))
        results["num_sections"] = num_sections

        # Optional Header
        opt_hdr_offset = coff_offset + 20
        magic = struct.unpack_from("<H", data, opt_hdr_offset)[0]
        is_64bit = (magic == 0x020B)
        results["is_64bit"] = is_64bit

        # Data Directories offset
        # PE32: 96 bytes từ opt_hdr_offset; PE32+: 112 bytes
        rva_num_offset = opt_hdr_offset + (108 if is_64bit else 92)
        num_rva = struct.unpack_from("<I", data, rva_num_offset)[0] if rva_num_offset + 4 <= len(data) else 0

        # Directory 14: CLR Runtime Header (index 14)
        data_dirs_offset = opt_hdr_offset + (112 if is_64bit else 96)
        clr_dir_offset = data_dirs_offset + (14 * 8)
        if clr_dir_offset + 8 <= len(data):
            clr_rva, clr_size = struct.unpack_from("<II", data, clr_dir_offset)
            if clr_rva > 0 and clr_size > 0:
                results["is_dotnet"] = True
                results["dotnet_header"] = {
                    "clr_rva": hex(clr_rva),
                    "clr_size": clr_size,
                }

        # Đọc Section Headers
        sections_offset = opt_hdr_offset + opt_hdr_size
        sections = []
        for i in range(num_sections):
            sec_hdr_pos = sections_offset + (i * 40)
            if sec_hdr_pos + 40 > len(data):
                break

            sec_name_raw = data[sec_hdr_pos:sec_hdr_pos + 8]
            sec_name = sec_name_raw.split(b"\x00")[0].decode("ascii", errors="replace")

            vsize, vaddr, raw_size, raw_ptr = struct.unpack_from(
                "<IIII", data, sec_hdr_pos + 8
            )

            # Lấy data section để tính entropy
            sec_data = data[raw_ptr:raw_ptr + raw_size] if raw_ptr + raw_size <= len(data) else b""
            sec_entropy = cls.calculate_entropy(sec_data) if sec_data else 0.0

            is_packed = sec_entropy >= 7.0
            if is_packed:
                results["has_high_entropy"] = True

            sections.append({
                "name": sec_name,
                "virtual_size": vsize,
                "virtual_address": hex(vaddr),
                "raw_size": raw_size,
                "entropy": sec_entropy,
                "is_packed": is_packed,
                "status": "Mã hóa / Nén (Packed)" if is_packed else "Bình thường",
            })

        results["sections"] = sections
        return results
