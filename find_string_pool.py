import ctypes
from ctypes import wintypes
import re

PROCESS_VM_READ = 0x0010
PROCESS_QUERY_INFORMATION = 0x0400

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

kernel32 = ctypes.windll.kernel32
kernel32.OpenProcess.argtypes = [wintypes.DWORD, wintypes.BOOL, wintypes.DWORD]
kernel32.OpenProcess.restype = wintypes.HANDLE
kernel32.CloseHandle.argtypes = [wintypes.HANDLE]
kernel32.CloseHandle.restype = wintypes.BOOL
kernel32.ReadProcessMemory.argtypes = [wintypes.HANDLE, ctypes.c_void_p, ctypes.c_void_p, ctypes.c_size_t, ctypes.POINTER(ctypes.c_size_t)]
kernel32.ReadProcessMemory.restype = wintypes.BOOL
kernel32.VirtualQueryEx.argtypes = [wintypes.HANDLE, ctypes.c_void_p, ctypes.POINTER(MEMORY_BASIC_INFORMATION64), ctypes.c_size_t]
kernel32.VirtualQueryEx.restype = ctypes.c_size_t

PID = 13008
MEM_COMMIT = 0x1000
PAGE_READWRITE = 0x04
PAGE_EXECUTE_READWRITE = 0x40

h_process = kernel32.OpenProcess(PROCESS_VM_READ | PROCESS_QUERY_INFORMATION, False, PID)
if not h_process:
    print(f"Cannot open PID {PID}")
    exit(1)

address = 0
mbi = MEMORY_BASIC_INFORMATION64()

candidate_regions = []

while kernel32.VirtualQueryEx(h_process, ctypes.c_void_p(address), ctypes.byref(mbi), ctypes.sizeof(mbi)):
    # Look for committed readable writable regions between 300KB and 20MB
    if mbi.State == MEM_COMMIT and (mbi.Protect in [PAGE_READWRITE, PAGE_EXECUTE_READWRITE, 0x02]):
        size = mbi.RegionSize
        if 300 * 1024 <= size <= 20 * 1024 * 1024:
            buf = (ctypes.c_char * size)()
            bytes_read = ctypes.c_size_t(0)
            if kernel32.ReadProcessMemory(h_process, ctypes.c_void_p(mbi.BaseAddress), buf, size, ctypes.byref(bytes_read)):
                data = bytes(buf)[:bytes_read.value]
                # Check if it has multiple strings like "katapro", "SecurityV2", "legacy-serial", "entitlement"
                score = 0
                for pattern in [b"k\x00a\x00t\x00a\x00p\x00r\x00o\x00", 
                                b"S\x00e\x00c\x00u\x00r\x00i\x00t\x00y\x00V\x002\x00",
                                b"l\x00e\x00g\x00a\x00c\x00y\x00-\x00s\x00e\x00r\x00i\x00a\x00l\x00",
                                b"e\x00n\x00t\x00i\x00t\x00l\x00e\x00m\x00e\x00n\x00t\x00",
                                b"u\x00s\x00a\x00g\x00e\x00-\x00q\x00u\x00e\x00u\x00e\x00",
                                b"d\x00e\x00v\x00i\x00c\x00e\x00-\x00k\x00e\x00y\x00"]:
                    if pattern in data:
                        score += 1
                
                if score >= 3:
                    print(f"FOUND high-scoring region at 0x{mbi.BaseAddress:X}, size={size}, score={score}")
                    candidate_regions.append((mbi.BaseAddress, data))

    address = mbi.BaseAddress + mbi.RegionSize
    if address > 0x7FFFFFFF0000:
        break

kernel32.CloseHandle(h_process)

print(f"Total matching regions: {len(candidate_regions)}")

if candidate_regions:
    # Save the best candidate
    best_addr, best_data = candidate_regions[0]
    out_file = "output/decrypted_strings_ram.bin"
    with open(out_file, "wb") as f:
        f.write(best_data)
    print(f"Saved region from 0x{best_addr:X} ({len(best_data)} bytes) to {out_file}")

    # Extract all Unicode strings from this buffer
    extracted_strings = set()
    for m in re.finditer(rb'(?:[\x20-\x7e\xa0-\xff]\x00){3,}', best_data):
        try:
            s = m.group().decode('utf-16le')
            if len(s.strip()) > 2:
                extracted_strings.add(s.strip())
        except:
            pass
            
    print(f"Extracted {len(extracted_strings)} unique strings from table!")
    with open("output/extracted_kata_strings.txt", "w", encoding="utf-8") as f:
        for s in sorted(list(extracted_strings)):
            f.write(s + "\n")
    print("Saved string list to output/extracted_kata_strings.txt")
