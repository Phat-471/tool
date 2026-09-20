import time
from pathlib import Path
from PyQt6.QtCore import QThread, pyqtSignal

from core.file_manager import FileManager
from core.detector import FileDetector
from core.analyzer import FileAnalyzer
from engines.dotnet_engine import DotNetDecompiler
from engines.java_engine import JavaDecompiler
from engines.python_engine import PythonDecompiler
from config import OUTPUT_DIR

class DecompileWorker(QThread):
    """Luồng xử lý ngầm (Worker Thread) cho quá trình dịch ngược, không làm đơ giao diện."""

    progress_updated = pyqtSignal(int, str)
    process_finished = pyqtSignal(dict)
    error_occurred = pyqtSignal(str)

    def __init__(self, file_path: str, options: dict):
        super().__init__()
        self.file_path = file_path
        self.options = options
        self._is_cancelled = False

    def cancel(self):
        self._is_cancelled = True

    def run(self):
        try:
            self.progress_updated.emit(10, "Đang khởi tạo và kiểm tra tệp đầu vào...")
            time.sleep(0.3)

            # 1. Nhận diện tệp
            detection = FileDetector.detect(self.file_path)
            if "error" in detection:
                self.error_occurred.emit(detection["error"])
                return

            self.progress_updated.emit(
                20, f"Đã nhận diện: {detection['file_type']} (Engine: {detection['engine'].upper()})"
            )
            time.sleep(0.3)

            # 2. Chuẩn bị thư mục đầu ra
            target_name = Path(self.file_path).stem
            specific_output_dir = str(OUTPUT_DIR / f"{target_name}_source")
            FileManager.clean_directory(specific_output_dir)

            # 3. Phân tích tĩnh: Phát hiện Packer/Obfuscator & Trích xuất chuỗi
            self.progress_updated.emit(35, "Đang quét chữ ký bảo vệ (Packer/Obfuscator) & Trích xuất chuỗi...")
            report_path = str(Path(specific_output_dir) / "analysis_report.json")
            analysis_report = FileAnalyzer.generate_full_report(self.file_path, report_path)
            time.sleep(0.3)

            self.progress_updated.emit(50, "Đang chuẩn bị engine giải mã...")

            # 4. Chọn và chạy Engine tương ứng
            engine_name = detection["engine"]
            res = None

            if engine_name == "dotnet":
                decompiler = DotNetDecompiler()
                self.progress_updated.emit(60, "Đang chạy ILSpy CLI để trích xuất mã nguồn C#...")
                res = decompiler.decompile(self.file_path, specific_output_dir)

            elif engine_name == "java":
                decompiler = JavaDecompiler()
                self.progress_updated.emit(50, "Đang chạy JADX CLI để trích xuất mã nguồn Java...")
                res = decompiler.decompile(self.file_path, specific_output_dir)

            elif engine_name == "native":
                from engines.native_engine import NativePEEngine
                decompiler = NativePEEngine()
                self.progress_updated.emit(60, "Đang phân tích cấu trúc Native PE, bảng Export & Import...")
                res = decompiler.decompile(self.file_path, specific_output_dir)

            elif engine_name == "python":
                decompiler = PythonDecompiler()
                self.progress_updated.emit(50, "Đang chạy PyCDC để trích xuất mã nguồn Python...")
                res = decompiler.decompile(self.file_path, specific_output_dir)

            else:
                self.error_occurred.emit(f"Chưa có engine hỗ trợ định dạng: {detection['file_type']}")
                return

            if not res or not res.get("success"):
                err_msg = res.get("message", "Lỗi không xác định trong quá trình dịch ngược.")
                self.process_finished.emit({
                    "success": False,
                    "error_message": err_msg,
                    "output_dir": specific_output_dir,
                    "zip_path": None,
                    "files_count": 0,
                    "recovered_files": {},
                    "analysis_report": analysis_report,
                    "language": detection.get("language", "plaintext"),
                })
                return

            self.progress_updated.emit(85, "Dịch ngược thành công! Đang quét cấu trúc tệp mã nguồn...")
            time.sleep(0.3)

            # 4. Quét danh sách file kết quả
            recovered_files = FileManager.scan_source_files(specific_output_dir)

            # 5. Đóng gói ZIP nếu người dùng chọn
            zip_path = None
            if self.options.get("export_zip", True):
                self.progress_updated.emit(95, "Đang đóng gói mã nguồn sang file .zip...")
                zip_path = FileManager.create_zip(
                    specific_output_dir,
                    str(OUTPUT_DIR / f"{target_name}_recovered.zip")
                )

            self.progress_updated.emit(100, "Hoàn tất toàn bộ quy trình!")

            self.process_finished.emit({
                "success": True,
                "output_dir": specific_output_dir,
                "zip_path": zip_path,
                "files_count": len(recovered_files),
                "recovered_files": recovered_files,
                "analysis_report": analysis_report,
                "language": detection.get("language", "plaintext"),
                "message": res.get("message", "Thành công"),
            })

        except Exception as e:
            self.error_occurred.emit(f"Lỗi ngoại lệ: {str(e)}")
