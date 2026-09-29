import struct
import json
import sys

# Configure UTF-8 stdout
if sys.platform.startswith("win"):
    try:
        sys.stdout.reconfigure(encoding="utf-8", errors="replace")
        sys.stderr.reconfigure(encoding="utf-8", errors="replace")
    except Exception:
        pass

data = open("output/decrypted_string_pool.bin", "rb").read()

offset = 0
strings_by_offset = {}
all_strings = []

while offset < len(data) - 4:
    length = struct.unpack_from("<I", data, offset)[0]
    if 2 <= length <= 65536 and length % 2 == 0 and offset + 4 + length <= len(data):
        raw_bytes = data[offset + 4 : offset + 4 + length]
        try:
            text = raw_bytes.decode("utf-16le")
            printable_ratio = sum(1 for c in text if c.isprintable() or c in '\r\n\t') / len(text)
            if printable_ratio > 0.85:
                strings_by_offset[offset] = text
                all_strings.append((offset, text))
                offset += 4 + length
                continue
        except Exception:
            pass
    offset += 2

print(f"Tổng số chuỗi đã giải mã từ Resource: {len(all_strings)} chuỗi!")

# Filter targets
urls = []
api_endpoints = []
license_strings = []
ai_strings = []

for off, s in all_strings:
    s_clean = s.strip()
    s_lower = s_clean.lower()
    if s_lower.startswith("http://") or s_lower.startswith("https://"):
        urls.append((off, s_clean))
    elif any(k in s_lower for k in ["api/", ".ashx", "wp-json", "gateway", "endpoint", "op="]):
        api_endpoints.append((off, s_clean))
    if any(k in s_lower for k in ["license", "serial", "entitlement", "deviceid", "bootstrap", "heartbeat", "seatstatus"]):
        license_strings.append((off, s_clean))
    if any(k in s_lower for k in ["gpt-", "openai", "token", "balance", "ai/v1"]):
        ai_strings.append((off, s_clean))

print(f"\n=================== 🌐 TẤT CẢ URL & DOMAIN ({len(urls)}) ===================")
for off, u in urls:
    print(f"  [{off:6d}] : {u}")

print(f"\n=================== 📡 CÁC API ENDPOINTS & ASHX ({len(api_endpoints)}) ===================")
for off, ep in api_endpoints:
    print(f"  [{off:6d}] : {ep}")

print(f"\n=================== 🔑 CÁC CHUỖI XÁC THỰC BẢN QUYỀN V2 ({len(license_strings)}) ===================")
for off, ls in license_strings:
    print(f"  [{off:6d}] : {ls}")

print(f"\n=================== 🤖 CÁC CHUỖI AI CLOUD ({len(ai_strings)}) ===================")
for off, ai in ai_strings:
    print(f"  [{off:6d}] : {ai}")

# Save JSON and text
with open("output/all_decrypted_strings.json", "w", encoding="utf-8") as f:
    json.dump({str(k): v for k, v in strings_by_offset.items()}, f, ensure_ascii=False, indent=2)

with open("output/all_decrypted_strings.txt", "w", encoding="utf-8") as f:
    for off, s in all_strings:
        f.write(f"[{off}]: {s}\n")

print("\n✅ Đã lưu toàn bộ từ điển chuỗi ra output/all_decrypted_strings.json và output/all_decrypted_strings.txt")
