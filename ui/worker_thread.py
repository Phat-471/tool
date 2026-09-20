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

    progress_updated = pyqtSignal(int, str)   # (percent, message)
    process_finished = pyqtSignal(dict)        # kết quả cuối
    error_occurred   = pyqtSignal(str)         # lỗi nghĩêm trọng dừng hẳn
    status_hint      = pyqtSignal(str, str)    # (level, message)  level: 'info'|'warn'|'ok'|'error'

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

                # ── Thử ILSpy lần 1 ────────────────────────────────
                self.progress_updated.emit(60, "Đang chạy ILSpy CLI để trích xuất mã nguồn C#...")
                self.status_hint.emit("info", "▶ ILSpy: Đang dịch ngược assembly...")

                # Chạy ILSpy lần đầu (kiểm tra nhanh)
                ok1, msg1, _, _ = decompiler._run_ilspy(
                    decompiler.get_executable_path() or "",
                    self.file_path,
                    Path(specific_output_dir),
                )

                if not ok1 and ("[BAD_IMAGE]" in msg1 or decompiler._is_bad_image_error(msg1)):
                    # ── Phát hiện BadImageFormatException ──
                    self.progress_updated.emit(
                        65,
                        "⚠️ Phát hiện lỗi Metadata (BadImageFormatException). "
                        "Đang tiến hành khôi phục..."
                    )
                    self.status_hint.emit(
                        "warn",
                        "⚠️ Phát hiện lỗi Metadata – Đang tiến hành khôi phục Metadata bằng de4dot..."
                    )
                    time.sleep(0.4)

                    # ── de4dot ──
                    self.progress_updated.emit(70, "Đang chạy de4dot để gỡ làm rối assembly...")
                    self.status_hint.emit("info", "🔧 de4dot: Đang gỡ làm rối (Obfuscation removal)...")

                    cleaned_path, de4dot_log = decompiler._preprocess_with_de4dot(
                        self.file_path, Path(specific_output_dir)
                    )

                    if cleaned_path:
                        self.status_hint.emit("ok", f"✅ de4dot: {de4dot_log}")
                        self.progress_updated.emit(78, "Đang dịch ngược lại file đã làm sạch bằng ILSpy...")
                        self.status_hint.emit("info", "▶ ILSpy: Đang dịch ngược lại file đã khử khuẩy...")
                    else:
                        self.status_hint.emit("warn", f"⚠️ de4dot: {de4dot_log}")
                        self.progress_updated.emit(75, "Đang thử dnSpy CLI...")
                        self.status_hint.emit("info", "🔄 dnSpy: Đang thử dịch ngược bằng dnSpy...")

                # ── Gọi engine đầy đủ (bao gồm toàn bộ fallback chain) ──
                res = decompiler.decompile(self.file_path, specific_output_dir)

                # Sau khi hoàn tất: phân tích kết quả và gửi status_hint
                if res.get("success"):
                    msg_body = res.get("message", "")
                    if "de4dot" in msg_body or "[BAD_IMAGE]" in res.get("stderr", ""):
                        self.status_hint.emit("ok", "✅ Khôi phục Metadata thành công!")
                    elif "pe_summary" in msg_body or "PE" in msg_body:
                        self.status_hint.emit(
                            "warn",
                            "⚠️ Không dịch ngược được .NET – đã xuất báo cáo cấu trúc PE."
                        )
                    else:
                        self.status_hint.emit("ok", "✅ ILSpy dịch ngược thành công!")
                else:
                    self.status_hint.emit("error", "❌ Không thể dịch ngược – xem chi tiết trong tab Phân tích.")

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
