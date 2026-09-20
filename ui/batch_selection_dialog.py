from typing import Any, Dict, List
from PyQt6.QtCore import Qt
from PyQt6.QtWidgets import (
    QCheckBox,
    QDialog,
    QDialogButtonBox,
    QHBoxLayout,
    QHeaderView,
    QLabel,
    QPushButton,
    QTableWidget,
    QTableWidgetItem,
    QVBoxLayout,
    QWidget,
)


class BatchSelectionDialog(QDialog):
    """Hộp thoại xem trước và chọn các file trong thư mục cài đặt cần dịch ngược."""

    def __init__(self, scan_result: Dict[str, Any], parent=None):
        super().__init__(parent)
        self.scan_result = scan_result
        self.all_items: List[Dict[str, Any]] = (
            scan_result.get("target_files", [])
            + scan_result.get("framework_files", [])
            + scan_result.get("other_binaries", [])
        )
        self.selected_files: List[Dict[str, Any]] = []

        self.init_ui()

    def init_ui(self):
        folder_name = self.scan_result.get("folder_name", "Thư mục")
        total = self.scan_result.get("total_found", 0)
        target_count = len(self.scan_result.get("target_files", []))
        fw_count = len(self.scan_result.get("framework_files", []))

        self.setWindowTitle(f"📁 Quét Thư Mục: {folder_name} ({total} tệp)")
        self.resize(850, 520)

        layout = QVBoxLayout(self)
        layout.setSpacing(10)

        # 1. Tiêu đề & Tóm tắt
        header_lbl = QLabel(
            f"<h3>📁 Đã quét thư mục: <code>{folder_name}</code></h3>"
            f"<p>Tìm thấy <b>{total}</b> tệp nhị phân: "
            f"<span style='color: #1D4ED8; font-weight: bold;'>🎯 {target_count} tệp ứng dụng chính</span> | "
            f"<span style='color: #64748B;'>⚙️ {fw_count} thư viện chuẩn hệ thống (đã bỏ chọn sẵn)</span>"
            f"</p>"
        )
        layout.addWidget(header_lbl)

        # 2. Thanh nút thao tác nhanh
        btn_layout = QHBoxLayout()

        self.btn_select_targets = QPushButton("🎯 Chỉ chọn mã nguồn ứng dụng (Khuyến nghị)")
        self.btn_select_targets.setStyleSheet("font-weight: bold; color: #1D4ED8; padding: 5px 12px;")
        self.btn_select_targets.clicked.connect(self.select_targets_only)
        btn_layout.addWidget(self.btn_select_targets)

        self.btn_select_all = QPushButton("✅ Chọn tất cả")
        self.btn_select_all.clicked.connect(self.select_all)
        btn_layout.addWidget(self.btn_select_all)

        self.btn_deselect_all = QPushButton("❌ Bỏ chọn tất cả")
        self.btn_deselect_all.clicked.connect(self.deselect_all)
        btn_layout.addWidget(self.btn_deselect_all)

        btn_layout.addStretch()
        layout.addLayout(btn_layout)

        # 3. Bảng danh sách tệp
        self.table = QTableWidget()
        self.table.setColumnCount(5)
        self.table.setHorizontalHeaderLabels([
            "Chọn", "Tên tệp (File)", "Kích thước", "Định dạng", "Phát hiện Bảo vệ"
        ])
        self.table.horizontalHeader().setSectionResizeMode(1, QHeaderView.ResizeMode.Stretch)
        self.table.horizontalHeader().setSectionResizeMode(3, QHeaderView.ResizeMode.ResizeToContents)
        self.table.setRowCount(len(self.all_items))

        for row, item in enumerate(self.all_items):
            # Checkbox
            chk_item = QTableWidgetItem()
            chk_item.setFlags(Qt.ItemFlag.ItemIsUserCheckable | Qt.ItemFlag.ItemIsEnabled)
            chk_item.setCheckState(Qt.CheckState.Checked if item.get("selected") else Qt.CheckState.Unchecked)
            self.table.setItem(row, 0, chk_item)

            # Tên tệp
            name_text = item.get("rel_path", item.get("filename"))
            name_item = QTableWidgetItem(name_text)
            if item.get("is_obfuscated"):
                name_item.setForeground(Qt.GlobalColor.red)
            elif not item.get("is_framework"):
                name_item.setForeground(Qt.GlobalColor.darkBlue)
            else:
                name_item.setForeground(Qt.GlobalColor.gray)
            self.table.setItem(row, 1, name_item)

            # Kích thước
            size_item = QTableWidgetItem(f"{item.get('size_kb')} KB")
            size_item.setTextAlignment(Qt.AlignmentFlag.AlignRight | Qt.AlignmentFlag.AlignVCenter)
            self.table.setItem(row, 2, size_item)

            # Định dạng
            fmt_item = QTableWidgetItem(item.get("file_type", ""))
            self.table.setItem(row, 3, fmt_item)

            # Bảo vệ
            obf = item.get("obf_name") or ("Thư viện chuẩn" if item.get("is_framework") else "Mã nguồn sạch")
            prot_item = QTableWidgetItem(obf)
            if item.get("is_obfuscated"):
                prot_item.setForeground(Qt.GlobalColor.red)
            self.table.setItem(row, 4, prot_item)

        layout.addWidget(self.table)

        # 4. Nút bấm Xác nhận / Hủy
        bottom_layout = QHBoxLayout()
        self.lbl_selected_count = QLabel(f"Đã chọn: {target_count} tệp")
        self.lbl_selected_count.setStyleSheet("font-weight: bold;")
        bottom_layout.addWidget(self.lbl_selected_count)

        bottom_layout.addStretch()

        self.btn_cancel = QPushButton("Hủy bỏ")
        self.btn_cancel.clicked.connect(self.reject)
        bottom_layout.addWidget(self.btn_cancel)

        self.btn_start = QPushButton("🚀 Bắt đầu dịch ngược hàng loạt")
        self.btn_start.setStyleSheet(
            "background-color: #2563EB; color: white; font-weight: bold; padding: 8px 18px; border-radius: 4px;"
        )
        self.btn_start.clicked.connect(self.accept_selection)
        bottom_layout.addWidget(self.btn_start)

        layout.addLayout(bottom_layout)

        # Cập nhật số lượng khi người dùng click checkbox
        self.table.itemChanged.connect(self.update_count)

    def select_targets_only(self):
        self.table.blockSignals(True)
        for row, item in enumerate(self.all_items):
            chk = self.table.item(row, 0)
            if item.get("is_obfuscated") or not item.get("is_framework"):
                chk.setCheckState(Qt.CheckState.Checked)
            else:
                chk.setCheckState(Qt.CheckState.Unchecked)
        self.table.blockSignals(False)
        self.update_count()

    def select_all(self):
        self.table.blockSignals(True)
        for row in range(self.table.rowCount()):
            self.table.item(row, 0).setCheckState(Qt.CheckState.Checked)
        self.table.blockSignals(False)
        self.update_count()

    def deselect_all(self):
        self.table.blockSignals(True)
        for row in range(self.table.rowCount()):
            self.table.item(row, 0).setCheckState(Qt.CheckState.Unchecked)
        self.table.blockSignals(False)
        self.update_count()

    def update_count(self):
        count = sum(
            1 for row in range(self.table.rowCount())
            if self.table.item(row, 0) and self.table.item(row, 0).checkState() == Qt.CheckState.Checked
        )
        self.lbl_selected_count.setText(f"Đã chọn: {count} tệp")

    def accept_selection(self):
        self.selected_files = []
        for row, item in enumerate(self.all_items):
            chk = self.table.item(row, 0)
            if chk and chk.checkState() == Qt.CheckState.Checked:
                self.selected_files.append(item)
        self.accept()
