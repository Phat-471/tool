# -*- mode: python ; coding: utf-8 -*-
import os
import sys
from pathlib import Path

block_cipher = None

BASE_DIR = os.path.abspath(os.getcwd())

# Danh sách dữ liệu đóng gói kèm
datas = [
    (os.path.join(BASE_DIR, "tools"), "tools"),
    (os.path.join(BASE_DIR, "assets"), "assets"),
]

# Hidden imports cần thiết cho toàn bộ kiến trúc ứng dụng
hidden_imports = [
    "pefile",
    "PyQt6",
    "PyQt6.QtCore",
    "PyQt6.QtGui",
    "PyQt6.QtWidgets",
    "core",
    "core.analyzer",
    "core.detector",
    "core.file_manager",
    "core.batch_scanner",
    "core.obfuscator_detector",
    "core.pe_inspector",
    "core.string_decryptor",
    "core.sfx_extractor",
    "core.pyinstaller_extractor",
    "core.disassembler",
    "core.solution_generator",
    "engines",
    "engines.base",
    "engines.sfx_engine",
    "engines.dotnet_engine",
    "engines.native_engine",
    "engines.python_engine",
    "engines.java_engine",
    "ui",
    "ui.main_window",
    "ui.code_viewer",
    "ui.worker_thread",
    "ui.batch_worker",
    "ui.batch_selection_dialog",
    "ui.search_widget",
    "config",
    "zlib",
    "struct",
    "marshal",
    "dis",
    "zipfile",
]

# Loại bỏ các thư viện AI / Data Science khổng lồ không sử dụng để tối ưu tốc độ và dung lượng build
excludes = [
    "torch",
    "torchvision",
    "torchaudio",
    "scipy",
    "matplotlib",
    "pandas",
    "numpy",
    "sympy",
    "qiskit",
    "qrisp",
    "IPython",
    "jupyter",
    "notebook",
    "cv2",
    "PIL",
    "tkinter",
    "streamlit",
    "playwright",
    "selenium",
]

icon_path = os.path.join(BASE_DIR, "assets", "app_icon.ico")
if not os.path.isfile(icon_path):
    icon_path = None

a = Analysis(
    ["main.py"],
    pathex=[BASE_DIR],
    binaries=[],
    datas=datas,
    hiddenimports=hidden_imports,
    hookspath=[],
    hooksconfig={},
    runtime_hooks=[],
    excludes=excludes,
    win_no_prefer_redirects=False,
    win_private_assemblies=False,
    cipher=block_cipher,
    noarchive=False,
)

pyz = PYZ(a.pure, a.zipped_data, cipher=block_cipher)

exe = EXE(
    pyz,
    a.scripts,
    [],
    exclude_binaries=True,
    name="CodeRecoveryStudio",
    debug=False,
    bootloader_ignore_signals=False,
    strip=False,
    upx=True,
    console=False,
    disable_windowed_traceback=False,
    argv_emulation=False,
    target_arch=None,
    codesign_identity=None,
    entitlements_file=None,
    icon=icon_path,
)

coll = COLLECT(
    exe,
    a.binaries,
    a.zipfiles,
    a.datas,
    strip=False,
    upx=True,
    upx_exclude=[],
    name="CodeRecoveryStudio",
)
