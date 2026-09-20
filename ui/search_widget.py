import os
import re
from pathlib import Path
from typing import Dict, List
from PyQt6.QtCore import Qt, QThread, pyqtSignal
from PyQt6.QtWidgets import (
    QCheckBox,
    QHBoxLayout,
    QHeaderView,
    QLabel,
    QLineEdit,
    QPushButton,
    QTableWidget,
    QTableWidgetItem,
    QVBoxLayout,
    QWidget,
)

class SearchWorker(QThread):
    """Luồng tìm kiếm từ khóa ngầm trong tất cả các file mã nguồn."""

    match_found = pyqtSignal(dict)  # {"file_rel": str, "file_path": str, "line_no": int, "line_text": str}
    search_finished = pyqtSignal(int)  # total_matches

    def __init__(self, files_dict: Dict[str, str], query: str, is_case_sensitive: bool, is_regex: bool):
        super().__init__()
        self.files_dict = files_dict
        self.query = query
        self.is_case_sensitive = is_case_sensitive
        self.is_regex = is_regex
        self._is_cancelled = False

    def cancel(self):
        self._is_cancelled = True

    def run(self):
        if not self.query or not self.files_dict:
            self.search_finished.emit(0)
            return

        flags = 0 if self.is_case_sensitive else re.IGNORECASE
        try:
            if self.is_regex:
                pattern = re.compile(self.query, flags)
            else:
                pattern = re.compile(re.escape(self.query), flags)
        except Exception:
            self.search_finished.emit(0)
            return

        total_matches = 0

        for rel_path, full_path in self.files_dict.items():
            if self._is_cancelled:
                break
            if not os.path.isfile(full_path):
                continue

            try:
                with open(full_path, "r", encoding="utf-8", errors="ignore") as f:
                    for line_no, line in enumerate(f, start=1):
                        if self._is_cancelled:
                            break
                        if pattern.search(line):
                            total_matches += 1
                            self.match_found.emit({
                                "file_rel": rel_path,
                                "file_path": full_path,
                                "line_no": line_no,
                                "line_text": line.strip()[:150],
                            })
                            if total_matches >= 1000:
                                break
            except Exception:
                continue

        self.search_finished.emit(total_matches)


class GlobalSearchWidget(QWidget):
    """Widget tìm kiếm từ khóa toàn cục trong toàn bộ mã nguồn của dự án."""

    navigate_to_code = pyqtSignal(str, int)  # (file_path, line_number)

    def __init__(self, parent=None):
        super().__init__(parent)
        self.files_dict = {}
        self.search_worker = None

        layout = QVBoxLayout(self)
        layout.setContentsMargins(5, 5, 5, 5)
        layout.setSpacing(8)

        # 1. Khung nhập từ khóa & Tùy chọn
        search_bar = QHBoxLayout()
        self.txt_query = QLineEdit()
        self.txt_query.setPlaceholderText("🔍 Nhập từ khóa cần tìm (vd: License, SecretKey, Password, m_)...")
        self.txt_query.returnPressed.connect(self.start_search)
        search_bar.addWidget(self.txt_query)

        self.chk_case = QCheckBox("Phân biệt hoa/thường")
        search_bar.addWidget(self.chk_case)

        self.chk_regex = QCheckBox("Regex")
        search_bar.addWidget(self.chk_regex)

        self.btn_search = QPushButton("Tìm kiếm")
        self.btn_search.setStyleSheet("background-color: #2563EB; color: white; font-weight: bold; padding: 4px 12px;")
        self.btn_search.clicked.connect(self.start_search)
        search_bar.addWidget(self.btn_search)

        layout.addLayout(search_bar)

        self.lbl_result_count = QLabel("Nhập từ khóa và bấm 'Tìm kiếm' để tra cứu trong toàn bộ mã nguồn.")
        self.lbl_result_count.setStyleSheet("color: #64748B; font-size: 11px;")
        layout.addWidget(self.lbl_result_count)

        # 2. Bảng kết quả tìm kiếm
        self.table = QTableWidget()
        self.table.setColumnCount(3)
        self.table.setHorizontalHeaderLabels(["Tệp", "Dòng", "Nội dung"])
        self.table.horizontalHeader().setSectionResizeMode(0, QHeaderView.ResizeMode.Interactive)
        self.table.horizontalHeader().setSectionResizeMode(1, QHeaderView.ResizeMode.ResizeToContents)
        self.table.horizontalHeader().setSectionResizeMode(2, QHeaderView.ResizeMode.Stretch)
        self.table.setColumnWidth(0, 240)
        self.table.setSelectionBehavior(QTableWidget.SelectionBehavior.SelectRows)
        self.table.cellDoubleClicked.connect(self.on_row_double_clicked)
        layout.addWidget(self.table)

    def set_files(self, files_dict: Dict[str, str]):
        self.files_dict = files_dict

    def start_search(self):
        query = self.txt_query.text().strip()
        if not query or not self.files_dict:
            return

        if self.search_worker and self.search_worker.isRunning():
            self.search_worker.cancel()
            self.search_worker.wait()

        self.table.setRowCount(0)
        self.btn_search.setEnabled(False)
        self.lbl_result_count.setText(f"Đang tìm kiếm '{query}' trong {len(self.files_dict)} tệp...")

        self.search_worker = SearchWorker(
            self.files_dict,
            query,
            self.chk_case.isChecked(),
            self.chk_regex.isChecked(),
        )
        self.search_worker.match_found.connect(self.add_result_row)
        self.search_worker.search_finished.connect(self.on_search_finished)
        self.search_worker.start()

    def add_result_row(self, match: dict):
        row = self.table.rowCount()
        self.table.insertRow(row)

        item_file = QTableWidgetItem(match["file_rel"])
        item_file.setData(Qt.ItemDataRole.UserRole, match["file_path"])
        self.table.setItem(row, 0, item_file)

        item_line = QTableWidgetItem(str(match["line_no"]))
        item_line.setTextAlignment(Qt.AlignmentFlag.AlignCenter)
        self.table.setItem(row, 1, item_line)

        item_text = QTableWidgetItem(match["line_text"])
        self.table.setItem(row, 2, item_text)

    def on_search_finished(self, total_count: int):
        self.btn_search.setEnabled(True)
        suffix = " (Giới hạn hiển thị 1000 kết quả đầu tiên)" if total_count >= 1000 else ""
        self.lbl_result_count.setText(f"Tìm thấy {total_count} kết quả phù hợp.{suffix} Nhấp đúp vào dòng để nhảy tới code.")

    def on_row_double_clicked(self, row: int, column: int):
        item_file = self.table.item(row, 0)
        item_line = self.table.item(row, 1)
        if item_file and item_line:
            file_path = item_file.data(Qt.ItemDataRole.UserRole)
            line_no = int(item_line.text())
            self.navigate_to_code.emit(file_path, line_no)
