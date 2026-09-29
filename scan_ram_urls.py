import ctypes
import re
from ctypes import wintypes

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
PAGE_GUARD = 0x100
PAGE_NOACCESS = 0x01

h_process = kernel32.OpenProcess(PROCESS_VM_READ | PROCESS_QUERY_INFORMATION, False, PID)
if not h_process:
    print(f"Failed to open process {PID}")
    exit(1)

print(f"Scanning RAM of PID {PID} (AutoCAD)...")

url_patterns = [
    re.compile(rb"https?://[a-zA-Z0-9\.\-_/:\?=%&]+"),
    re.compile(rb"(?:[a-zA-Z0-9\-_]+\.)*katapro\.[a-zA-Z0-9\-_/:\?=%&]+", re.IGNORECASE),
    re.compile(rb"api[a-zA-Z0-9\.\-_/:\?=%&]*kata[a-zA-Z0-9\.\-_/:\?=%&]*", re.IGNORECASE),
]

found_urls = set()
api_endpoints = set()

address = 0
mbi = MEMORY_BASIC_INFORMATION64()

while kernel32.VirtualQueryEx(h_process, ctypes.c_void_p(address), ctypes.byref(mbi), ctypes.sizeof(mbi)):
    if (mbi.State == MEM_COMMIT and 
        not (mbi.Protect & PAGE_GUARD) and 
        not (mbi.Protect & PAGE_NOACCESS)):
        
        region_size = mbi.RegionSize
        # limit read chunk
        chunk_size = min(region_size, 10 * 1024 * 1024)
        buf = (ctypes.c_char * chunk_size)()
        bytes_read = ctypes.c_size_t(0)
        
        if kernel32.ReadProcessMemory(h_process, ctypes.c_void_p(mbi.BaseAddress), buf, chunk_size, ctypes.byref(bytes_read)):
            data = bytes(buf)[:bytes_read.value]
            
            # Check ASCII and UTF-16LE
            # UTF-16LE conversion helper
            for p in url_patterns:
                for match in p.finditer(data):
                    try:
                        u = match.group().decode("latin1", errors="ignore")
                        if len(u) > 5 and any(k in u.lower() for k in ["kata", "license", "auth", "login", "cad"]):
                            found_urls.add(u)
                    except:
                        pass
            
            # Search for katapro in utf-16le
            if b"k\x00a\x00t\x00a\x00p\x00r\x00o\x00" in data or b"k\x00a\x00t\x00a\x00" in data:
                # regex in utf-16le
                matches = re.findall(rb'(?:[\x20-\x7e]\x00){4,}', data)
                for m in matches:
                    try:
                        decoded = m.decode('utf-16le', errors='ignore')
                        if any(k in decoded.lower() for k in ["http", "katapro", "api/", "license", "/v1/", "/v2/"]):
                            found_urls.add(decoded)
                    except:
                        pass

    address = mbi.BaseAddress + mbi.RegionSize

kernel32.CloseHandle(h_process)

print(f"\n=== FOUND TARGET URLS & ENDPOINTS ({len(found_urls)}) ===")
sorted_urls = sorted(list(found_urls))
for u in sorted_urls:
    print(" ->", u)

with open("output/ram_urls_katapro.txt", "w", encoding="utf-8") as f:
    for u in sorted_urls:
        f.write(u + "\n")
print(f"\nSaved to output/ram_urls_katapro.txt")
