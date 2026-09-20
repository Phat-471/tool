from abc import ABC, abstractmethod
from typing import Dict, Any, Optional

class BaseDecompiler(ABC):
    """Lớp cơ sở trừu tượng cho tất cả các Decompiler Engine."""

    def __init__(self, name: str):
        self.name = name

    @abstractmethod
    def is_available(self) -> bool:
        """Kiểm tra công cụ thực thi có sẵn trong máy hoặc thư mục tools/ không."""
        pass

    @abstractmethod
    def get_executable_path(self) -> Optional[str]:
        """Trả về đường dẫn tới file thực thi của công cụ."""
        pass

    @abstractmethod
    def decompile(self, input_path: str, output_dir: str, **kwargs) -> Dict[str, Any]:
        """
        Thực hiện dịch ngược tệp đầu vào và lưu mã nguồn vào output_dir.
        
        Trả về dict:
            {
                "success": bool,
                "output_dir": str,
                "message": str,
                "stdout": str,
                "stderr": str
            }
        """
        pass
