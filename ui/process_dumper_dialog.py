import os
from pathlib import Path
from typing import Any, Dict, List, Optional
from PyQt6.QtCore import Qt, QThread, pyqtSignal
from PyQt6.QtGui import QColor, QFont
from PyQt6.QtWidgets import (
    QCheckBox,
    QDialog,
    QFileDialog,
    QGroupBox,
    QHBoxLayout,
    QHeaderView,
    QLabel,
    QLineEdit,
    QMessageBox,
    QProgressBar,
    QPushButton,
    QSplitter,
    QTableWidget,
    QTableWidgetItem,
    QVBoxLayout,
    QWidget,
)

from config import OUTPUT_DIR
from core.process_dumper import ProcessDumper


class DumpWorker(QThread):
    """Luồng xử lý ngầm quét và dump bộ nhớ không làm đơ giao diện."""

    progress_updated = pyqtSignal(int, str)
    finished = pyqtSignal(dict)
    error_occurred = pyqtSignal(str)

    def __init__(self, pid: int, output_dir: str, keyword: str, only_dotnet: bool):
        super().__init__()
        self.pid = pid
        self.output_dir = output_dir
        self.keyword = keyword
        self.only_dotnet = only_dotnet

    def run(self):
        try:
            self.progress_updated.emit(10, f"Đang kết nối và đọc không gian bộ nhớ của PID {self.pid}...")
            report = ProcessDumper.scan_and_dump_all(
                pid=self.pid,
                output_dir=self.output_dir,
                keyword=self.keyword,
                only_dotnet=self.only_dotnet
            )
            self.progress_updated.emit(100, "Hoàn tất trích xuất từ RAM!")
            self.finished.emit(report)
        except Exception as e:
            self.error_occurred.emit(str(e))


class ProcessDumperDialog(QDialog):
    """Hộp thoại trích xuất DLL .NET từ bộ nhớ RAM của tiến trình CAD đang chạy."""

    dump_and_decompile_requested = pyqtSignal(str)  # Gửi đường dẫn file DLL đã dump để dịch ngược ngay

    def __init__(self, parent=None):
        super().__init__(parent)
        self.setWindowTitle("🎯 Trích xuất DLL đã giải mã từ RAM (Process Memory Dumper)")
        self.resize(850, 600)
        self.selected_pid: Optional[int] = None
        self.selected_proc_name: str = ""
        self.all_processes: List[Dict[str, Any]] = []

        self.init_ui()
        self.refresh_processes()

    def init_ui(self):
        layout = QVBoxLayout(self)
        layout.setSpacing(10)
        layout.setContentsMargins(15, 15, 15, 15)

        # 1. Hướng dẫn & Mô tả
        header_box = QGroupBox("💡 Giải pháp triệt để cho ConfuserEx Anti-Tamper / JIT Encryption")
        header_layout = QVBoxLayout(header_box)
        lbl_info = QLabel(
            "Khi chạy trong AutoCAD, các module Kata Pro sẽ tự động giải mã 100% ruột hàm (CIL bytecode) vào RAM.<br>"
            "Công cụ này quét trực tiếp bộ nhớ của AutoCAD (<code>acad.exe</code>), tái cấu trúc PE layout và xuất ra các tệp <code>.dll</code> "
            "<b>đã được giải mã hoàn toàn</b> để dịch ngược đầy đủ không bị rỗng thân hàm."
        )
        lbl_info.setWordWrap(True)
        lbl_info.setStyleSheet("color: #334155; line-height: 1.4;")
        header_layout.addWidget(lbl_info)
        layout.addWidget(header_box)

        # 2. Thanh lọc tiến trình & Nút làm mới
        filter_layout = QHBoxLayout()
        self.txt_filter = QLineEdit()
        self.txt_filter.setPlaceholderText("🔍 Lọc tiến trình (nhập 'acad', 'kata', 'revit' hoặc PID)...")
        self.txt_filter.textChanged.connect(self.filter_processes)
        filter_layout.addWidget(self.txt_filter)

        self.btn_refresh = QPushButton("🔄 Làm mới")
        self.btn_refresh.setFixedWidth(100)
        self.btn_refresh.clicked.connect(self.refresh_processes)
        filter_layout.addWidget(self.btn_refresh)
        layout.addLayout(filter_layout)

        # 3. Bảng danh sách tiến trình
        self.proc_table = QTableWidget()
        self.proc_table.setColumnCount(5)
        self.proc_table.setHorizontalHeaderLabels(["PID", "Tên tiến trình", "Loại ứng dụng", "RAM (MB)", "Đường dẫn thực thi"])
        self.proc_table.horizontalHeader().setSectionResizeMode(0, QHeaderView.ResizeMode.ResizeToContents)
        self.proc_table.horizontalHeader().setSectionResizeMode(1, QHeaderView.ResizeMode.ResizeToContents)
        self.proc_table.horizontalHeader().setSectionResizeMode(2, QHeaderView.ResizeMode.ResizeToContents)
        self.proc_table.horizontalHeader().setSectionResizeMode(3, QHeaderView.ResizeMode.ResizeToContents)
        self.proc_table.horizontalHeader().setSectionResizeMode(4, QHeaderView.ResizeMode.Stretch)
        self.proc_table.setSelectionBehavior(QTableWidget.SelectionBehavior.SelectRows)
        self.proc_table.setSelectionMode(QTableWidget.SelectionMode.SingleSelection)
        self.proc_table.itemSelectionChanged.connect(self.on_process_selected)
        layout.addWidget(self.proc_table)

        # 4. Tùy chọn Dump
        opt_group = QGroupBox("⚙️ Tùy chọn trích xuất module từ RAM")
        opt_layout = QVBoxLayout(opt_group)
        opt_layout.setSpacing(8)

        self.chk_only_dotnet = QCheckBox("Chỉ lấy module .NET (Bỏ qua các thư viện C++ native)")
        self.chk_only_dotnet.setChecked(True)
        opt_layout.addWidget(self.chk_only_dotnet)

        kw_layout = QHBoxLayout()
        lbl_kw = QLabel("Từ khóa module cần lấy:")
        lbl_kw.setFixedWidth(150)
        kw_layout.addWidget(lbl_kw)

        self.txt_keyword = QLineEdit()
        self.txt_keyword.setPlaceholderText("Nhập từ khóa như 'Kata', hoặc để trống để lấy hết...")
        self.txt_keyword.setText("Kata")
        self.txt_keyword.setStyleSheet("padding: 4px 8px; font-weight: 500;")
        kw_layout.addWidget(self.txt_keyword)
        opt_layout.addLayout(kw_layout)

        layout.addWidget(opt_group)

        # 5. Thanh tiến trình & Trạng thái
        self.progress_bar = QProgressBar()
        self.progress_bar.setValue(0)
        self.progress_bar.setFixedHeight(14)
        self.progress_bar.setTextVisible(False)
        layout.addWidget(self.progress_bar)

        self.lbl_status = QLabel("Trạng thái: Vui lòng chọn tiến trình AutoCAD hoặc .NET để bắt đầu.")
        self.lbl_status.setStyleSheet("color: #64748B; font-weight: 500;")
        layout.addWidget(self.lbl_status)

        # 6. Các nút hành động
        btn_layout = QHBoxLayout()
        btn_layout.addStretch()

        self.btn_cancel = QPushButton("Đóng")
        self.btn_cancel.clicked.connect(self.reject)
        btn_layout.addWidget(self.btn_cancel)

        self.btn_dump_folder = QPushButton("📁 Dump sang thư mục...")
        self.btn_dump_folder.setEnabled(False)
        self.btn_dump_folder.clicked.connect(self.start_dump_to_folder)
        btn_layout.addWidget(self.btn_dump_folder)

        self.btn_dump_and_decompile = QPushButton("🚀 Dump & Dịch ngược ngay")
        self.btn_dump_and_decompile.setEnabled(False)
        self.btn_dump_and_decompile.setStyleSheet(
            """
            QPushButton {
                background-color: #2563EB;
                color: white;
                font-weight: bold;
                padding: 8px 16px;
                border-radius: 4px;
            }
            QPushButton:hover {
                background-color: #1D4ED8;
            }
            QPushButton:disabled {
                background-color: #94A3B8;
            }
            """
        )
        self.btn_dump_and_decompile.clicked.connect(self.start_dump_and_decompile)
        btn_layout.addWidget(self.btn_dump_and_decompile)

        layout.addLayout(btn_layout)

    def refresh_processes(self):
        """Quét và làm mới danh sách tiến trình trên Windows."""
        self.lbl_status.setText("Đang quét danh sách tiến trình...")
        self.all_processes = ProcessDumper.list_running_processes()
        self.populate_process_table(self.all_processes)
        self.filter_processes(self.txt_filter.text())

    def populate_process_table(self, procs: List[Dict[str, Any]]):
        self.proc_table.setRowCount(0)
        auto_select_row = -1

        for row_idx, p in enumerate(procs):
            self.proc_table.insertRow(row_idx)

            pid_item = QTableWidgetItem(str(p["pid"]))
            pid_item.setData(Qt.ItemDataRole.UserRole, p["pid"])

            name_item = QTableWidgetItem(p["name"])
            desc_item = QTableWidgetItem(p["desc"])
            mem_item = QTableWidgetItem(f"{p['mem_mb']} MB")
            exe_item = QTableWidgetItem(p["exe"])

            if p.get("has_kata"):
                # Nổi bật màu xanh lục cho tiến trình đang nạp Kata Pro
                highlight_bg = QColor("#ECFDF5")
                for itm in (pid_item, name_item, desc_item, mem_item, exe_item):
                    itm.setBackground(highlight_bg)

                name_item.setForeground(QColor("#047857"))
                desc_item.setForeground(QColor("#047857"))
                font = name_item.font()
                font.setBold(True)
                name_item.setFont(font)
                desc_item.setFont(font)
                if auto_select_row == -1:
                    auto_select_row = row_idx

            elif p["is_cad"]:
                name_item.setForeground(Qt.GlobalColor.darkBlue)
                font = name_item.font()
                font.setBold(True)
                name_item.setFont(font)
                if auto_select_row == -1:
                    auto_select_row = row_idx

            self.proc_table.setItem(row_idx, 0, pid_item)
            self.proc_table.setItem(row_idx, 1, name_item)
            self.proc_table.setItem(row_idx, 2, desc_item)
            self.proc_table.setItem(row_idx, 3, mem_item)
            self.proc_table.setItem(row_idx, 4, exe_item)

        if auto_select_row != -1:
            self.proc_table.selectRow(auto_select_row)
            best_proc = procs[auto_select_row]
            if best_proc.get("has_kata"):
                self.lbl_status.setText(f"🌟 Đã phát hiện AutoCAD đang nạp Kata Pro: {best_proc['name']} (PID: {best_proc['pid']})")
                self.lbl_status.setStyleSheet("color: #047857; font-weight: bold;")
            else:
                self.lbl_status.setText(f"Đã tự động chọn tiến trình CAD: {best_proc['name']} (PID: {best_proc['pid']})")
                self.lbl_status.setStyleSheet("color: #1D4ED8; font-weight: 500;")
        else:
            self.lbl_status.setText(f"Đã tải {len(procs)} tiến trình. Vui lòng chọn tiến trình cần dump.")
            self.lbl_status.setStyleSheet("color: #64748B; font-weight: 500;")

    def filter_processes(self, query: str):
        q = query.strip().lower()
        visible_count = 0
        for row in range(self.proc_table.rowCount()):
            pid_str = self.proc_table.item(row, 0).text()
            name = self.proc_table.item(row, 1).text().lower()
            desc = self.proc_table.item(row, 2).text().lower()
            exe = self.proc_table.item(row, 4).text().lower()
            match = (
                (not q)
                or (q in name)
                or (q in desc)
                or (q in exe)
                or (q in pid_str)
                or (q in "autocad" and "acad" in name)
                or (q in "acad" and "autocad" in desc)
            )
            self.proc_table.setRowHidden(row, not match)
            if match:
                visible_count += 1

    def on_process_selected(self):
        selected_rows = self.proc_table.selectedItems()
        if not selected_rows:
            self.selected_pid = None
            self.btn_dump_folder.setEnabled(False)
            self.btn_dump_and_decompile.setEnabled(False)
            return

        row = selected_rows[0].row()
        pid_item = self.proc_table.item(row, 0)
        name_item = self.proc_table.item(row, 1)

        self.selected_pid = int(pid_item.text())
        self.selected_proc_name = name_item.text()
        self.btn_dump_folder.setEnabled(True)
        self.btn_dump_and_decompile.setEnabled(True)
        self.lbl_status.setText(f"Đã chọn: {self.selected_proc_name} (PID: {self.selected_pid}). Sẵn sàng trích xuất.")

    def start_dump_to_folder(self):
        if not self.selected_pid:
            return

        default_dir = str(OUTPUT_DIR / f"dumped_{self.selected_proc_name}_{self.selected_pid}")
        target_dir = QFileDialog.getExistingDirectory(self, "Chọn thư mục lưu DLL trích xuất", default_dir)
        if not target_dir:
            return

        self._run_dump_worker(target_dir, auto_decompile=False)

    def start_dump_and_decompile(self):
        if not self.selected_pid:
            return

        target_dir = str(OUTPUT_DIR / f"dumped_{self.selected_proc_name}_{self.selected_pid}")
        self._run_dump_worker(target_dir, auto_decompile=True)

    def _run_dump_worker(self, output_dir: str, auto_decompile: bool):
        self.btn_dump_folder.setEnabled(False)
        self.btn_dump_and_decompile.setEnabled(False)
        self.btn_refresh.setEnabled(False)
        self.progress_bar.setValue(15)

        self.auto_decompile_on_finish = auto_decompile
        self.worker = DumpWorker(
            pid=self.selected_pid,
            output_dir=output_dir,
            keyword=self.txt_keyword.text().strip(),
            only_dotnet=self.chk_only_dotnet.isChecked()
        )
        self.worker.progress_updated.connect(lambda pct, msg: self._update_progress(pct, msg))
        self.worker.finished.connect(self.on_dump_finished)
        self.worker.error_occurred.connect(self.on_dump_error)
        self.worker.start()

    def _update_progress(self, pct: int, msg: str):
        self.progress_bar.setValue(pct)
        self.lbl_status.setText(f"⏳ [{pct}%] {msg}")

    def on_dump_finished(self, report: dict):
        self.btn_dump_folder.setEnabled(True)
        self.btn_dump_and_decompile.setEnabled(True)
        self.btn_refresh.setEnabled(True)
        self.progress_bar.setValue(100)

        dumped = report.get("dumped_files", [])
        out_dir = report.get("output_dir", "")

        if not dumped:
            QMessageBox.warning(
                self,
                "Không tìm thấy Module",
                f"Đã quét {report.get('total_scanned_regions', 0)} vùng nhớ nhưng không tìm thấy module .NET nào khớp từ khóa.\n"
                "Gợi ý: Hãy đảm bảo bạn đã mở tính năng Kata Pro trong AutoCAD trước khi bấm Dump."
            )
            self.lbl_status.setText("⚠️ Không tìm thấy module nào phù hợp.")
            return

        summary = f"Đã trích xuất thành công {len(dumped)} module DLL từ RAM vào:\n{out_dir}"
        self.lbl_status.setText(f"✅ Hoàn tất! Đã trích xuất {len(dumped)} module.")

        if self.auto_decompile_on_finish:
            # Chọn module mục tiêu quan trọng nhất (ưu tiên có chữ Kata_pro64_Cad2013 hoặc Kata)
            target_dll = None
            for d in dumped:
                if "kata_pro64_cad2013" in d["name"].lower():
                    target_dll = d["path"]
                    break
            if not target_dll and dumped:
                target_dll = dumped[0]["path"]

            if target_dll and os.path.isfile(target_dll):
                self.accept()
                self.dump_and_decompile_requested.emit(target_dll)
                return

        QMessageBox.information(self, "Trích xuất hoàn tất", summary)
        if os.path.isdir(out_dir):
            os.startfile(out_dir)

    def on_dump_error(self, err_msg: str):
        self.btn_dump_folder.setEnabled(True)
        self.btn_dump_and_decompile.setEnabled(True)
        self.btn_refresh.setEnabled(True)
        self.progress_bar.setValue(0)
        self.lbl_status.setText(f"❌ Lỗi: {err_msg}")
        QMessageBox.critical(self, "Lỗi trích xuất RAM", f"Không thể dump bộ nhớ: {err_msg}")
