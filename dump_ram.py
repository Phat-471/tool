"""
Công cụ trích xuất DLL đã giải mã từ bộ nhớ RAM (Process Memory Dumper CLI).
Sử dụng khi muốn dump nhanh từ dòng lệnh mà không cần qua GUI.

Cách dùng:
    python dump_ram.py
    python dump_ram.py --pid 1234
    python dump_ram.py --keyword Kata
"""

import argparse
import os
import sys
from pathlib import Path

# Cấu hình UTF-8 cho console Windows tránh lỗi cp932/cp1252
if sys.platform.startswith("win"):
    try:
        sys.stdout.reconfigure(encoding="utf-8", errors="replace")
        sys.stderr.reconfigure(encoding="utf-8", errors="replace")
    except Exception:
        pass

from core.process_dumper import ProcessDumper
from config import OUTPUT_DIR


def main():
    parser = argparse.ArgumentParser(description="Trích xuất DLL .NET đã giải mã JIT từ RAM tiến trình CAD/Windows")
    parser.add_argument("--pid", type=int, default=None, help="PID của tiến trình (ví dụ: acad.exe)")
    parser.add_argument("--keyword", type=str, default="Kata", help="Từ khóa lọc tên module (mặc định: Kata)")
    parser.add_argument("--all", action="store_true", help="Dump tất cả các module .NET, không lọc từ khóa")
    parser.add_argument("--out", type=str, default=None, help="Thư mục lưu các file DLL trích xuất")
    args = parser.parse_args()

    procs = ProcessDumper.list_running_processes()
    if not procs:
        print("❌ Không thể lấy danh sách tiến trình. Vui lòng chạy với quyền Administrator.")
        return

    target_pid = args.pid
    target_name = ""

    if target_pid is None:
        # Tự động tìm tiến trình CAD hoặc hỏi người dùng
        cad_procs = [p for p in procs if p["is_cad"]]
        if cad_procs:
            print(f"🎯 Phát hiện tiến trình CAD/BIM đang chạy:")
            for idx, p in enumerate(cad_procs):
                print(f"  [{idx + 1}] PID: {p['pid']} | {p['name']} ({p['desc']}) | RAM: {p['mem_mb']} MB")
            choice = 1
            if len(cad_procs) > 1:
                try:
                    c_str = input(f"Chọn tiến trình [1-{len(cad_procs)}] (mặc định: 1): ").strip()
                    if c_str:
                        choice = int(c_str)
                except ValueError:
                    choice = 1
            target_pid = cad_procs[choice - 1]["pid"]
            target_name = cad_procs[choice - 1]["name"]
        else:
            print("⚠️ Không phát hiện tiến trình CAD nào (acad.exe, revit.exe...) đang chạy.")
            print("Danh sách 10 tiến trình tốn RAM nhất:")
            for idx, p in enumerate(procs[:10]):
                print(f"  [{p['pid']}] {p['name']} - {p['mem_mb']} MB")
            try:
                pid_in = input("Nhập PID bạn muốn quét: ").strip()
                target_pid = int(pid_in)
            except ValueError:
                print("❌ PID không hợp lệ.")
                return

    out_dir = args.out or str(OUTPUT_DIR / f"dumped_{target_name or 'pid'}_{target_pid}")
    kw = "" if args.all else args.keyword

    print(f"\n🚀 Đang quét và trích xuất module từ PID {target_pid}...")
    print(f"📁 Thư mục lưu: {out_dir}")
    print(f"🔍 Bộ lọc: {'Tất cả .NET' if not kw else f'Chứa từ khóa \"{kw}\"'}")

    report = ProcessDumper.scan_and_dump_all(
        pid=target_pid,
        output_dir=out_dir,
        keyword=kw,
        only_dotnet=True
    )

    dumped = report.get("dumped_files", [])
    if not dumped:
        print("\n⚠️ Không tìm thấy module .NET nào phù hợp.")
        print(f"Tổng vùng nhớ đã duyệt: {report.get('total_scanned_regions', 0)}")
        if report.get("errors"):
            print("Chi tiết lỗi:", report["errors"])
        return

    print(f"\n✅ Đã trích xuất thành công {len(dumped)} module:")
    for d in dumped:
        size_kb = round(d["size_bytes"] / 1024, 1)
        print(f"  - 📄 {d['name']} ({size_kb} KB) tại RAM {d['base_address']}")
        print(f"       Đường dẫn: {d['path']}")

    print(f"\n🎉 Hoàn tất! Bạn có thể mở giao diện tool hoặc dùng lệnh sau để dịch ngược:")
    print(f"   python main.py")


if __name__ == "__main__":
    main()
