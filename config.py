import os
from pathlib import Path

# Thư mục gốc của dự án
BASE_DIR = Path(__file__).resolve().parent

# Các thư mục làm việc mặc định
UPLOADS_DIR = BASE_DIR / "uploads"
OUTPUT_DIR = BASE_DIR / "output"
TOOLS_DIR = BASE_DIR / "tools"

# Danh sách định dạng file được hỗ trợ
SUPPORTED_EXTENSIONS = {
    ".dll": "C# / .NET Assembly",
    ".apk": "Android Application Package",
    ".pyc": "Compiled Python Bytecode",
    ".jar": "Java Archive",
}

# Cấu hình kích thước file tối đa (MB)
MAX_FILE_SIZE_MB = 200

# Tạo tự động các thư mục cần thiết khi khởi động
for directory in [UPLOADS_DIR, OUTPUT_DIR, TOOLS_DIR]:
    directory.mkdir(parents=True, exist_ok=True)
