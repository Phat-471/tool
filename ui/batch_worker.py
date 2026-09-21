import os
import time
from concurrent.futures import ThreadPoolExecutor, as_completed
from pathlib import Path
from typing import Any, Dict, List
from PyQt6.QtCore import QThread, pyqtSignal

from config import OUTPUT_DIR
from core.file_manager import FileManager
from engines.dotnet_engine import DotNetDecompiler
from engines.java_engine import JavaDecompiler
from engines.native_engine import NativePEEngine
from engines.python_engine import PythonDecompiler


class BatchDecompileWorker(QThread):
    """
    Luồng xử lý ngầm (Worker Thread) cho chế độ Dịch ngược Hàng loạt (Batch Decompile):
    - Chạy song song đa luồng (ThreadPoolExecutor) để tăng tốc độ gấp 3 - 5 lần
    - Gom nhóm toàn bộ mã nguồn của các Module/DLL vào chung một không gian làm việc
    - Báo cáo tiến độ từng tệp và cập nhật trạng thái thời gian thực
    """

    progress_updated = pyqtSignal(int, str)
    process_finished = pyqtSignal(dict)
    error_occurred   = pyqtSignal(str)
    status_hint      = pyqtSignal(str, str)

    def __init__(self, folder_path: str, selected_files: List[Dict[str, Any]], options: dict):
        super().__init__()
        self.folder_path = folder_path
        self.selected_files = selected_files
        self.options = options
        self._is_cancelled = False

    def cancel(self):
        self._is_cancelled = True

    def _process_single_file(self, item: Dict[str, Any], master_out_dir: Path) -> Dict[str, Any]:
        """Xử lý dịch ngược 1 tệp trong ThreadPool."""
        file_path = item["path"]
        filename = item["filename"]
        engine_name = item.get("engine", "unknown")

        # Thư mục riêng cho từng module bên trong thư mục tổng
        module_out_dir = master_out_dir / f"{filename}_decompiled"
        module_out_dir.mkdir(parents=True, exist_ok=True)

            if engine_name == "dotnet":
                decompiler = DotNetDecompiler()
                return decompiler.decompile(file_path, str(module_out_dir))
            elif engine_name == "sfx":
                from engines.sfx_engine import SFXDecompilerEngine
                decompiler = SFXDecompilerEngine()
                return decompiler.decompile(file_path, str(module_out_dir))
            elif engine_name == "java":
                decompiler = JavaDecompiler()
                return decompiler.decompile(file_path, str(module_out_dir))
            elif engine_name == "python":
                decompiler = PythonDecompiler()
                return decompiler.decompile(file_path, str(module_out_dir))
            elif engine_name == "native":
                decompiler = NativePEEngine()
                return decompiler.decompile(file_path, str(module_out_dir))
            else:
                return {"success": False, "message": f"Không có engine cho {filename}"}
        except Exception as exc:
            return {"success": False, "message": f"Lỗi {filename}: {exc}"}

    def run(self):
        total_files = len(self.selected_files)
        if total_files == 0:
            self.error_occurred.emit("Không có tệp nào được chọn để dịch ngược.")
            return

        folder_name = Path(self.folder_path).name
        master_out = OUTPUT_DIR / f"{folder_name}_batch_workspace"
        FileManager.clean_directory(str(master_out))

        self.progress_updated.emit(5, f"Bắt đầu dịch ngược hàng loạt {total_files} tệp...")
        self.status_hint.emit("info", f"🚀 Đang khởi chạy xử lý song song đa luồng cho {total_files} tệp...")

        # Số luồng song song (tối đa 4 luồng để tối ưu I/O)
        max_workers = min(4, total_files)
        completed_count = 0
        success_count = 0

        with ThreadPoolExecutor(max_workers=max_workers) as executor:
            future_to_file = {
                executor.submit(self._process_single_file, item, master_out): item
                for item in self.selected_files
            }

            for future in as_completed(future_to_file):
                if self._is_cancelled:
                    break

                item = future_to_file[future]
                fname = item["filename"]
                completed_count += 1
                percent = int(10 + (completed_count / total_files) * 80)

                try:
                    res = future.result()
                    if res.get("success"):
                        success_count += 1
                        self.status_hint.emit("ok", f"✅ [{completed_count}/{total_files}] Đã dịch xong: {fname}")
                    else:
                        self.status_hint.emit("warn", f"⚠️ [{completed_count}/{total_files}] {fname}: {res.get('message', '')[:60]}")
                except Exception as exc:
                    self.status_hint.emit("error", f"❌ [{completed_count}/{total_files}] {fname}: {exc}")

                self.progress_updated.emit(percent, f"Đang dịch ({completed_count}/{total_files}): {fname}")

        # ── Gom nhóm toàn bộ mã nguồn trên toàn bộ các module ──
        self.progress_updated.emit(95, "Đang gom nhóm cấu trúc cây mã nguồn đa module...")
        aggregated_files: Dict[str, str] = {}

        # Ưu tiên sắp xếp theo module và mã nguồn
        for f in sorted(master_out.rglob("*")):
            if f.is_file():
                rel = str(f.relative_to(master_out))
                aggregated_files[rel] = str(f)

        # Nén ZIP nếu có tùy chọn
        zip_path = None
        if self.options.get("export_zip", True) and aggregated_files:
            self.progress_updated.emit(98, "Đang nén toàn bộ không gian làm việc thành file ZIP...")
            zip_file = OUTPUT_DIR / f"{folder_name}_all_modules.zip"
            try:
                FileManager.create_zip(str(master_out), str(zip_file))
                if zip_file.is_file():
                    zip_path = str(zip_file)
            except Exception:
                pass

        self.progress_updated.emit(100, f"Hoàn tất! Đã dịch {success_count}/{total_files} module.")
        self.status_hint.emit("ok", f"🎉 Hoàn tất dịch ngược hàng loạt! {success_count}/{total_files} tệp thành công.")

        self.process_finished.emit({
            "success": True,
            "is_batch": True,
            "total_modules": total_files,
            "success_modules": success_count,
            "files_count": len(aggregated_files),
            "recovered_files": aggregated_files,
            "output_dir": str(master_out),
            "zip_path": zip_path,
            "message": f"✅ Dịch ngược hàng loạt hoàn tất ({success_count}/{total_files} module thành công).",
        })
