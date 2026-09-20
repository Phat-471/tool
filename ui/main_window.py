import os
from pathlib import Path
from PyQt6.QtCore import Qt
from PyQt6.QtWidgets import (
    QApplication,
    QCheckBox,
    QFileDialog,
    QGroupBox,
    QHBoxLayout,
    QHeaderView,
    QLabel,
    QLineEdit,
    QMainWindow,
    QMessageBox,
    QProgressBar,
    QPushButton,
    QSplitter,
    QTabWidget,
    QTextEdit,
    QTreeWidget,
    QTreeWidgetItem,
    QVBoxLayout,
    QWidget,
)

from core.file_manager import FileManager
from core.detector import FileDetector
from ui.code_viewer import CodeViewerWidget
from ui.worker_thread import DecompileWorker
from ui.search_widget import GlobalSearchWidget
from config import SUPPORTED_EXTENSIONS

class MainWindow(QMainWindow):
    """Cửa sổ chính của ứng dụng Desktop Khôi phục Mã nguồn."""

    def __init__(self):
        super().__init__()
        self.selected_file_path = None
        self.current_worker = None
        self.recovered_files = {}
        self.current_zip_path = None

        self.init_ui()

    def init_ui(self):
        self.setWindowTitle("🛡️ Hệ thống Khôi phục Mã nguồn (Desktop Edition)")
        self.resize(1100, 750)
        self.setAcceptDrops(True)

        central_widget = QWidget()
        self.setCentralWidget(central_widget)
        main_layout = QVBoxLayout(central_widget)
        main_layout.setSpacing(12)
        main_layout.setContentsMargins(15, 15, 15, 15)

        # 1. Khu vực chọn file (Hỗ trợ kéo thả hoặc bấm nút)
        file_group = QGroupBox("📁 Tệp đầu vào (.dll, .apk, .pyc, .jar)")
        file_layout = QHBoxLayout(file_group)

        self.btn_select_file = QPushButton("📂 Chọn tệp...")
        self.btn_select_file.setFixedWidth(120)
        self.btn_select_file.clicked.connect(self.choose_file)
        file_layout.addWidget(self.btn_select_file)

        self.lbl_file_path = QLabel("Kéo thả file vào đây hoặc bấm 'Chọn tệp...'")
        self.lbl_file_path.setStyleSheet("color: #64748B; font-style: italic;")
        file_layout.addWidget(self.lbl_file_path)

        main_layout.addWidget(file_group)

        # 2. Khu vực Tùy chọn Cấu hình & Nút Bắt đầu
        control_layout = QHBoxLayout()

        opt_group = QGroupBox("⚙️ Tùy chọn")
        opt_layout = QHBoxLayout(opt_group)

        self.chk_detect = QCheckBox("Nhận diện định dạng")
        self.chk_detect.setChecked(True)
        opt_layout.addWidget(self.chk_detect)

        self.chk_hierarchy = QCheckBox("Khôi phục cấu trúc thư mục")
        self.chk_hierarchy.setChecked(True)
        opt_layout.addWidget(self.chk_hierarchy)

        self.chk_zip = QCheckBox("Tự động nén ZIP")
        self.chk_zip.setChecked(True)
        opt_layout.addWidget(self.chk_zip)

        control_layout.addWidget(opt_group)

        self.btn_start = QPushButton("🚀 Bắt đầu xử lý")
        self.btn_start.setFixedHeight(45)
        self.btn_start.setStyleSheet(
            """
            QPushButton {
                background-color: #2563EB;
                color: white;
                font-weight: bold;
                font-size: 14px;
                border-radius: 6px;
                padding: 0 20px;
            }
            QPushButton:hover {
                background-color: #1D4ED8;
            }
            QPushButton:disabled {
                background-color: #94A3B8;
            }
            """
        )
        self.btn_start.clicked.connect(self.start_processing)
        control_layout.addWidget(self.btn_start)

        main_layout.addLayout(control_layout)

        # 3. Thanh trạng thái & Progress bar
        status_layout = QVBoxLayout()
        self.lbl_status = QLabel("Trạng thái: Sẵn sàng")
        self.lbl_status.setStyleSheet("font-weight: 500; color: #1E293B;")
        status_layout.addWidget(self.lbl_status)

        self.progress_bar = QProgressBar()
        self.progress_bar.setValue(0)
        self.progress_bar.setFixedHeight(16)
        self.progress_bar.setTextVisible(True)
        status_layout.addWidget(self.progress_bar)

        main_layout.addLayout(status_layout)

        # 4. Khu vực Splitter (Cây thư mục bên trái - Tab Widget bên phải)
        splitter = QSplitter(Qt.Orientation.Horizontal)

        # Cây thư mục tệp kết quả
        tree_container = QWidget()
        tree_layout = QVBoxLayout(tree_container)
        tree_layout.setContentsMargins(0, 0, 0, 0)
        self.lbl_tree = QLabel("📂 Cấu trúc mã nguồn")
        self.lbl_tree.setStyleSheet("font-weight: bold;")
        tree_layout.addWidget(self.lbl_tree)

        # Ô lọc nhanh cây file
        self.txt_tree_filter = QLineEdit()
        self.txt_tree_filter.setPlaceholderText("🔍 Lọc tệp theo tên...")
        self.txt_tree_filter.textChanged.connect(self.filter_tree)
        tree_layout.addWidget(self.txt_tree_filter)

        self.file_tree = QTreeWidget()
        self.file_tree.setHeaderLabels(["Tên tệp"])
        self.file_tree.header().setSectionResizeMode(0, QHeaderView.ResizeMode.Stretch)
        self.file_tree.itemClicked.connect(self.on_file_item_clicked)
        tree_layout.addWidget(self.file_tree)
        splitter.addWidget(tree_container)

        # Tab Widget bên phải
        self.tabs = QTabWidget()

        # Tab 1: Trình xem mã nguồn
        tab_code = QWidget()
        code_layout = QVBoxLayout(tab_code)
        code_layout.setContentsMargins(5, 5, 5, 5)

        code_header_layout = QHBoxLayout()
        self.lbl_current_file = QLabel("💻 Trình xem mã nguồn")
        self.lbl_current_file.setStyleSheet("font-weight: bold;")
        code_header_layout.addWidget(self.lbl_current_file)

        self.btn_export_zip = QPushButton("💾 Tải file ZIP")
        self.btn_export_zip.setEnabled(False)
        self.btn_export_zip.clicked.connect(self.export_zip)
        code_header_layout.addWidget(self.btn_export_zip)
        code_layout.addLayout(code_header_layout)

        self.code_viewer = CodeViewerWidget()
        code_layout.addWidget(self.code_viewer)
        self.tabs.addTab(tab_code, "💻 Mã nguồn")

        # Tab 2: Báo cáo phân tích bảo vệ & Strings
        tab_report = QWidget()
        report_layout = QVBoxLayout(tab_report)
        report_layout.setContentsMargins(5, 5, 5, 5)

        self.report_viewer = QTextEdit()
        self.report_viewer.setReadOnly(True)
        self.report_viewer.setStyleSheet("background-color: #FFFFFF; border: 1px solid #E2E8F0; padding: 8px;")
        report_layout.addWidget(self.report_viewer)
        self.tabs.addTab(tab_report, "📊 Phân tích & Strings")

        # Tab 3: Tìm kiếm toàn cục trong code
        self.search_widget = GlobalSearchWidget()
        self.search_widget.navigate_to_code.connect(self.on_search_navigation)
        self.tabs.addTab(self.search_widget, "🔍 Tìm kiếm trong code")

        splitter.addWidget(self.tabs)
        splitter.setSizes([300, 800])
        main_layout.addWidget(splitter, stretch=1)

    # ---------------------------------------------------------
    # Sự kiện Kéo - Thả file (Drag & Drop)
    # ---------------------------------------------------------
    def dragEnterEvent(self, event):
        if event.mimeData().hasUrls():
            event.acceptProposedAction()

    def dropEvent(self, event):
        for url in event.mimeData().urls():
            file_path = url.toLocalFile()
            if FileManager.is_supported(file_path):
                self.set_selected_file(file_path)
                break
            else:
                QMessageBox.warning(
                    self,
                    "Định dạng không hỗ trợ",
                    f"Chỉ hỗ trợ các file: {', '.join(SUPPORTED_EXTENSIONS.keys())}"
                )

    # ---------------------------------------------------------
    # Các hàm tương tác
    # ---------------------------------------------------------
    def choose_file(self):
        filter_str = "Hỗ trợ (*.dll *.apk *.pyc *.jar);;Tất cả (*.*)"
        file_path, _ = QFileDialog.getOpenFileName(self, "Chọn file cần khôi phục", "", filter_str)
        if file_path:
            self.set_selected_file(file_path)

    def set_selected_file(self, file_path: str):
        self.selected_file_path = file_path
        info = FileManager.get_file_info(file_path)
        self.lbl_file_path.setText(
            f"<b>{info['filename']}</b> ({info['size_kb']} KB) - <i>{info['type_desc']}</i>"
        )
        self.lbl_file_path.setStyleSheet("color: #1E293B;")

    def start_processing(self):
        if not self.selected_file_path:
            QMessageBox.warning(self, "Chưa chọn file", "Vui lòng chọn một file (.dll, .apk, .pyc) để bắt đầu.")
            return

        # Vô hiệu hóa nút trong khi xử lý
        self.btn_start.setEnabled(False)
        self.btn_select_file.setEnabled(False)
        self.file_tree.clear()
        self.code_viewer.clear()
        self.report_viewer.clear()
        self.btn_export_zip.setEnabled(False)

        options = {
            "detect_env": self.chk_detect.isChecked(),
            "hierarchy": self.chk_hierarchy.isChecked(),
            "export_zip": self.chk_zip.isChecked(),
        }

        # Khởi tạo và chạy luồng ngầm
        self.current_worker = DecompileWorker(self.selected_file_path, options)
        self.current_worker.progress_updated.connect(self.on_progress)
        self.current_worker.process_finished.connect(self.on_finished)
        self.current_worker.error_occurred.connect(self.on_error)
        self.current_worker.start()

    def on_progress(self, percent: int, message: str):
        self.progress_bar.setValue(percent)
        self.lbl_status.setText(f"Trạng thái: {message}")

    def on_finished(self, result: dict):
        self.btn_start.setEnabled(True)
        self.btn_select_file.setEnabled(True)
        self.progress_bar.setValue(100)

        # Hiển thị báo cáo phân tích tĩnh và chuỗi (luôn luôn hiển thị)
        analysis_report = result.get("analysis_report", {})
        self.render_analysis_report(analysis_report)

        # Nếu decompiler không thể trích xuất được code gốc (ví dụ do Obfuscator / Native DLL)
        if not result.get("success", False):
            self.lbl_status.setText("Trạng thái: ⚠️ Không thể dịch ngược mã nguồn gốc.")
            # Tự động chuyển sang tab Phân tích & Strings để người dùng xem dữ liệu tĩnh
            self.tabs.setCurrentIndex(1)
            QMessageBox.warning(
                self,
                "Thông báo dịch ngược",
                result.get("error_message", "Có lỗi xảy ra trong quá trình dịch ngược.")
            )
            return

        self.lbl_status.setText("Trạng thái: ✅ Đã hoàn tất khôi phục!")
        self.recovered_files = result.get("recovered_files", {})
        self.current_zip_path = result.get("zip_path")

        if self.current_zip_path:
            self.btn_export_zip.setEnabled(True)

        # Xây dựng cây thư mục trên giao diện
        self.populate_tree(self.recovered_files)
        self.search_widget.set_files(self.recovered_files)
        self.tabs.setCurrentIndex(0)

        QMessageBox.information(
            self,
            "Thành công",
            f"Đã trích xuất thành công {result['files_count']} tệp mã nguồn!\nThư mục: {result['output_dir']}"
        )

    def render_analysis_report(self, report: dict):
        """Hiển thị báo cáo phân tích tĩnh dạng HTML."""
        if not report:
            self.report_viewer.setHtml("<p><i>Không có dữ liệu phân tích tĩnh.</i></p>")
            return

        target_file = report.get("target_file", "Unknown")
        size_kb = report.get("file_size_kb", 0)
        prot_info = report.get("protection_analysis", {})
        protections = prot_info.get("protections", ["Không phát hiện"])
        details = prot_info.get("details", {})
        strings_info = report.get("strings_analysis", {})

        urls = strings_info.get("detected_urls", [])
        ips = strings_info.get("detected_ips", [])
        samples = strings_info.get("sample_strings", [])

        prot_items = "".join(
            f'<li style="color: #DC2626; font-weight: bold;">{p}</li>'
            if "Packer" in p or "Obfuscator" in p
            else f'<li style="color: #16A34A;">{p}</li>'
            for p in protections
        )

        url_items = "".join(f"<li>{u}</li>" for u in urls[:20]) if urls else "<li><i>Không tìm thấy URL.</i></li>"
        ip_items = "".join(f"<li><code>{ip}</code></li>" for ip in ips[:20]) if ips else "<li><i>Không tìm thấy IP.</i></li>"
        samples_text = "\n".join(samples[:80])

        html = f"""
        <div style="font-family: Segoe UI, sans-serif; color: #1E293B;">
            <h2 style="color: #2563EB; margin-bottom: 5px;">📊 Báo cáo Phân tích Tệp</h2>
            <hr style="border: 0; border-top: 1px solid #CBD5E1; margin-bottom: 15px;">

            <h3>📁 Thông tin tệp</h3>
            <ul>
                <li><b>Tên tệp:</b> <code>{target_file}</code></li>
                <li><b>Kích thước:</b> {size_kb} KB</li>
                <li><b>Định dạng nhận diện:</b> {details.get("format", "N/A")}</li>
                <li><b>Môi trường Runtime:</b> {details.get("runtime", "N/A")}</li>
            </ul>

            <h3>🛡️ Phát hiện Bảo vệ (Packer / Obfuscator)</h3>
            <ul>{prot_items}</ul>

            <h3>🌐 Địa chỉ URL & IP phát hiện ({len(urls)} URLs, {len(ips)} IPs)</h3>
            <p><b>URLs:</b></p>
            <ul>{url_items}</ul>
            <p><b>IP Addresses:</b></p>
            <ul>{ip_items}</ul>

            <h3>📝 Mẫu chuỗi ký tự trích xuất (Strings Preview)</h3>
            <pre style="background-color: #F8FAFC; border: 1px solid #E2E8F0; padding: 10px; border-radius: 4px;">{samples_text}</pre>
        </div>
        """
        self.report_viewer.setHtml(html)

    def on_error(self, err_msg: str):
        self.btn_start.setEnabled(True)
        self.btn_select_file.setEnabled(True)
        self.progress_bar.setValue(0)
        self.lbl_status.setText("Trạng thái: ❌ Có lỗi xảy ra.")
        QMessageBox.critical(self, "Lỗi xử lý", err_msg)

    def populate_tree(self, files_dict: dict):
        self.file_tree.clear()
        self.lbl_tree.setText(f"📂 Cấu trúc ({len(files_dict)} tệp)")
        for rel_path, full_path in files_dict.items():
            item = QTreeWidgetItem(self.file_tree, [rel_path])
            item.setData(0, Qt.ItemDataRole.UserRole, full_path)

    def filter_tree(self, text: str):
        """Lọc cây tệp theo từ khóa thời gian thực."""
        query = text.strip().lower()
        root = self.file_tree.invisibleRootItem()
        visible_count = 0
        for i in range(root.childCount()):
            item = root.child(i)
            match = not query or query in item.text(0).lower()
            item.setHidden(not match)
            if match:
                visible_count += 1
        self.lbl_tree.setText(f"📂 Cấu trúc ({visible_count}/{len(self.recovered_files)} tệp)")

    def on_search_navigation(self, file_path: str, line_no: int):
        """Khi người dùng nhấp đúp vào kết quả tìm kiếm -> nhảy tới file và dòng code đó."""
        if not file_path or not os.path.isfile(file_path):
            return

        self.tabs.setCurrentIndex(0)
        rel_name = os.path.basename(file_path)
        self.lbl_current_file.setText(f"💻 Mã nguồn: {rel_name} (Dòng {line_no})")

        try:
            with open(file_path, "r", encoding="utf-8", errors="ignore") as f:
                content = f.read()
            ext = Path(file_path).suffix.lower()
            lang = "csharp" if ext in [".cs", ".csproj"] else "python" if ext == ".py" else "java"
            self.code_viewer.set_code(content, lang)
            self.code_viewer.go_to_line(line_no)
        except Exception as e:
            self.code_viewer.set_code(f"// Không thể đọc file: {str(e)}")

    def on_file_item_clicked(self, item: QTreeWidgetItem, column: int):
        full_path = item.data(0, Qt.ItemDataRole.UserRole)
        if full_path and os.path.isfile(full_path):
            self.lbl_current_file.setText(f"💻 Mã nguồn: {item.text(0)}")
            try:
                with open(full_path, "r", encoding="utf-8", errors="ignore") as f:
                    content = f.read()
                ext = Path(full_path).suffix.lower()
                lang = "csharp" if ext in [".cs", ".csproj"] else "python" if ext == ".py" else "java"
                self.code_viewer.set_code(content, lang)
            except Exception as e:
                self.code_viewer.set_code(f"// Không thể đọc file: {str(e)}")

    def export_zip(self):
        if not self.current_zip_path or not os.path.isfile(self.current_zip_path):
            QMessageBox.warning(self, "Chưa có file ZIP", "Không tìm thấy file ZIP đã nén.")
            return

        save_dest, _ = QFileDialog.getSaveFileName(
            self,
            "Lưu file ZIP mã nguồn",
            os.path.basename(self.current_zip_path),
            "Zip Archive (*.zip)"
        )
        if save_dest:
            import shutil
            shutil.copy2(self.current_zip_path, save_dest)
            QMessageBox.information(self, "Đã lưu", f"Đã lưu file ZIP tại:\n{save_dest}")
