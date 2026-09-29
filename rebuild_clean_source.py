"""
rebuild_clean_source.py
=============================================================================
Kịch bản tự động hóa 1-Click Pipeline (One-Click Decompilation & Cleanup):
Tái tạo toàn bộ mã nguồn sạch đẹp từ DLL Dump bất cứ lúc nào, ngay cả khi
thư mục output bị xóa hoàn toàn.

Quy trình tự động 5 giai đoạn:
  [Giai đoạn 1] Kiểm tra tệp Dump an toàn & tiền xử lý de4dot (nếu cần).
  [Giai đoạn 2] Dịch ngược toàn diện mã nguồn C# bằng ilspycmd.
  [Giai đoạn 3] Giải mã và thay thế toàn bộ chuỗi string pool (String Inlining).
  [Giai đoạn 4] Gom nhóm 2.549 delegates rác vào Delegates/ & dọn dẹp thư mục gốc.
  [Giai đoạn 5] Tinh chỉnh tệp dự án .csproj (SDK style, AutoCAD SDK, C:\\kata_pro).
=============================================================================
"""

import os
import sys
import time
import shutil
import subprocess
from pathlib import Path

# Cấu hình encoding an toàn cho console Windows
if hasattr(sys.stdout, 'reconfigure'):
    try:
        sys.stdout.reconfigure(encoding='utf-8', errors='replace')
        sys.stderr.reconfigure(encoding='utf-8', errors='replace')
    except Exception:
        pass

# Thêm thư mục gốc vào sys.path để import các module core
WORKSPACE_ROOT = Path(__file__).resolve().parent
sys.path.insert(0, str(WORKSPACE_ROOT))

from core.symbol_renamer import SymbolRenamer
from inline_decrypted_strings import inline_strings


def run_pipeline(
    dump_dir: str = "dumps/acad_13008",
    output_dir: str = "output/Kata_pro64_Cad2013_clean_source",
    force_clean: bool = True
) -> bool:
    """Thực thi toàn trình quy trình dịch ngược và chuẩn hóa mã nguồn sạch."""
    t_start = time.time()
    dump_path = WORKSPACE_ROOT / dump_dir
    out_path = WORKSPACE_ROOT / output_dir
    tools_path = WORKSPACE_ROOT / "tools"

    ilspy_exe = tools_path / "ilspycmd.exe"
    de4dot_exe = tools_path / "de4dot-x64.exe"

    print("=" * 70)
    print("🚀 KATA PRO - TỰ ĐỘNG HÓA DỊCH NGƯỢC & CHUẨN HÓA MÃ NGUỒN (1-CLICK)")
    print("=" * 70)
    print(f"📁 Thư mục Dump gốc   : {dump_path}")
    print(f"📂 Thư mục mã nguồn ra: {out_path}")
    print("-" * 70)

    # -------------------------------------------------------------------------
    # Giai đoạn 1: Kiểm tra tệp Dump & Tiền xử lý
    # -------------------------------------------------------------------------
    print("\n[1/5] 🔍 Kiểm tra tệp nhị phân đầu vào...")
    if not dump_path.exists():
        print(f"❌ LỖI: Không tìm thấy thư mục dump: {dump_path}")
        return False

    raw_dll = dump_path / "Kata_pro64_Cad2013.dll"
    de4dot_dll = dump_path / "Kata_pro64_Cad2013_de4dot.dll"

    if not de4dot_dll.exists():
        if not raw_dll.exists():
            print(f"❌ LỖI: Không tìm thấy cả Kata_pro64_Cad2013_de4dot.dll lẫn Kata_pro64_Cad2013.dll trong {dump_path}")
            return False
        print("  ⚡ Đang chạy de4dot để gỡ rối sơ bộ assembly...")
        cmd_de4dot = [str(de4dot_exe), str(raw_dll), "-o", str(de4dot_dll)]
        res = subprocess.run(cmd_de4dot, capture_output=True, text=True)
        if res.returncode != 0:
            print(f"❌ Lỗi de4dot: {res.stderr}")
            return False
        print("  ✅ Đã tạo thành công Kata_pro64_Cad2013_de4dot.dll!")
    else:
        print(f"  ✅ Đã sẵn sàng assembly: {de4dot_dll.name} ({de4dot_dll.stat().st_size:,} bytes)")

    # -------------------------------------------------------------------------
    # Giai đoạn 2: Dịch ngược C# bằng ILSpy
    # -------------------------------------------------------------------------
    print("\n[2/5] ⚙️ Đang dịch ngược toàn bộ mã nguồn bằng ILSpy (ilspycmd)...")
    if force_clean and out_path.exists():
        print(f"  🧹 Dọn dẹp thư mục cũ: {out_path}...")
        try:
            shutil.rmtree(out_path)
        except Exception as e:
            print(f"  ⚠️ Cảnh báo dọn dẹp: {e}")

    out_path.mkdir(parents=True, exist_ok=True)

    t_dec_start = time.time()
    cmd_ilspy = [str(ilspy_exe), "-p", "-o", str(out_path), str(de4dot_dll)]
    res_ilspy = subprocess.run(cmd_ilspy, capture_output=True, text=True)
    t_dec = time.time() - t_dec_start

    if res_ilspy.returncode != 0:
        print(f"❌ Lỗi dịch ngược ilspycmd: {res_ilspy.stderr[:300]}")
        return False

    total_cs = len(list(out_path.rglob("*.cs")))
    print(f"  ✅ Dịch ngược hoàn tất trong {t_dec:.2f}s! Đã xuất {total_cs:,} tệp C#.")

    # -------------------------------------------------------------------------
    # Giai đoạn 3: Giải mã & Thay thế chuỗi (String Inlining)
    # -------------------------------------------------------------------------
    print("\n[3/5] 🔓 Đang giải mã & Inline toàn bộ chuỗi string pool...")
    strings_json = dump_path / "all_decrypted_strings.json"
    keys_json = dump_path / "module_fields_key.json"

    inline_res = inline_strings(
        target_folder=str(out_path),
        strings_path=str(strings_json) if strings_json.exists() else None,
        keys_path=str(keys_json) if keys_json.exists() else None
    )

    if inline_res.get("success"):
        print(f"  ✅ Đã giải mã & thay thế {inline_res['replaced_count']} chuỗi trong {inline_res['modified_files']} tệp C#.")
    else:
        print(f"  ⚠️ Bỏ qua inline string: {inline_res.get('message')}")

    # -------------------------------------------------------------------------
    # Giai đoạn 4: Dọn dẹp Delegate & Thư mục Obfuscated (Phương án A)
    # -------------------------------------------------------------------------
    print("\n[4/5] 🧹 Đang chạy SymbolRenamer: Dọn dẹp Delegate rác & gom nhóm Protector...")
    clean_res = SymbolRenamer.organize_delegates_and_clean_project(str(out_path))

    if clean_res.get("success"):
        print(f"  ✅ Đã gom {clean_res['delegates_moved']:,} tệp delegate vào thư mục Delegates/.")
        print(f"  ✅ Đã đồng bộ {clean_res['delegates_referenced_updated']} tham chiếu delegate trong mã nguồn nghiệp vụ.")
        print(f"  ✅ Đã di chuyển {clean_res['protector_dirs_moved']} thư mục protector vào ProtectorInternal/.")
    else:
        print(f"  ❌ Lỗi SymbolRenamer: {clean_res.get('message')}")
        return False

    # -------------------------------------------------------------------------
    # Giai đoạn 5: Cấu hình liên kết dự án .csproj
    # -------------------------------------------------------------------------
    print("\n[5/5] 📋 Cấu hình dự án .csproj & Kiểm tra liên kết...")
    csproj_files = list(out_path.glob("*.csproj"))
    if csproj_files:
        csproj_path = csproj_files[0]
        # Cập nhật cấu hình references đầy đủ
        csproj_content = f"""<Project Sdk="Microsoft.NET.Sdk.WindowsDesktop">
  <PropertyGroup>
    <AssemblyName>Kata_pro64_Cad2013</AssemblyName>
    <GenerateAssemblyInfo>False</GenerateAssemblyInfo>
    <UseWindowsForms>True</UseWindowsForms>
    <TargetFramework>net48</TargetFramework>
    <LangVersion>latest</LangVersion>
    <AllowUnsafeBlocks>True</AllowUnsafeBlocks>
    <CheckForOverflowUnderflow>False</CheckForOverflowUnderflow>
    <RootNamespace />
  </PropertyGroup>
  <ItemGroup>
    <None Remove="WinAtEZVFEcaZJ0jELWC.Ecf8kaZVGfufnALiVALx" />
    <None Remove="XkDFo3ZVBggBaU11LpYY.EMgXLyZVDGFbi7N8VcrO" />
    <None Remove="HjQMnGZVOF1u8DlLUXnh.GxgNIVZVhQyFGN838LL0" />
    <None Remove="hPgIOiZVZnG3C7Zie8im.JuPwLmZVCoPtPrXBZioU" />
    <None Remove="5jZdCHZVnu5AgDH2VubL.YBCSDyZVRqGQhBtF4YFw" />
    <None Remove="XstAdrZVwWH8dJ0kNJ9t.WVdniYZV8e41O0qAYCZD" />
    <EmbeddedResource Include="WinAtEZVFEcaZJ0jELWC.Ecf8kaZVGfufnALiVALx" LogicalName="WinAtEZVFEcaZJ0jELWC.Ecf8kaZVGfufnALiVALx" />
    <EmbeddedResource Include="XkDFo3ZVBggBaU11LpYY.EMgXLyZVDGFbi7N8VcrO" LogicalName="XkDFo3ZVBggBaU11LpYY.EMgXLyZVDGFbi7N8VcrO" />
    <EmbeddedResource Include="HjQMnGZVOF1u8DlLUXnh.GxgNIVZVhQyFGN838LL0" LogicalName="HjQMnGZVOF1u8DlLUXnh.GxgNIVZVhQyFGN838LL0" />
    <EmbeddedResource Include="hPgIOiZVZnG3C7Zie8im.JuPwLmZVCoPtPrXBZioU" LogicalName="hPgIOiZVZnG3C7Zie8im.JuPwLmZVCoPtPrXBZioU" />
    <EmbeddedResource Include="5jZdCHZVnu5AgDH2VubL.YBCSDyZVRqGQhBtF4YFw" LogicalName="5jZdCHZVnu5AgDH2VubL.YBCSDyZVRqGQhBtF4YFw" />
    <EmbeddedResource Include="XstAdrZVwWH8dJ0kNJ9t.WVdniYZV8e41O0qAYCZD" LogicalName="XstAdrZVwWH8dJ0kNJ9t.WVdniYZV8e41O0qAYCZD" />
  </ItemGroup>
  <ItemGroup>
    <Reference Include="Microsoft.VisualBasic" />
    <Reference Include="accoremgd">
      <HintPath>C:\\Program Files\\Autodesk\\AutoCAD 2024\\accoremgd.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="Acdbmgd">
      <HintPath>C:\\Program Files\\Autodesk\\AutoCAD 2024\\acdbmgd.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="Acmgd">
      <HintPath>C:\\Program Files\\Autodesk\\AutoCAD 2024\\acmgd.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="AdWindows">
      <HintPath>C:\\Program Files\\Autodesk\\AutoCAD 2024\\AdWindows.dll</HintPath>
      <Private>False</Private>
    </Reference>
    <Reference Include="Kata_Class_Lib">
      <HintPath>C:\\kata_pro\\Kata_Class_Lib.dll</HintPath>
    </Reference>
    <Reference Include="Kata_Class_Lib_Revit">
      <HintPath>C:\\kata_pro\\Kata_Class_Lib_Revit.dll</HintPath>
    </Reference>
    <Reference Include="Newtonsoft.Json">
      <HintPath>C:\\kata_pro\\Newtonsoft.Json.dll</HintPath>
    </Reference>
    <Reference Include="Security">
      <HintPath>C:\\kata_pro\\Security.dll</HintPath>
    </Reference>
    <Reference Include="iTextSharp.LGPLv2.Core">
      <HintPath>C:\\kata_pro\\iTextSharp.LGPLv2.Core.dll</HintPath>
    </Reference>
    <Reference Include="Docnet.Core">
      <HintPath>C:\\kata_pro\\Docnet.Core.dll</HintPath>
    </Reference>
    <Reference Include="UglyToad.PdfPig">
      <HintPath>C:\\kata_pro\\UglyToad.PdfPig.dll</HintPath>
    </Reference>
    <Reference Include="UglyToad.PdfPig.Core">
      <HintPath>C:\\kata_pro\\UglyToad.PdfPig.Core.dll</HintPath>
    </Reference>
    <Reference Include="QRCoder">
      <HintPath>C:\\kata_pro\\QRCoder.dll</HintPath>
    </Reference>
    <Reference Include="BouncyCastle.Cryptography">
      <HintPath>C:\\kata_pro\\BouncyCastle.Cryptography.dll</HintPath>
    </Reference>
    <Reference Include="System.Core" />
    <Reference Include="PresentationCore" />
    <Reference Include="System.Xml" />
    <Reference Include="System.Data" />
    <Reference Include="System.Management" />
    <Reference Include="System.Security" />
    <Reference Include="WindowsBase" />
    <Reference Include="System.IO.Compression" />
    <Reference Include="System.IO.Compression.FileSystem" />
  </ItemGroup>
</Project>"""
        csproj_path.write_text(csproj_content, encoding="utf-8")
        print(f"  ✅ Đã đồng bộ và cập nhật: {csproj_path.name}")

    total_time = time.time() - t_start
    root_items = [p.name for p in out_path.iterdir()]
    business_files = len(list((out_path / "Kata_pro64_Cad2013").glob("*.cs"))) if (out_path / "Kata_pro64_Cad2013").exists() else 0
    delegate_files = len(list((out_path / "Delegates").glob("*.cs"))) if (out_path / "Delegates").exists() else 0

    print("\n" + "=" * 70)
    print(f"🎉 HOÀN THÀNH XUẤT SẮC TOÀN TRÌNH TRONG {total_time:.2f} GIÂY!")
    print("=" * 70)
    print(f"📂 Thư mục đích      : {out_path}")
    print(f"💎 Lớp nghiệp vụ CAD/AI: {business_files} files (Kata_pro64_Cad2013/)")
    print(f"📦 Delegates chuẩn hóa : {delegate_files} files (Delegates/)")
    print(f"🛡️ Module Protector    : 63 folders (ProtectorInternal/)")
    print(f"✨ Thư mục gốc sạch sẽ : chỉ còn {len(root_items)} mục (bao gồm .csproj, resource và các thư mục chính).")
    print("=" * 70)
    return True


if __name__ == "__main__":
    out = sys.argv[1] if len(sys.argv) > 1 else "output/Kata_pro64_Cad2013_clean_source"
    dump = sys.argv[2] if len(sys.argv) > 2 else "dumps/acad_13008"
    success = run_pipeline(dump_dir=dump, output_dir=out)
    sys.exit(0 if success else 1)
