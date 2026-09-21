import os
from pathlib import Path
from typing import Dict, List, Optional
from PyQt6.QtCore import Qt, pyqtSignal
from PyQt6.QtGui import QColor, QFont
from PyQt6.QtWidgets import (
    QWidget, QVBoxLayout, QHBoxLayout, QLabel, QTableWidget,
    QTableWidgetItem, QPushButton, QHeaderView, QMessageBox
)

from core.detector import FileDetector


class DLLManagerWidget(QWidget):
    """
    Widget chuyên sâu quản lý và kiểm tra các thư viện liên kết động (.DLL / .EXE):
    - Liệt kê toàn bộ module trong thư mục kết quả.
    - Phân loại .NET Assembly hay Native PE.
    - Kiểm tra trạng thái đã dịch ngược C# hay chưa.
    - Nút bấm kích hoạt dịch ngược tức thì cho từng DLL theo yêu cầu.
    """

    decompile_requested = pyqtSignal(str)   # Gửi đường dẫn dll_path cần dịch ngược
    open_source_requested = pyqtSignal(str) # Nhảy tới thư mục/file mã nguồn đã dịch

    def __init__(self, parent=None):
        super().__init__(parent)
        self.output_dir: Optional[str] = None
        self.dll_items: List[Dict[str, str]] = []
        self._init_ui()

    def _init_ui(self):
        layout = QVBoxLayout(self)
        layout.setContentsMargins(8, 8, 8, 8)
        layout.setSpacing(8)

        # Header thông tin
        header_layout = QHBoxLayout()
        self.lbl_info = QLabel("📦 Danh sách Module & Thư viện nhị phân (.DLL)")
        self.lbl_info.setStyleSheet("font-weight: bold; font-size: 13px; color: #1E293B;")
        header_layout.addWidget(self.lbl_info)

        header_layout.addStretch()

        self.btn_refresh = QPushButton("🔄 Quét lại")
        self.btn_refresh.setStyleSheet(
            "padding: 4px 12px; font-weight: 500; background-color: #F1F5F9; border: 1px solid #CBD5E1; border-radius: 4px;"
        )
        self.btn_refresh.clicked.connect(self.refresh)
        header_layout.addWidget(self.btn_refresh)

        layout.addLayout(header_layout)

        # Hướng dẫn nhanh
        lbl_hint = QLabel(
            "💡 Mẹo: Bạn có thể bấm '⚡ Dịch ngược' để bóc tách mã nguồn C# cho bất kỳ DLL nào bên dưới."
        )
        lbl_hint.setStyleSheet("color: #64748B; font-size: 11px;")
        layout.addWidget(lbl_hint)

        # Bảng danh sách DLL
        self.table = QTableWidget()
        self.table.setColumnCount(5)
        self.table.setHorizontalHeaderLabels([
            "Tên Module", "Kích thước", "Kiến trúc / Loại", "Trạng thái C#", "Thao tác"
        ])
        header = self.table.horizontalHeader()
        header.setSectionResizeMode(0, QHeaderView.ResizeMode.Stretch)
        header.setSectionResizeMode(1, QHeaderView.ResizeMode.ResizeToContents)
        header.setSectionResizeMode(2, QHeaderView.ResizeMode.ResizeToContents)
        header.setSectionResizeMode(3, QHeaderView.ResizeMode.ResizeToContents)
        header.setSectionResizeMode(4, QHeaderView.ResizeMode.Fixed)
        self.table.setColumnWidth(4, 130)
        self.table.setAlternatingRowColors(True)
        self.table.setStyleSheet(
            """
            QTableWidget {
                background-color: #FFFFFF;
                border: 1px solid #E2E8F0;
                border-radius: 4px;
                gridline-color: #F1F5F9;
            }
            QHeaderView::section {
                background-color: #F8FAFC;
                font-weight: bold;
                padding: 6px;
                border: none;
                border-bottom: 1px solid #E2E8F0;
            }
            """
        )
        layout.addWidget(self.table)

    def set_output_directory(self, output_dir: str):
        """Nạp thư mục output và tự động quét toàn bộ DLL."""
        self.output_dir = output_dir
        self.refresh()

    def refresh(self):
        """Quét lại toàn bộ các file DLL và cập nhật bảng."""
        if not self.output_dir or not Path(self.output_dir).is_dir():
            self.table.setRowCount(0)
            self.lbl_info.setText("📦 Danh sách Module & Thư viện nhị phân (0 module)")
            return

        out_p = Path(self.output_dir)
        dll_files = sorted(
            [f for f in out_p.rglob("*") if f.is_file() and f.suffix.lower() in (".dll", ".exe")],
            key=lambda x: x.stat().st_size,
            reverse=True
        )

        self.table.setRowCount(len(dll_files))
        self.lbl_info.setText(f"📦 Danh sách Module & Thư viện nhị phân ({len(dll_files)} module)")

        for row, f in enumerate(dll_files):
            size_kb = f.stat().st_size / 1024
            size_str = f"{size_kb / 1024:.2f} MB" if size_kb > 1024 else f"{size_kb:.1f} KB"

            is_dotnet = FileDetector.is_dotnet_assembly(str(f))
            type_str = ".NET Assembly (C#)" if is_dotnet else "Native Windows PE"

            # Kiểm tra xem đã có thư mục decompiled tương ứng chưa
            decompiled_dir = out_p / f"{f.stem}_decompiled"
            is_decompiled = decompiled_dir.is_dir() and any(decompiled_dir.glob("*.cs"))

            # Cột 0: Tên Module
            item_name = QTableWidgetItem(f.name)
            item_name.setToolTip(str(f.resolve()))
            if is_dotnet:
                item_name.setFont(QFont("Segoe UI", 9, QFont.Weight.DemiBold))
            self.table.setItem(row, 0, item_name)

            # Cột 1: Kích thước
            item_size = QTableWidgetItem(size_str)
            item_size.setTextAlignment(Qt.AlignmentFlag.AlignRight | Qt.AlignmentFlag.AlignVCenter)
            self.table.setItem(row, 1, item_size)

            # Cột 2: Loại
            item_type = QTableWidgetItem(type_str)
            if is_dotnet:
                item_type.setForeground(QColor("#0284C7")) # Xanh dương
            else:
                item_type.setForeground(QColor("#64748B")) # Xám
            self.table.setItem(row, 2, item_type)

            # Cột 3: Trạng thái C#
            if is_decompiled:
                item_status = QTableWidgetItem("✅ Đã dịch ngược")
                item_status.setForeground(QColor("#16A34A"))
            elif is_dotnet:
                item_status = QTableWidgetItem("⏳ Chưa dịch")
                item_status.setForeground(QColor("#D97706"))
            else:
                item_status = QTableWidgetItem("— (C++ Native)")
                item_status.setForeground(QColor("#94A3B8"))
            self.table.setItem(row, 3, item_status)

            # Cột 4: Nút thao tác
            btn_action = QPushButton()
            btn_action.setFixedHeight(26)
            if is_decompiled:
                btn_action.setText("📁 Xem mã nguồn")
                btn_action.setStyleSheet(
                    "background-color: #F0FDF4; color: #16A34A; border: 1px solid #BBF7D0; border-radius: 3px; font-size: 11px;"
                )
                btn_action.clicked.connect(lambda _, d=str(decompiled_dir): self.open_source_requested.emit(d))
            elif is_dotnet:
                btn_action.setText("⚡ Dịch ngược")
                btn_action.setStyleSheet(
                    "background-color: #EFF6FF; color: #2563EB; font-weight: bold; border: 1px solid #BFDBFE; border-radius: 3px; font-size: 11px;"
                )
                btn_action.clicked.connect(lambda _, p=str(f.resolve()): self.decompile_requested.emit(p))
            else:
                btn_action.setText("🔍 Phân tích PE")
                btn_action.setStyleSheet(
                    "background-color: #F8FAFC; color: #64748B; border: 1px solid #E2E8F0; border-radius: 3px; font-size: 11px;"
                )
                btn_action.clicked.connect(lambda _, p=str(f.resolve()): self.decompile_requested.emit(p))

            self.table.setCellWidget(row, 4, btn_action)
