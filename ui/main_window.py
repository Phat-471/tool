import os
from pathlib import Path
from PyQt6.QtCore import Qt, QTimer
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
    QTabBar,
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
from ui.dll_manager_widget import DLLManagerWidget
from config import SUPPORTED_EXTENSIONS

class MainWindow(QMainWindow):
    """Cửa sổ chính của ứng dụng Desktop Khôi phục Mã nguồn."""

    def __init__(self):
        super().__init__()
        self.selected_file_path = None
        self.selected_folder_path = None
        self.batch_selected_files = []
        self.current_worker = None
        self.recovered_files = {}
        self.current_zip_path = None
        self.current_output_dir = None
        self.category_keys = ["all", "csharp", "cad", "config", "dll", "media"]

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

        # 1. Khu vực chọn file / thư mục (Hỗ trợ kéo thả hoặc bấm nút)
        file_group = QGroupBox("📁 Đầu vào (.dll, .exe, .apk, .pyc, .jar hoặc cả thư mục cài đặt)")
        file_layout = QHBoxLayout(file_group)

        self.btn_select_file = QPushButton("📂 Chọn tệp...")
        self.btn_select_file.setFixedWidth(110)
        self.btn_select_file.clicked.connect(self.choose_file)
        file_layout.addWidget(self.btn_select_file)

        self.btn_select_folder = QPushButton("📁 Chọn thư mục...")
        self.btn_select_folder.setFixedWidth(125)
        self.btn_select_folder.setStyleSheet("font-weight: 500; color: #1D4ED8;")
        self.btn_select_folder.clicked.connect(self.choose_folder)
        file_layout.addWidget(self.btn_select_folder)

        self.lbl_file_path = QLabel("Kéo thả file hoặc thư mục cài đặt vào đây, hoặc bấm 'Chọn tệp...' / 'Chọn thư mục...'")
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
        tree_layout.setSpacing(6)

        self.lbl_tree = QLabel("📂 Cấu trúc mã nguồn")
        self.lbl_tree.setStyleSheet("font-weight: bold;")
        tree_layout.addWidget(self.lbl_tree)

        # Thanh phân loại danh mục tệp nhanh (Category Tabs)
        self.category_tabs = QTabBar()
        self.category_tabs.setExpanding(False)
        self.category_tabs.setStyleSheet("""
            QTabBar::tab {
                background: #F1F5F9;
                color: #475569;
                padding: 4px 7px;
                border-radius: 4px;
                font-size: 11px;
                margin-right: 3px;
                margin-bottom: 2px;
            }
            QTabBar::tab:selected {
                background: #2563EB;
                color: #FFFFFF;
                font-weight: bold;
            }
            QTabBar::tab:hover:!selected {
                background: #E2E8F0;
            }
        """)
        self.category_tabs.addTab("📌 Tất cả")
        self.category_tabs.addTab("💻 C#")
        self.category_tabs.addTab("📐 CAD/LISP")
        self.category_tabs.addTab("⚙️ Data")
        self.category_tabs.addTab("📦 DLL")
        self.category_tabs.addTab("🖼️ Media")
        self.category_tabs.currentChanged.connect(self.on_category_changed)
        tree_layout.addWidget(self.category_tabs)

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

        # Tab 2: Quản lý Module DLL
        self.dll_manager = DLLManagerWidget()
        self.dll_manager.decompile_requested.connect(self.on_dll_decompile_requested)
        self.dll_manager.open_source_requested.connect(self.on_open_decompiled_source)
        self.tabs.addTab(self.dll_manager, "📦 Quản lý Module DLL")

        # Tab 3: Báo cáo phân tích bảo vệ & Strings
        tab_report = QWidget()
        report_layout = QVBoxLayout(tab_report)
        report_layout.setContentsMargins(5, 5, 5, 5)

        self.report_viewer = QTextEdit()
        self.report_viewer.setReadOnly(True)
        self.report_viewer.setStyleSheet("background-color: #FFFFFF; border: 1px solid #E2E8F0; padding: 8px;")
        report_layout.addWidget(self.report_viewer)
        self.tabs.addTab(tab_report, "📊 Phân tích & Strings")

        # Tab 4: Tìm kiếm toàn cục trong code
        self.search_widget = GlobalSearchWidget()
        self.search_widget.navigate_to_code.connect(self.on_search_navigation)
        self.tabs.addTab(self.search_widget, "🔍 Tìm kiếm trong code")

        splitter.addWidget(self.tabs)
        splitter.setSizes([340, 760])
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
            if os.path.isdir(file_path):
                self.handle_folder_selected(file_path)
                break
            elif FileManager.is_supported(file_path):
                self.set_selected_file(file_path)
                break
            else:
                QMessageBox.warning(
                    self,
                    "Định dạng không hỗ trợ",
                    f"Chỉ hỗ trợ các file: {', '.join(SUPPORTED_EXTENSIONS.keys())} hoặc thư mục cài đặt."
                )

    # ---------------------------------------------------------
    # Các hàm tương tác
    # ---------------------------------------------------------
    def choose_file(self):
        filter_str = (
            "Tất cả định dạng hỗ trợ (*.dll *.exe *.apk *.pyc *.jar);;"
            "File thực thi Windows (*.exe *.dll);;"
            "Gói ứng dụng Android (*.apk);;"
            "Python Bytecode (*.pyc);;"
            "Java Archive (*.jar);;"
            "Tất cả tệp (*.*)"
        )
        file_path, _ = QFileDialog.getOpenFileName(self, "Chọn file cần khôi phục", "", filter_str)
        if file_path:
            self.set_selected_file(file_path)

    def choose_folder(self):
        folder_path = QFileDialog.getExistingDirectory(self, "Chọn thư mục cài đặt ứng dụng cần dịch ngược")
        if folder_path:
            self.handle_folder_selected(folder_path)

    def handle_folder_selected(self, folder_path: str):
        """Xử lý khi người dùng chọn hoặc kéo thả một thư mục."""
        from core.batch_scanner import SmartFolderScanner
        from ui.batch_selection_dialog import BatchSelectionDialog

        self._apply_status_style("info", f"🔍 Đang quét thư mục: {Path(folder_path).name}...")
        scan_result = SmartFolderScanner.scan_directory(folder_path)

        if scan_result.get("total_found", 0) == 0:
            QMessageBox.information(
                self,
                "Không tìm thấy tệp",
                f"Không tìm thấy tệp nhị phân nào (.dll, .exe, .apk, .pyc) trong thư mục:\n{folder_path}"
            )
            return

        # Hiển thị hộp thoại xem trước và lọc thông minh
        dialog = BatchSelectionDialog(scan_result, self)
        if dialog.exec():
            selected = dialog.selected_files
            if not selected:
                return

            self.selected_file_path = None
            self.selected_folder_path = folder_path
            self.batch_selected_files = selected

            target_count = len(selected)
            folder_name = Path(folder_path).name
            self.lbl_file_path.setText(
                f"📁 Thư mục: <b>{folder_name}</b> ({target_count} tệp đã chọn để dịch ngược)"
            )
            self.lbl_file_path.setStyleSheet("color: #1D4ED8; font-weight: bold;")
            self._apply_status_style("info", f"🚀 Đang khởi chạy dịch ngược hàng loạt {target_count} tệp...")

            # Tự động bắt đầu xử lý ngay lập tức (không bắt người dùng bấm thêm lần 2)
            self.start_processing()

    def set_selected_file(self, file_path: str):
        self.selected_file_path = file_path
        self.selected_folder_path = None
        self.batch_selected_files = []
        info = FileManager.get_file_info(file_path)
        self.lbl_file_path.setText(
            f"<b>{info['filename']}</b> ({info['size_kb']} KB) - <i>{info['type_desc']}</i>"
        )
        self.lbl_file_path.setStyleSheet("color: #1E293B;")

    def start_processing(self):
        if not self.selected_file_path and not self.batch_selected_files:
            QMessageBox.warning(self, "Chưa chọn dữ liệu", "Vui lòng chọn một file (.dll, .apk, .pyc) hoặc một thư mục cài đặt để bắt đầu.")
            return

        # Vô hiệu hóa nút trong khi xử lý
        self.btn_start.setEnabled(False)
        self.btn_select_file.setEnabled(False)
        self.btn_select_folder.setEnabled(False)
        self.file_tree.clear()
        self.code_viewer.clear()
        self.report_viewer.clear()
        self.btn_export_zip.setEnabled(False)

        options = {
            "detect_env": self.chk_detect.isChecked(),
            "hierarchy": self.chk_hierarchy.isChecked(),
            "export_zip": self.chk_zip.isChecked(),
        }

        if self.batch_selected_files and self.selected_folder_path:
            # ── Chế độ Dịch ngược Hàng loạt Đa Luồng (Batch Mode) ──
            from ui.batch_worker import BatchDecompileWorker
            self.current_worker = BatchDecompileWorker(
                self.selected_folder_path, self.batch_selected_files, options
            )
        else:
            # ── Chế độ Dịch ngược 1 Tệp ──
            self.current_worker = DecompileWorker(self.selected_file_path, options)

        self.current_worker.progress_updated.connect(self.on_progress)
        self.current_worker.process_finished.connect(self.on_finished)
        self.current_worker.error_occurred.connect(self.on_error)
        self.current_worker.status_hint.connect(self.on_status_hint)
        self.current_worker.start()

    # ---------------------------------------------------------
    # Status bar helpers
    # ---------------------------------------------------------
    _STATUS_STYLES = {
        "info":  "font-weight:500; color:#1D4ED8;",          # xanh dương
        "warn":  "font-weight:600; color:#B45309; background:#FFFBEB; border-radius:4px; padding:2px 6px;",
        "ok":    "font-weight:600; color:#15803D; background:#F0FDF4; border-radius:4px; padding:2px 6px;",
        "error": "font-weight:600; color:#DC2626; background:#FEF2F2; border-radius:4px; padding:2px 6px;",
    }

    def _apply_status_style(self, level: str, text: str):
        """Cập nhật nhãn trạng thái với màu sắc tương ứng."""
        style = self._STATUS_STYLES.get(level, self._STATUS_STYLES["info"])
        self.lbl_status.setStyleSheet(style)
        self.lbl_status.setText(text)

    # ---------------------------------------------------------
    # Kết nối tín hiệu từ Worker
    # ---------------------------------------------------------
    def on_status_hint(self, level: str, message: str):
        """Nhận tin hiệu trạng thái chi tiết từ luồng ngầm (không gây crash)."""
        self._apply_status_style(level, message)

    def on_progress(self, percent: int, message: str):
        self.progress_bar.setValue(percent)
        self._apply_status_style("info", f"Trạng thái: {message}")

    def on_finished(self, result: dict):
        self.btn_start.setEnabled(True)
        self.btn_select_file.setEnabled(True)
        self.btn_select_folder.setEnabled(True)
        self.progress_bar.setValue(100)

        # Hiển thị báo cáo phân tích tĩnh (luôn hiển thị)
        output_dir = result.get("output_dir", "")
        analysis_report = result.get("analysis_report", {})
        self.render_analysis_report(analysis_report, output_dir)

        if not result.get("success", False):
            # ── Không thành công ──
            err_msg = result.get("error_message", "Có lỗi xảy ra trong quá trình dịch ngược.")
            self._apply_status_style(
                "warn",
                "⚠️ Không thể dịch ngược mã nguồn gốc. "
                "Hệ thống đã xuất báo cáo phân tích tĩnh thay thế."
            )
            # Chuyển sang tab Phân tích (không hiện hộp thoại crash)
            self.tabs.setCurrentIndex(1)
            # Vẫn cố làm tươi cây thư mục (pe_summary.txt, exports.h … có thể đã được tạo)
            if output_dir:
                QTimer.singleShot(300, lambda: self.refresh_tree_from_disk(output_dir))
            return

        # ── Thành công ──
        decompile_msg = result.get("message", "")
        if "BadImageFormatException" in decompile_msg or "PE" in decompile_msg:
            self._apply_status_style(
                "warn",
                "⚠️ Khôi phục Metadata hoàn tất (chế độ PE). Xem báo cáo bên phải."
            )
        else:
            self._apply_status_style(
                "ok",
                f"✅ Hoàn tất! Đã trích xuất {result.get('files_count', 0)} tệp mã nguồn."
            )

        self.recovered_files = result.get("recovered_files", {})
        self.current_zip_path = result.get("zip_path")
        self.current_output_dir = result.get("output_dir")

        if self.current_output_dir:
            self.btn_export_zip.setEnabled(True)
            self.dll_manager.set_output_directory(self.current_output_dir)

        # Xây dựng cây thư mục trên giao diện
        self.populate_tree(self.recovered_files)
        self.search_widget.set_files(self.recovered_files)
        self.tabs.setCurrentIndex(0)

        # Tự động làm mới lại danh sách cây sau 500ms (để các file PE cũng xuất hiện)
        if output_dir:
            QTimer.singleShot(500, lambda: self.refresh_tree_from_disk(output_dir))

    def render_analysis_report(self, report: dict, output_dir: str = ""):
        """Hiển thị báo cáo phân tích tĩnh dạng HTML, bao gồm PE Section Entropy và Chuỗi giải mã."""
        if not report:
            self.report_viewer.setHtml("<p><i>Không có dữ liệu phân tích tĩnh.</i></p>")
            return

        import json
        target_file = report.get("target_file", "Unknown")
        size_kb = report.get("file_size_kb", 0)
        prot_info = report.get("protection_analysis", {})
        protections = prot_info.get("protections", ["Không phát hiện"])
        details = prot_info.get("details", {})
        strings_info = report.get("strings_analysis", {})
        pe_analysis = report.get("pe_analysis", {})

        urls = strings_info.get("detected_urls", [])
        ips = strings_info.get("detected_ips", [])
        samples = strings_info.get("sample_strings", [])

        prot_items = "".join(
            f'<li style="color: #DC2626; font-weight: bold;">{p}</li>'
            if any(k in p for k in ("Packer", "Obfuscator", "Virtualization", "Anti-"))
            else f'<li style="color: #16A34A;">{p}</li>'
            for p in protections
        )

        url_items = "".join(f"<li><a href='{u}'>{u}</a></li>" for u in urls[:25]) if urls else "<li><i>Không tìm thấy URL.</i></li>"
        ip_items = "".join(f"<li><code>{ip}</code></li>" for ip in ips[:25]) if ips else "<li><i>Không tìm thấy IP.</i></li>"
        samples_text = "\n".join(samples[:80])

        # ── 1. Bảng PE Sections & Entropy ──
        sections_html = ""
        sections = pe_analysis.get("sections", [])
        if sections:
            overall_ent = pe_analysis.get("overall_entropy", 0.0)
            ent_badge = (
                '<span style="background:#FEE2E2;color:#DC2626;padding:2px 6px;border-radius:4px;font-weight:bold;">⚠️ Mã hóa / Nén (Packed)</span>'
                if pe_analysis.get("has_high_entropy")
                else '<span style="background:#DCFCE7;color:#15803D;padding:2px 6px;border-radius:4px;font-weight:bold;">Bình thường</span>'
            )
            rows = []
            for sec in sections:
                is_p = sec.get("is_packed", False)
                bg = "#FEF2F2" if is_p else "#FFFFFF"
                color = "#DC2626" if is_p else "#15803D"
                rows.append(
                    f"<tr style='background:{bg};'>"
                    f"<td><b>{sec.get('name')}</b></td>"
                    f"<td><code>{sec.get('virtual_address')}</code></td>"
                    f"<td>{sec.get('virtual_size'):,} B</td>"
                    f"<td>{sec.get('raw_size'):,} B</td>"
                    f"<td><b>{sec.get('entropy'):.3f}</b></td>"
                    f"<td style='color:{color};font-weight:bold;'>{sec.get('status')}</td>"
                    f"</tr>"
                )
            sections_html = f"""
            <h3>🔬 Phân tích Cấu trúc Section & Entropy (Độ hỗn loạn)</h3>
            <p>Tổng Entropy tệp: <b>{overall_ent} / 8.0</b> &nbsp; {ent_badge}</p>
            <table border="1" cellpadding="6" cellspacing="0" style="border-collapse:collapse;width:100%;border-color:#CBD5E1;font-size:12px;">
                <tr style="background:#F1F5F9;text-align:left;">
                    <th>Tên Section</th><th>Virtual Address</th><th>Virtual Size</th><th>Raw Size</th><th>Entropy</th><th>Trạng thái</th>
                </tr>
                {"".join(rows)}
            </table>
            """

        # ── 2. Báo cáo Chuỗi đã giải mã từ strings_inventory.json ──
        inventory_html = ""
        if output_dir:
            inv_file = Path(output_dir) / "strings_inventory.json"
            if inv_file.is_file():
                try:
                    with open(inv_file, "r", encoding="utf-8") as f:
                        inv = json.load(f)
                    
                    dec_b64 = inv.get("total_decoded_base64", 0)
                    dec_bytes = inv.get("total_decoded_bytes", 0)
                    total_dec = dec_b64 + dec_bytes
                    samples_dec = inv.get("sample_decoded", [])
                    reg_keys = inv.get("registry_keys", [])
                    api_keys = inv.get("api_keys", [])

                    dec_rows = []
                    for item in samples_dec[:15]:
                        dec_rows.append(
                            f"<tr>"
                            f"<td>Line {item.get('line')}</td>"
                            f"<td><code>{item.get('raw')}</code></td>"
                            f"<td style='color:#1D4ED8;font-weight:bold;'>{item.get('decoded')}</td>"
                            f"</tr>"
                        )

                    dec_table = (
                        f"<table border='1' cellpadding='6' cellspacing='0' style='border-collapse:collapse;width:100%;border-color:#CBD5E1;font-size:12px;margin-top:8px;'>"
                        f"<tr style='background:#F1F5F9;text-align:left;'><th>Dòng</th><th>Dữ liệu gốc (Cipher/Hex)</th><th>Chuỗi đã giải mã (Plaintext)</th></tr>"
                        f"{''.join(dec_rows)}</table>"
                        if dec_rows else "<p><i>Không có mẫu giải mã.</i></p>"
                    )

                    reg_html = "".join(f"<li><code>{k}</code></li>" for k in reg_keys[:10]) if reg_keys else "<li><i>Không có</i></li>"
                    api_html = "".join(f"<li><code>{k}</code></li>" for k in api_keys[:10]) if api_keys else "<li><i>Không có</i></li>"

                    inventory_html = f"""
                    <h3>🔓 Chuỗi Đã Giải Mã & Chỉ Số IOCs Chuyên Sâu ({total_dec} chuỗi giải mã)</h3>
                    <p>Hệ thống đã tự động quét và chèn chú thích giải mã trực tiếp vào các tệp <code>.cs</code>.</p>
                    {dec_table}
                    <p style="margin-top:10px;"><b>Khóa Windows Registry phát hiện:</b></p>
                    <ul>{reg_html}</ul>
                    <p><b>API Keys / Secrets phát hiện:</b></p>
                    <ul>{api_html}</ul>
                    """
                except Exception:
                    pass

        html = f"""
        <div style="font-family: Segoe UI, sans-serif; color: #1E293B; line-height: 1.5;">
            <h2 style="color: #2563EB; margin-bottom: 5px;">📊 Báo cáo Phân tích Chuyên Sâu</h2>
            <hr style="border: 0; border-top: 1px solid #CBD5E1; margin-bottom: 15px;">

            <h3>📁 Thông tin tệp</h3>
            <ul>
                <li><b>Tên tệp:</b> <code>{target_file}</code></li>
                <li><b>Kích thước:</b> {size_kb} KB</li>
                <li><b>Định dạng nhận diện:</b> {details.get("format", "N/A")}</li>
                <li><b>Môi trường Runtime:</b> {details.get("runtime", "N/A")}</li>
                <li><b>Kiến trúc:</b> {pe_analysis.get("machine", "N/A")} ({'64-bit' if pe_analysis.get('is_64bit') else '32-bit'})</li>
            </ul>

            <h3>🛡️ Phát hiện Bảo vệ (Packer / Obfuscator)</h3>
            <ul>{prot_items}</ul>

            {sections_html}

            {inventory_html}

            <h3>🌐 Địa chỉ URL & IP phát hiện ({len(urls)} URLs, {len(ips)} IPs)</h3>
            <p><b>URLs:</b></p>
            <ul>{url_items}</ul>
            <p><b>IP Addresses:</b></p>
            <ul>{ip_items}</ul>

            <h3>📝 Mẫu chuỗi ký tự thô trích xuất (Strings Preview)</h3>
            <pre style="background-color: #F8FAFC; border: 1px solid #E2E8F0; padding: 10px; border-radius: 4px; font-size: 11px; max-height: 250px; overflow-y: auto;">{samples_text}</pre>
        </div>
        """
        self.report_viewer.setHtml(html)

    def on_error(self, err_msg: str):
        """Xử lý lỗi nghĩêm trọng từ worker (không hiện hộp thoại crash)."""
        self.btn_start.setEnabled(True)
        self.btn_select_file.setEnabled(True)
        self.btn_select_folder.setEnabled(True)
        self.progress_bar.setValue(0)
        self._apply_status_style(
            "error",
            f"❌ Lỗi xử lý: {err_msg[:120]}{'...' if len(err_msg) > 120 else ''}"
        )
        # Ghi chi tiết lỗi vào tab Phân tích thay vì hiện hộp thoại
        self.report_viewer.setHtml(
            f"""
            <div style="font-family:Segoe UI,sans-serif;color:#DC2626;padding:16px;">
                <h3>❌ Lỗi xử lý</h3>
                <pre style="background:#FEF2F2;border:1px solid #FECACA;
                           padding:12px;border-radius:6px;color:#7F1D1D;
                           white-space:pre-wrap;">{err_msg}</pre>
            </div>
            """
        )
        self.tabs.setCurrentIndex(1)

    # ---------------------------------------------------------
    # Cây thư mục & Phân loại Danh mục
    # ---------------------------------------------------------
    def populate_tree(self, files_dict: dict):
        self.file_tree.clear()
        self.lbl_tree.setText(f"📂 Cấu trúc ({len(files_dict)} tệp)")

        # Thống kê số lượng theo từng danh mục
        counts = {
            "all": len(files_dict),
            "csharp": 0,
            "cad": 0,
            "config": 0,
            "dll": 0,
            "media": 0,
        }

        cad_exts = {".lsp", ".fas", ".vlx", ".dcl", ".cui", ".cuix", ".mns", ".mnu", ".dwg", ".dxf"}
        config_exts = {".ini", ".cfg", ".conf", ".yaml", ".yml", ".properties", ".xml", ".json", ".xlsx", ".xls", ".xlsm", ".txt"}
        media_exts = {".png", ".jpg", ".jpeg", ".ico", ".bmp", ".wmf", ".gif"}

        for rel_path, full_path in files_dict.items():
            ext = Path(rel_path).suffix.lower()
            if ext in (".cs", ".csproj", ".sln"):
                counts["csharp"] += 1
            elif ext in cad_exts:
                counts["cad"] += 1
            elif ext in config_exts and not rel_path.endswith((".cs", ".java", ".py")):
                counts["config"] += 1
            elif ext in (".dll", ".exe", ".ocx"):
                counts["dll"] += 1
            elif ext in media_exts:
                counts["media"] += 1

            item = QTreeWidgetItem(self.file_tree, [rel_path])
            item.setData(0, Qt.ItemDataRole.UserRole, full_path)

        # Cập nhật số lượng trên các tab danh mục
        self.category_tabs.setTabText(0, f"📌 Tất cả ({counts['all']})")
        self.category_tabs.setTabText(1, f"💻 C# ({counts['csharp']})")
        self.category_tabs.setTabText(2, f"📐 CAD ({counts['cad']})")
        self.category_tabs.setTabText(3, f"⚙️ Data ({counts['config']})")
        self.category_tabs.setTabText(4, f"📦 DLL ({counts['dll']})")
        self.category_tabs.setTabText(5, f"🖼️ Media ({counts['media']})")

        # Áp dụng bộ lọc hiện tại
        self.filter_tree(self.txt_tree_filter.text())

    def on_category_changed(self, index: int):
        """Khi người dùng chuyển tab danh mục tệp -> Lọc lại cây tệp."""
        self.filter_tree(self.txt_tree_filter.text())

    def filter_tree(self, text: str = ""):
        """Lọc cây tệp kết hợp Danh mục (Category Tab) và Từ khóa tìm kiếm."""
        query = text.strip().lower()
        active_tab_idx = self.category_tabs.currentIndex()
        cat_key = self.category_keys[active_tab_idx] if 0 <= active_tab_idx < len(self.category_keys) else "all"

        cad_exts = {".lsp", ".fas", ".vlx", ".dcl", ".cui", ".cuix", ".mns", ".mnu", ".dwg", ".dxf"}
        config_exts = {".ini", ".cfg", ".conf", ".yaml", ".yml", ".properties", ".xml", ".json", ".xlsx", ".xls", ".xlsm", ".txt"}
        media_exts = {".png", ".jpg", ".jpeg", ".ico", ".bmp", ".wmf", ".gif"}

        root = self.file_tree.invisibleRootItem()
        visible_count = 0
        for i in range(root.childCount()):
            item = root.child(i)
            rel_name = item.text(0)
            ext = Path(rel_name).suffix.lower()

            # 1. Kiểm tra danh mục
            match_cat = True
            if cat_key == "csharp":
                match_cat = ext in (".cs", ".csproj", ".sln")
            elif cat_key == "cad":
                match_cat = ext in cad_exts
            elif cat_key == "config":
                match_cat = ext in config_exts and ext not in (".cs", ".java", ".py")
            elif cat_key == "dll":
                match_cat = ext in (".dll", ".exe", ".ocx")
            elif cat_key == "media":
                match_cat = ext in media_exts

            # 2. Kiểm tra từ khóa tìm kiếm
            match_query = not query or query in rel_name.lower()

            visible = match_cat and match_query
            item.setHidden(not visible)
            if visible:
                visible_count += 1

        self.lbl_tree.setText(f"📂 Cấu trúc ({visible_count}/{len(self.recovered_files)} tệp)")

    def refresh_tree_from_disk(self, output_dir: str):
        """Quét lại thư mục output từ đĩa để cập nhật cây thư mục sau khi xử lý xong."""
        self.current_output_dir = output_dir
        if hasattr(self, "dll_manager"):
            self.dll_manager.set_output_directory(output_dir)

        out_path = Path(output_dir)
        if not out_path.is_dir():
            return

        # Sắp xếp ưu tiên: mã nguồn (.java, .cs, .py, .xml, .lsp) và thư mục sources/ lên đầu
        # Các file ảnh (.png, .jpg, .webp, .wmf) và nhị phân (.so, .arsc, .dll) xuống cuối
        def sort_priority(item_path: Path):
            rel = str(item_path.relative_to(out_path)).replace("\\", "/")
            ext = item_path.suffix.lower()
            is_source_dir = rel.startswith("sources/") or "_decompiled" in rel
            is_code_ext = ext in (
                ".java", ".cs", ".py", ".xml", ".json", ".h", ".txt", ".asm",
                ".lsp", ".cui", ".cuix", ".ini", ".cfg", ".bat", ".cmd",
                ".csproj", ".sln", ".config"
            )
            is_binary = ext in (
                ".png", ".jpg", ".jpeg", ".webp", ".gif", ".ico", ".bmp", ".wmf",
                ".so", ".dex", ".arsc", ".dll", ".exe", ".dwg", ".dxf", ".xls", ".xlsx", ".xlsm"
            ) or rel.endswith(".9.png")
            if is_source_dir and is_code_ext:
                prio = 0
            elif is_code_ext:
                prio = 1
            elif not is_binary:
                prio = 2
            else:
                prio = 3
            return (prio, rel)

        all_files = sorted([f for f in out_path.rglob("*") if f.is_file()], key=sort_priority)
        fresh_files: dict = {}
        for f in all_files:
            rel = str(f.relative_to(out_path)).replace("\\", "/")
            fresh_files[rel] = str(f)

        if not fresh_files:
            return

        # Chỉ cập nhật khi có file mới hơn danh sách hiện tại
        if len(fresh_files) > len(self.recovered_files):
            self.recovered_files = fresh_files
            self.populate_tree(fresh_files)
            self.search_widget.set_files(fresh_files)
            count = len(fresh_files)
            self._apply_status_style(
                "ok",
                f"✅ Cây thư mục đã được làm mới – {count} tệp sẵn sàng."
            )
            # Tự động chọn file mã nguồn đầu tiên để hiển thị
            for idx in range(self.file_tree.topLevelItemCount()):
                item = self.file_tree.topLevelItem(idx)
                txt = item.text(0).lower()
                if txt.endswith((".java", ".cs", ".py", ".lsp", ".asm", ".h", ".c", ".txt")):
                    self.file_tree.setCurrentItem(item)
                    self.on_file_item_clicked(item, 0)
                    break

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
            if ext in [".cs", ".csproj", ".sln", ".config"]:
                lang = "csharp"
            elif ext == ".py":
                lang = "python"
            elif ext in [".asm"]:
                lang = "asm"
            elif ext in [".h", ".c", ".cpp"]:
                lang = "c"
            elif ext == ".java":
                lang = "java"
            elif ext in [".lsp", ".lisp"]:
                lang = "lisp"
            elif ext in [".xml", ".cui", ".cuix"]:
                lang = "xml"
            else:
                lang = "csharp"
            self.code_viewer.set_code(content, lang)
            self.code_viewer.go_to_line(line_no)
        except Exception as e:
            self.code_viewer.set_code(f"// Không thể đọc file: {str(e)}")

    def on_file_item_clicked(self, item: QTreeWidgetItem, column: int):
        full_path = item.data(0, Qt.ItemDataRole.UserRole)
        if full_path and os.path.isfile(full_path):
            self.lbl_current_file.setText(f"💻 Mã nguồn: {item.text(0)}")
            ext = Path(full_path).suffix.lower()
            
            # Kiểm tra nếu là file nhị phân / hình ảnh / tài nguyên CAD
            binary_exts = {
                ".png", ".jpg", ".jpeg", ".webp", ".gif", ".ico", ".bmp", ".wmf",
                ".so", ".dex", ".arsc", ".bin", ".dwg", ".dxf", ".xls", ".xlsx", ".xlsm"
            }
            if ext in binary_exts or full_path.endswith(".9.png"):
                self.code_viewer.set_code(
                    f"// =====================================================================\n"
                    f"// 🖼️ Tệp tài nguyên / dữ liệu: {Path(full_path).name}\n"
                    f"// Đường dẫn: {item.text(0)}\n"
                    f"// =====================================================================\n\n"
                    f"// Đây là tệp tài nguyên hoặc nhị phân (Ảnh, DWG CAD, bảng tính Excel...).\n"
                    f"// 👉 Để xem mã nguồn:\n"
                    f"// 1. Hãy bấm vào các tệp .cs trong thư mục '*_decompiled/' hoặc file kịch bản .lsp\n"
                    f"// 2. Hoặc gõ '.cs' hoặc '.lsp' vào ô '🔍 Lọc tệp theo tên...' ở góc trên bên trái.\n",
                    "csharp"
                )
                return

            # Kiểm tra nếu là DLL/EXE trong danh sách tệp
            if ext in {".dll", ".exe"}:
                stem = Path(full_path).stem
                self.code_viewer.set_code(
                    f"// =====================================================================\n"
                    f"// 📦 Module nhị phân: {Path(full_path).name}\n"
                    f"// Đường dẫn: {item.text(0)}\n"
                    f"// =====================================================================\n\n"
                    f"// Tệp này là thư viện liên kết động (.dll) được bóc tách từ gói SFX.\n"
                    f"// 👉 Mã nguồn C# đã được tự động dịch ngược sang thư mục:\n"
                    f"//    '{stem}_decompiled/' (tìm trong danh sách tệp bên trái)\n"
                    f"// 👉 Hoặc bạn có thể chọn trực tiếp file này để dịch ngược độc lập bằng nút 'Chọn tệp...'\n",
                    "csharp"
                )
                return

            try:
                with open(full_path, "r", encoding="utf-8", errors="ignore") as f:
                    content = f.read()
                ext = Path(full_path).suffix.lower()
                if ext in [".cs", ".csproj", ".sln", ".config"]:
                    lang = "csharp"
                elif ext == ".py":
                    lang = "python"
                elif ext in [".asm"]:
                    lang = "asm"
                elif ext in [".h", ".c", ".cpp"]:
                    lang = "c"
                elif ext == ".java":
                    lang = "java"
                elif ext in [".lsp", ".lisp"]:
                    lang = "lisp"
                elif ext in [".xml", ".cui", ".cuix"]:
                    lang = "xml"
                else:
                    lang = "csharp"
                self.code_viewer.set_code(content, lang)
            except Exception as e:
                self.code_viewer.set_code(f"// Không thể đọc file: {str(e)}")

    def on_dll_decompile_requested(self, dll_path: str):
        """Kích hoạt dịch ngược theo yêu cầu cho một DLL cụ thể."""
        if not os.path.isfile(dll_path):
            QMessageBox.warning(self, "Không tìm thấy", f"Không tìm thấy file: {dll_path}")
            return

        dll_name = Path(dll_path).name
        out_p = Path(self.current_output_dir or OUTPUT_DIR)
        target_src_dir = out_p / f"{Path(dll_path).stem}_decompiled"

        self._apply_status_style("info", f"⚡ Đang dịch ngược module .NET: {dll_name}...")
        self.progress_bar.setValue(35)
        QApplication.processEvents()

        from engines.dotnet_engine import DotNetDecompiler
        engine = DotNetDecompiler()
        res = engine.decompile(dll_path, str(target_src_dir))

        if res.get("success"):
            self.progress_bar.setValue(100)
            self._apply_status_style("ok", f"✅ Đã dịch ngược thành công module: {dll_name}")
            self.refresh_tree_from_disk(str(out_p))
            self.dll_manager.refresh()
            self.tabs.setCurrentIndex(0)
            QMessageBox.information(
                self,
                "Hoàn tất dịch ngược",
                f"Đã dịch ngược thành công module {dll_name}!\n\nMã nguồn C# đã được thêm vào cây thư mục:\n👉 {target_src_dir.name}/"
            )
        else:
            self._apply_status_style("error", f"❌ Dịch ngược thất bại: {res.get('message', '')}")
            QMessageBox.warning(
                self,
                "Thất bại",
                f"Không thể dịch ngược {dll_name}:\n{res.get('message', '')}"
            )

    def on_open_decompiled_source(self, decompiled_dir: str):
        """Chuyển sang Tab Mã nguồn và chọn file đầu tiên của module vừa chọn."""
        self.tabs.setCurrentIndex(0)
        p = Path(decompiled_dir)
        cs_files = list(p.rglob("*.cs"))
        if cs_files:
            self.category_tabs.setCurrentIndex(1)
            target_str = str(cs_files[0].resolve())
            for idx in range(self.file_tree.topLevelItemCount()):
                item = self.file_tree.topLevelItem(idx)
                if item.data(0, Qt.ItemDataRole.UserRole) == target_str:
                    self.file_tree.setCurrentItem(item)
                    self.on_file_item_clicked(item, 0)
                    break

    def export_zip(self):
        """Xuất toàn bộ mã nguồn và tài nguyên đã khôi phục sang file ZIP (hỗ trợ nén on-the-fly)."""
        out_dir = self.current_output_dir
        if not out_dir or not os.path.isdir(out_dir):
            if self.selected_file_path:
                stem = Path(self.selected_file_path).stem
                candidate = OUTPUT_DIR / f"{stem}_source"
                if candidate.is_dir():
                    out_dir = str(candidate.resolve())

        if not out_dir or not os.path.isdir(out_dir):
            QMessageBox.warning(self, "Chưa có dữ liệu", "Chưa có thư mục mã nguồn nào để xuất file ZIP.")
            return

        default_name = f"{Path(out_dir).name}.zip"
        save_dest, _ = QFileDialog.getSaveFileName(
            self,
            "Lưu file ZIP mã nguồn",
            default_name,
            "Zip Archive (*.zip)"
        )
        if not save_dest:
            return

        # 1. Nếu file ZIP đã được tạo sẵn và còn tồn tại trên đĩa -> copy nhanh
        if self.current_zip_path and os.path.isfile(self.current_zip_path):
            try:
                import shutil
                shutil.copy2(self.current_zip_path, save_dest)
                self._apply_status_style("ok", f"✅ Đã lưu file ZIP: {Path(save_dest).name}")
                QMessageBox.information(self, "Thành công", f"Đã lưu file ZIP tại:\n{save_dest}")
                return
            except Exception:
                pass

        # 2. Nếu chưa có hoặc file cũ bị xóa: tự động đóng gói on-the-fly ngay lập tức
        try:
            self._apply_status_style("info", "⏳ Đang đóng gói dữ liệu sang file ZIP...")
            QApplication.processEvents()
            from core.file_manager import FileManager
            FileManager.create_zip(out_dir, save_dest)
            self.current_zip_path = save_dest
            self._apply_status_style("ok", f"✅ Đã đóng gói và lưu ZIP thành công: {Path(save_dest).name}")
            QMessageBox.information(self, "Đã lưu", f"Đã đóng gói và lưu file ZIP thành công tại:\n{save_dest}")
        except Exception as e:
            self._apply_status_style("error", f"❌ Lỗi nén ZIP: {str(e)}")
            QMessageBox.critical(self, "Lỗi nén ZIP", f"Không thể tạo file ZIP: {str(e)}")
