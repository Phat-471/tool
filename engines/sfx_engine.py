import os
import shutil
from pathlib import Path
from typing import Any, Dict, List, Optional

from engines.base import BaseDecompiler
from core.sfx_extractor import SFXExtractor
from core.file_manager import FileManager


class SFXDecompilerEngine(BaseDecompiler):
    """
    Engine chuyên xử lý các tệp thực thi tự giải nén (SFX Archive / Installer Wrapper):
    1. Tự động bóc tách toàn bộ kho lưu trữ nhúng (WinRAR SFX, 7-Zip SFX, Zip SFX).
    2. Khôi phục toàn bộ cây thư mục gốc và tài nguyên (LISP, DWG, CUI, DLL, PNG, Config...).
    3. Tự động nhận diện các Module .NET chính và kích hoạt ILSpy/de4dot dịch ngược
       sang mã nguồn C# (.cs) trong thư mục decompiled_source/.
    """

    def __init__(self):
        super().__init__("SFX Archive Extractor & Cascade Decompiler")

    def is_available(self) -> bool:
        return True

    def get_executable_path(self) -> Optional[str]:
        return SFXExtractor.get_unrar_executable() or "Built-in Zip/SFX Engine"

    def decompile(self, input_path: str, output_dir: str, **kwargs) -> Dict[str, Any]:
        out_p = Path(output_dir)
        out_p.mkdir(parents=True, exist_ok=True)

        # 1. Bóc tách kho lưu trữ SFX
        res = SFXExtractor.extract(input_path, out_p)
        if not res.get("success"):
            return {
                "success": False,
                "message": res.get("message", "Bóc tách SFX không thành công."),
                "output_dir": str(out_p.resolve()),
            }

        total_extracted = res.get("total_extracted", 0)
        dotnet_assemblies = res.get("dotnet_assemblies", [])
        payload_dir = Path(res.get("payload_dir", str(out_p)))

        # 2. Tìm kiếm và dịch ngược module .NET chính (nếu có)
        decompiled_modules = []
        if dotnet_assemblies:
            from core.detector import FileDetector
            from engines.dotnet_engine import DotNetDecompiler

            # Sắp xếp ưu tiên: Module của ứng dụng chính lên trước (không phải 3rd party vendor)
            candidates = []
            vendor_keywords = ["bouncycastle", "itextsharp", "uglytoad", "pdfium", "newtonsoft", "microsoft", "system."]
            for asm_path in dotnet_assemblies:
                if FileDetector.is_dotnet_assembly(asm_path):
                    sz = Path(asm_path).stat().st_size
                    name_lower = Path(asm_path).name.lower()
                    is_vendor = 1 if any(vk in name_lower for vk in vendor_keywords) else 0
                    candidates.append((is_vendor, -sz, asm_path))

            candidates.sort(key=lambda x: (x[0], x[1]))

            # Dịch ngược module .NET chính hàng đầu (tối đa 2 module quan trọng nhất)
            dotnet_engine = DotNetDecompiler()
            for _, _, target_asm in candidates[:2]:
                asm_name = Path(target_asm).name
                target_src_dir = out_p / f"{Path(target_asm).stem}_decompiled"
                try:
                    dec_res = dotnet_engine.decompile(target_asm, str(target_src_dir))
                    if dec_res.get("success"):
                        decompiled_modules.append(asm_name)
                except Exception:
                    pass

        # 3. Tạo tài liệu hướng dẫn tổng quan khôi phục
        guide_file = out_p / "HUONG_DAN_KHOI_PHUC.txt"
        try:
            with open(guide_file, "w", encoding="utf-8") as f_g:
                f_g.write("=================================================================\n")
                f_g.write("KẾT QUẢ KHÔI PHỤC MÃ NGUỒN TỪ TỆP THỰC THI (SFX ARCHIVE)\n")
                f_g.write("=================================================================\n\n")
                f_g.write(f"1. Tổng số tệp đã khôi phục: {total_extracted} tệp\n")
                f_g.write(f"2. Danh sách tệp bao gồm:\n")
                f_g.write("   - Kịch bản AutoLISP (*.lsp)\n")
                f_g.write("   - Menu giao diện CAD (*.cui, *.cuix)\n")
                f_g.write("   - Hình vẽ, biểu tượng WMF/BMP/Icon (*.wmf, *.ico, *.png)\n")
                f_g.write("   - Bảng tính Excel mẫu & dữ liệu cấu hình (*.xlsx, *.ini, *.cfg)\n")
                f_g.write("   - Các thư viện liên kết động (*.dll)\n\n")
                if decompiled_modules:
                    f_g.write("3. Các Module .NET cốt lõi đã được dịch ngược sang mã nguồn C# (.cs):\n")
                    for dm in decompiled_modules:
                        f_g.write(f"   👉 Thư mục: {Path(dm).stem}_decompiled/\n")
                f_g.write("\n4. Hướng dẫn dịch ngược các Module khác:\n")
                f_g.write("   - Bạn có thể chọn trực tiếp bất kỳ tệp .dll nào trong thư mục này\n")
                f_g.write("     để dịch ngược độc lập bằng nút 'Chọn tệp...'\n")
                f_g.write("   - Hoặc bấm 'Chọn thư mục...' để dịch ngược hàng loạt toàn bộ DLL song song.\n")
                f_g.write("=================================================================\n")
        except Exception:
            pass

        cascade_msg = ""
        if decompiled_modules:
            cascade_msg = f" + Đã dịch ngược C# cho: {', '.join(decompiled_modules)}"

        return {
            "success": True,
            "output_dir": str(out_p.resolve()),
            "message": (
                f"✅ Đã khôi phục {total_extracted} tệp từ {res.get('sfx_type')}{cascade_msg}."
            ),
            "total_extracted": total_extracted,
            "payload_dir": str(payload_dir),
            "decompiled_modules": decompiled_modules,
        }
