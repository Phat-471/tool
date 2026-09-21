import os
import sys
from pathlib import Path

# Kiểm tra xem ứng dụng đang chạy dưới dạng đóng gói PyInstaller hay mã nguồn Python
IS_FROZEN = getattr(sys, "frozen", False)

if IS_FROZEN:
    # Khi chạy từ file .exe: Thư mục chứa file .exe thực tế
    APP_DIR = Path(sys.executable).resolve().parent
    BUNDLE_DIR = Path(getattr(sys, "_MEIPASS", APP_DIR))
else:
    # Khi chạy dev từ mã nguồn
    APP_DIR = Path(__file__).resolve().parent
    BUNDLE_DIR = APP_DIR

BASE_DIR = APP_DIR

# Các thư mục làm việc mặc định (luôn nằm cạnh file .exe trên máy người dùng)
UPLOADS_DIR = APP_DIR / "uploads"
OUTPUT_DIR = APP_DIR / "output"

# Thư mục tools: ưu tiên tools cạnh file .exe, sau đó đến _internal/tools hoặc bundle
TOOLS_DIR = APP_DIR / "tools"
if not TOOLS_DIR.exists():
    if (APP_DIR / "_internal" / "tools").exists():
        TOOLS_DIR = APP_DIR / "_internal" / "tools"
    elif (BUNDLE_DIR / "tools").exists():
        TOOLS_DIR = BUNDLE_DIR / "tools"

# Danh sách định dạng file được hỗ trợ
SUPPORTED_EXTENSIONS = {
    ".dll": "C# / .NET Assembly",
    ".exe": "Windows Executable (.NET / Python / Native)",
    ".apk": "Android Application Package",
    ".pyc": "Compiled Python Bytecode",
    ".jar": "Java Archive",
}

# Cấu hình kích thước file tối đa (MB)
MAX_FILE_SIZE_MB = 500

# Tạo tự động các thư mục cần thiết khi khởi động
for directory in [UPLOADS_DIR, OUTPUT_DIR, TOOLS_DIR]:
    directory.mkdir(parents=True, exist_ok=True)
