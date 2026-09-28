import ctypes
import os
import re
from ctypes import wintypes
from pathlib import Path
from typing import Any, Dict, List, Optional
import psutil
import pefile

# Windows Constants
PROCESS_VM_READ = 0x0010
PROCESS_QUERY_INFORMATION = 0x0400
PROCESS_QUERY_LIMITED_INFORMATION = 0x1000

MEM_COMMIT = 0x1000
PAGE_NOACCESS = 0x01
PAGE_GUARD = 0x100

class MEMORY_BASIC_INFORMATION64(ctypes.Structure):
    _fields_ = [
        ("BaseAddress", ctypes.c_uint64),
        ("AllocationBase", ctypes.c_uint64),
        ("AllocationProtect", wintypes.DWORD),
        ("__alignment1", wintypes.DWORD),
        ("RegionSize", ctypes.c_uint64),
        ("State", wintypes.DWORD),
        ("Protect", wintypes.DWORD),
        ("Type", wintypes.DWORD),
        ("__alignment2", wintypes.DWORD),
    ]

# Setup Windows API functions with explicit argtypes and restype
kernel32 = ctypes.windll.kernel32

kernel32.OpenProcess.argtypes = [wintypes.DWORD, wintypes.BOOL, wintypes.DWORD]
kernel32.OpenProcess.restype = wintypes.HANDLE

kernel32.CloseHandle.argtypes = [wintypes.HANDLE]
kernel32.CloseHandle.restype = wintypes.BOOL

kernel32.ReadProcessMemory.argtypes = [
    wintypes.HANDLE,
    ctypes.c_void_p,
    ctypes.c_void_p,
    ctypes.c_size_t,
    ctypes.POINTER(ctypes.c_size_t)
]
kernel32.ReadProcessMemory.restype = wintypes.BOOL

kernel32.VirtualQueryEx.argtypes = [
    wintypes.HANDLE,
    ctypes.c_void_p,
    ctypes.POINTER(MEMORY_BASIC_INFORMATION64),
    ctypes.c_size_t
]
kernel32.VirtualQueryEx.restype = ctypes.c_size_t


class ProcessDumper:
    """
    Module trích xuất (Dump) DLL .NET trực tiếp từ bộ nhớ RAM của tiến trình đang chạy.
    Đặc biệt tối ưu cho các phần mềm CAD/BIM như AutoCAD (acad.exe), Revit (revit.exe),
    nơi các module bảo vệ bằng ConfuserEx Anti-Tamper / JIT Decryption đã được tự động
    giải mã 100% ruột hàm vào bộ nhớ RAM.
    """

    CAD_PROCESS_NAMES = {
        "acad.exe": "AutoCAD",
        "revit.exe": "Autodesk Revit",
        "gcad.exe": "GstarCAD",
        "zwcad.exe": "ZWCAD",
        "civil3d.exe": "Autodesk Civil 3D",
        "inventor.exe": "Autodesk Inventor",
        "roamer.exe": "Autodesk Navisworks",
        "devenv.exe": "Visual Studio",
    }

    @classmethod
    def list_running_processes(cls, filter_cad_first: bool = True) -> List[Dict[str, Any]]:
        """
        Liệt kê các tiến trình đang chạy trên hệ thống.
        Ưu tiên hiển thị AutoCAD, Revit, CAD/BIM và các tiến trình .NET lên đầu danh sách.
        """
        cad_procs = []
        other_procs = []

        for p in psutil.process_iter(['pid', 'name', 'exe', 'memory_info']):
            try:
                name = p.info['name'] or ""
                pid = p.info['pid']
                exe = p.info['exe'] or ""
                mem_mb = (p.info['memory_info'].rss / (1024 * 1024)) if p.info.get('memory_info') else 0.0

                name_lower = name.lower()
                is_cad = name_lower in cls.CAD_PROCESS_NAMES or any(k in name_lower for k in ["acad", "revit", "cad", "bim", "kata"])
                
                has_kata = False
                loaded_keywords = []
                if is_cad or "python" in name_lower:
                    try:
                        for m in p.memory_maps(grouped=True):
                            m_path = (m.path or "").lower()
                            if "kata" in m_path:
                                has_kata = True
                                loaded_keywords.append("kata")
                                break
                    except Exception:
                        pass

                if has_kata:
                    cad_desc = "🌟 AutoCAD (Đang nạp Kata Pro!)" if "acad" in name_lower else "🌟 Tiến trình đang nạp Kata Pro"
                elif is_cad:
                    cad_desc = cls.CAD_PROCESS_NAMES.get(name_lower, "Tiến trình CAD/BIM")
                else:
                    cad_desc = "Tiến trình hệ thống"

                item = {
                    "pid": pid,
                    "name": name,
                    "desc": cad_desc,
                    "exe": exe,
                    "mem_mb": round(mem_mb, 1),
                    "is_cad": is_cad,
                    "has_kata": has_kata,
                    "keywords": " ".join(loaded_keywords)
                }

                if is_cad:
                    cad_procs.append(item)
                else:
                    other_procs.append(item)
            except (psutil.NoSuchProcess, psutil.AccessDenied):
                continue

        # Sắp xếp: Ưu tiên tiến trình đang nạp Kata Pro lên đầu tuyệt đối, sau đó đến CAD khác, rồi đến RAM
        cad_procs.sort(key=lambda x: (x["has_kata"], x["mem_mb"]), reverse=True)
        other_procs.sort(key=lambda x: x["mem_mb"], reverse=True)

        if filter_cad_first:
            return cad_procs + other_procs
        return cad_procs + other_procs

    @classmethod
    def is_dotnet_pe(cls, pe: pefile.PE) -> bool:
        """Kiểm tra xem PE có chứa CLR Header (.NET) hay không."""
        try:
            if hasattr(pe, 'OPTIONAL_HEADER') and hasattr(pe.OPTIONAL_HEADER, 'DATA_DIRECTORY'):
                if len(pe.OPTIONAL_HEADER.DATA_DIRECTORY) > 14:
                    clr_dir = pe.OPTIONAL_HEADER.DATA_DIRECTORY[14]
                    return clr_dir.VirtualAddress > 0 and clr_dir.Size > 0
        except Exception:
            pass
        return False

    @classmethod
    def extract_assembly_name(cls, raw_data: bytes) -> Optional[str]:
        """Trích xuất tên Assembly hoặc Module từ bảng metadata .NET nếu có."""
        try:
            import dnfile
            pe = dnfile.dnPE(data=raw_data)
            if hasattr(pe, 'net') and pe.net and hasattr(pe.net, 'mdtables') and pe.net.mdtables:
                # Ưu tiên lấy Module Name (thường có sẵn đuôi .dll như Kata_pro64_Cad2013.dll)
                if hasattr(pe.net.mdtables, 'Module') and pe.net.mdtables.Module:
                    mod_name = str(pe.net.mdtables.Module[0].Name)
                    if mod_name and mod_name.strip():
                        return mod_name.strip()
                # Sau đó lấy Assembly Name
                if hasattr(pe.net.mdtables, 'Assembly') and pe.net.mdtables.Assembly:
                    asm_name = str(pe.net.mdtables.Assembly[0].Name)
                    if asm_name and asm_name.strip():
                        return asm_name.strip()
        except Exception:
            pass

        # Fallback bằng regex nếu dnfile gặp lỗi do metadata bị làm rối
        try:
            match = re.search(rb'(?:Kata_[A-Za-z0-9_]+|[A-Za-z0-9_]{3,40}\.(?:dll|exe))', raw_data)
            if match:
                return match.group(0).decode('utf-8', errors='ignore')
        except Exception:
            pass
        return None

    @classmethod
    def get_process_modules(cls, pid: int) -> List[Dict[str, Any]]:
        """
        Lấy danh sách các module DLL đang được nạp trong tiến trình.
        Đặc biệt gắn cờ các module .NET và module liên quan đến AutoCAD/Kata.
        """
        modules = []
        try:
            p = psutil.Process(pid)
            mem_maps = p.memory_maps()
            seen_paths = set()

            for m in mem_maps:
                path = m.path
                if not path or path in seen_paths:
                    continue
                seen_paths.add(path)

                fname = Path(path).name
                ext = Path(path).suffix.lower()
                if ext not in [".dll", ".exe", ".arx", ".dbx", ".crx"]:
                    continue

                size_kb = round(m.rss / 1024, 1) if hasattr(m, 'rss') else 0
                is_kata = "kata" in fname.lower()
                is_cad_module = any(k in fname.lower() for k in ["acad", "autodesk", "acmgd", "acdbmgd", "revit"])

                modules.append({
                    "name": fname,
                    "path": path,
                    "size_kb": size_kb,
                    "is_target": is_kata,
                    "is_cad_module": is_cad_module,
                    "base_addr": None
                })

            # Sắp xếp ưu tiên các module liên quan tới Kata lên đầu
            modules.sort(key=lambda x: (x["is_target"], x["is_cad_module"], x["size_kb"]), reverse=True)
        except Exception:
            pass

        return modules

    @classmethod
    def rebuild_pe_from_memory(cls, h_process: int, base_address: int) -> Optional[bytes]:
        """
        Đọc PE Image từ bộ nhớ tiến trình và tái cấu trúc (unmap) từ Virtual Layout
        về Raw On-Disk Layout chuẩn để các công cụ dịch ngược (ILSpy, dnSpy, de4dot)
        đọc được trực tiếp không bị lỗi định dạng.
        """
        try:
            # 1. Đọc PE Header (0x1000 byte đầu tiên)
            header_buf = (ctypes.c_char * 0x1000)()
            bytes_read = ctypes.c_size_t(0)
            ok = kernel32.ReadProcessMemory(
                h_process,
                ctypes.c_void_p(base_address),
                header_buf,
                0x1000,
                ctypes.byref(bytes_read)
            )
            if not ok or bytes_read.value < 0x200:
                return None

            header_data = bytes(header_buf)
            if not header_data.startswith(b"MZ"):
                return None

            pe = pefile.PE(data=header_data, fast_load=True)
            if not hasattr(pe, "sections") or not pe.sections:
                return None

            # 2. Tính toán kích thước file đĩa chuẩn từ các section
            size_of_headers = pe.OPTIONAL_HEADER.SizeOfHeaders
            max_raw_offset = size_of_headers
            for s in pe.sections:
                end_offset = s.PointerToRawData + s.SizeOfRawData
                if end_offset > max_raw_offset:
                    max_raw_offset = end_offset

            if max_raw_offset <= 0 or max_raw_offset > 300 * 1024 * 1024:
                return None

            raw_buffer = bytearray(max_raw_offset)
            # Copy Header
            raw_buffer[:min(len(header_data), size_of_headers)] = header_data[:size_of_headers]

            # 3. Đọc từng Section từ RAM và ghi vào đúng vị trí PointerToRawData
            for s in pe.sections:
                sec_va = base_address + s.VirtualAddress
                to_read = min(s.Misc_VirtualSize, s.SizeOfRawData)
                if to_read <= 0:
                    continue

                sec_buf = (ctypes.c_char * to_read)()
                sec_read = ctypes.c_size_t(0)
                sec_ok = kernel32.ReadProcessMemory(
                    h_process,
                    ctypes.c_void_p(sec_va),
                    sec_buf,
                    to_read,
                    ctypes.byref(sec_read)
                )

                if sec_ok and sec_read.value > 0:
                    dest_start = s.PointerToRawData
                    dest_end = dest_start + sec_read.value
                    if dest_end <= len(raw_buffer):
                        raw_buffer[dest_start:dest_end] = bytes(sec_buf)[:sec_read.value]

            return bytes(raw_buffer)

        except Exception:
            return None

    @classmethod
    def scan_and_dump_all(
        cls,
        pid: int,
        output_dir: str,
        keyword: str = "",
        only_dotnet: bool = True
    ) -> Dict[str, Any]:
        """
        Quét toàn bộ không gian bộ nhớ của tiến trình mục tiêu (PID), tìm tất cả
        các .NET Assembly (bao gồm cả module DLL thông thường và module nạp động qua RAM),
        tái cấu trúc thành file PE hợp lệ và lưu vào thư mục output_dir.
        """
        out_path = Path(output_dir)
        out_path.mkdir(parents=True, exist_ok=True)

        report = {
            "pid": pid,
            "total_scanned_regions": 0,
            "dumped_files": [],
            "errors": [],
            "output_dir": str(out_path.resolve())
        }

        h_process = kernel32.OpenProcess(PROCESS_VM_READ | PROCESS_QUERY_INFORMATION, False, pid)
        if not h_process:
            h_process = kernel32.OpenProcess(PROCESS_QUERY_LIMITED_INFORMATION, False, pid)

        if not h_process:
            report["errors"].append(f"Không thể mở tiến trình PID {pid} (Cần quyền Administrator).")
            return report

        try:
            found_hashes = set()
            dump_counter = 1

            # ── PASS 1: Quét siêu tốc qua Memory Maps của tiến trình (0.05 giây) ──
            try:
                p_obj = psutil.Process(pid)
                maps = p_obj.memory_maps(grouped=False)
                by_path = {}
                for m in maps:
                    if m.path and m.path.lower().endswith(('.dll', '.exe', '.arx', '.dbx')):
                        m_path_lower = m.path.lower()
                        m_name_lower = Path(m.path).name.lower()
                        if (not keyword) or (keyword.lower() in m_path_lower) or (keyword.lower() in m_name_lower):
                            if m.path not in by_path:
                                by_path[m.path] = []
                            by_path[m.path].append(int(m.addr, 16))

                for path_str, addrs in by_path.items():
                    base_addr = min(addrs)
                    pe_bytes = cls.rebuild_pe_from_memory(h_process, base_addr)
                    if not pe_bytes:
                        continue

                    try:
                        pe_obj = pefile.PE(data=pe_bytes, fast_load=True)
                        is_dotnet = cls.is_dotnet_pe(pe_obj)
                        if only_dotnet and not is_dotnet:
                            continue

                        assembly_name = cls.extract_assembly_name(pe_bytes)
                        if not assembly_name:
                            assembly_name = Path(path_str).name

                        if not assembly_name.lower().endswith((".dll", ".exe")):
                            assembly_name += ".dll"

                        file_sig = (len(pe_bytes), pe_bytes[:256])
                        if file_sig in found_hashes:
                            continue
                        found_hashes.add(file_sig)

                        target_file = out_path / assembly_name
                        target_file.write_bytes(pe_bytes)

                        report["dumped_files"].append({
                            "name": assembly_name,
                            "path": str(target_file.resolve()),
                            "base_address": hex(base_addr),
                            "size_bytes": len(pe_bytes),
                            "is_dotnet": is_dotnet,
                            "origin_path": path_str
                        })
                    except Exception:
                        pass

                # Nếu Pass 1 đã trích xuất được module mục tiêu, trả về ngay lập tức không cần chờ quét 128TB RAM!
                if report["dumped_files"] and keyword:
                    return report

            except Exception:
                pass

            # ── PASS 2: Quét sâu toàn bộ Virtual Memory (Fallback cho dynamic/unmapped code) ──
            current_address = 0x10000
            max_address = 0x7FFFFFFEFFFF  # Vùng nhớ User-mode chuẩn
            mbi = MEMORY_BASIC_INFORMATION64()

            while current_address < max_address:
                report["total_scanned_regions"] += 1
                query_res = kernel32.VirtualQueryEx(
                    h_process,
                    ctypes.c_void_p(current_address),
                    ctypes.byref(mbi),
                    ctypes.sizeof(mbi)
                )

                if not query_res or mbi.RegionSize == 0:
                    current_address += 0x10000
                    continue

                is_committed = (mbi.State == MEM_COMMIT)
                is_accessible = not (mbi.Protect & (PAGE_NOACCESS | PAGE_GUARD))

                if is_committed and is_accessible and mbi.RegionSize >= 0x1000:
                    sig_buf = (ctypes.c_char * 2)()
                    bytes_read = ctypes.c_size_t(0)
                    if kernel32.ReadProcessMemory(
                        h_process,
                        ctypes.c_void_p(mbi.BaseAddress),
                        sig_buf,
                        2,
                        ctypes.byref(bytes_read)
                    ) and bytes(sig_buf) == b"MZ":
                        pe_bytes = cls.rebuild_pe_from_memory(h_process, mbi.BaseAddress)
                        if pe_bytes:
                            try:
                                pe_obj = pefile.PE(data=pe_bytes, fast_load=True)
                                is_dotnet = cls.is_dotnet_pe(pe_obj)

                                if (not only_dotnet) or is_dotnet:
                                    assembly_name = cls.extract_assembly_name(pe_bytes)
                                    if not assembly_name:
                                        assembly_name = f"DumpedModule_{dump_counter:03d}.dll"
                                        dump_counter += 1

                                    if not assembly_name.lower().endswith((".dll", ".exe")):
                                        assembly_name += ".dll"

                                    if keyword and keyword.lower() not in assembly_name.lower():
                                        current_address += mbi.RegionSize
                                        continue

                                    file_sig = (len(pe_bytes), pe_bytes[:256])
                                    if file_sig in found_hashes:
                                        current_address += mbi.RegionSize
                                        continue
                                    found_hashes.add(file_sig)

                                    target_file = out_path / assembly_name
                                    target_file.write_bytes(pe_bytes)

                                    report["dumped_files"].append({
                                        "name": assembly_name,
                                        "path": str(target_file.resolve()),
                                        "base_address": hex(mbi.BaseAddress),
                                        "size_bytes": len(pe_bytes),
                                        "is_dotnet": is_dotnet
                                    })
                            except Exception:
                                pass

                current_address = mbi.BaseAddress + mbi.RegionSize

        finally:
            kernel32.CloseHandle(h_process)

        return report
