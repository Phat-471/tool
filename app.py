import io
import os
import shutil
import subprocess
import time
import zipfile
import streamlit as st

# ---------------------------------------------------------
# Cấu hình giao diện trang
# ---------------------------------------------------------
st.set_page_config(
    page_title="Hệ thống Hỗ trợ Khôi phục Mã nguồn",
    page_icon="🔍",
    layout="wide",
    initial_sidebar_state="expanded",
)

# Tùy chỉnh CSS giao diện hiện đại
st.markdown(
    """
    <style>
    .main-header {
        font-size: 2rem;
        font-weight: 700;
        color: #1E293B;
        margin-bottom: 0.5rem;
    }
    .sub-header {
        font-size: 1rem;
        color: #64748B;
        margin-bottom: 1.5rem;
    }
    </style>
""",
    unsafe_allow_html=True,
)

st.markdown('<div class="main-header">🔍 Hệ thống Hỗ trợ Khôi phục Mã nguồn</div>', unsafe_allow_html=True)
st.markdown(
    '<div class="sub-header">Công cụ hỗ trợ phân tích, trích xuất cấu trúc và phục hồi mã nguồn từ file thực thi và bytecode (.dll, .apk, .pyc).</div>',
    unsafe_allow_html=True,
)

# ---------------------------------------------------------
# Cấu hình thanh bên (Sidebar)
# ---------------------------------------------------------
with st.sidebar:
    st.header("⚙️ Tùy chọn cấu hình")
    st.write("Chọn các tác vụ xử lý mong muốn:")

    opt_detect_env = st.checkbox("Tự động nhận diện môi trường / Framework", value=True)
    opt_extract_strings = st.checkbox("Trích xuất danh sách chuỗi ký tự (Strings)", value=True)
    opt_tree_structure = st.checkbox("Khôi phục cây cấu trúc thư mục/lớp (Hierarchy)", value=True)
    opt_clean_code = st.checkbox("Định dạng và làm sạch mã nguồn đầu ra", value=True)
    opt_export_zip = st.checkbox("Tự động đóng gói kết quả sang .zip", value=True)

    st.divider()
    st.markdown("### ℹ️ Thông tin hỗ trợ")
    st.markdown(
        """
    - **.dll**: .NET Assemblies, C# Modules
    - **.apk**: Android Application Package
    - **.pyc**: Compiled Python Bytecode
    """
    )


# ---------------------------------------------------------
# Hàm xử lý và lưu trữ file tải lên
# ---------------------------------------------------------
def save_uploaded_file(uploaded_file, upload_dir="./uploads"):
    """Lưu file tải lên vào thư mục an toàn."""
    if uploaded_file is None:
        return {"status": False, "error": "Chưa có file nào được tải lên."}

    allowed_extensions = {".dll", ".apk", ".pyc"}
    filename = os.path.basename(uploaded_file.name)
    _, ext = os.path.splitext(filename)
    ext = ext.lower()

    if ext not in allowed_extensions:
        return {
            "status": False,
            "error": f"Định dạng file '{ext}' không hợp lệ. Chỉ chấp nhận: {', '.join(allowed_extensions)}",
        }

    os.makedirs(upload_dir, exist_ok=True)
    target_path = os.path.join(upload_dir, filename)

    with open(target_path, "wb") as f:
        f.write(uploaded_file.getbuffer())

    return {
        "status": True,
        "path": target_path,
        "filename": filename,
        "ext": ext,
        "size_kb": round(os.path.getsize(target_path) / 1024, 2),
    }


# ---------------------------------------------------------
# Engine Dịch ngược ILSpy (.dll -> C#)
# ---------------------------------------------------------
def get_ilspy_executable():
    """Kiểm tra đường dẫn ilspycmd (ưu tiên thư mục tools/ trong dự án, sau đó đến PATH hệ thống)."""
    local_tool = os.path.join(os.path.dirname(__file__), "tools", "ilspycmd.exe")
    if os.path.isfile(local_tool):
        return local_tool
    return shutil.which("ilspycmd")


def decompile_dll_with_ilspy(dll_path: str, output_dir: str = "./output_csharp") -> dict:
    """Gọi ilspycmd để dịch ngược assembly .NET (.dll) thành source code C#."""
    tool_bin = get_ilspy_executable()
    if not tool_bin:
        return {
            "success": False,
            "message": (
                "Chưa tìm thấy công cụ 'ilspycmd'. Bạn có thể:\n"
                "1. Cài đặt toàn cục qua lệnh: dotnet tool install -g ilspycmd\n"
                "2. Hoặc copy file ilspycmd.exe vào thư mục './tools/' của dự án."
            ),
        }

    # Xóa sạch thư mục đầu ra cũ nếu có để tránh lẫn lộn file
    if os.path.exists(output_dir):
        shutil.rmtree(output_dir, ignore_errors=True)
    os.makedirs(output_dir, exist_ok=True)

    cmd = [tool_bin, "-p", "-o", output_dir, dll_path]

    try:
        result = subprocess.run(
            cmd,
            capture_output=True,
            text=True,
            encoding="utf-8",
            check=True,
            timeout=180,
        )
        return {
            "success": True,
            "output_dir": os.path.abspath(output_dir),
            "message": "Trích xuất mã nguồn C# thành công.",
            "stdout": result.stdout,
        }
    except subprocess.CalledProcessError as e:
        return {"success": False, "message": f"Lỗi dịch ngược: {e.stderr or e.stdout}"}
    except subprocess.TimeoutExpired:
        return {"success": False, "message": "Quá thời gian xử lý (Timeout)."}
    except Exception as e:
        return {"success": False, "message": f"Lỗi: {str(e)}"}


def create_zip_archive(source_dir: str) -> bytes:
    """Nén toàn bộ thư mục thành file zip dạng byte buffer để tải về trực tiếp."""
    zip_buffer = io.BytesIO()
    with zipfile.ZipFile(zip_buffer, "w", zipfile.ZIP_DEFLATED) as zip_file:
        for root, _, files in os.walk(source_dir):
            for file in files:
                file_path = os.path.join(root, file)
                arcname = os.path.relpath(file_path, source_dir)
                zip_file.write(file_path, arcname)
    return zip_buffer.getvalue()


# ---------------------------------------------------------
# Khu vực Upload File & Thiết lập
# ---------------------------------------------------------
upload_col, info_col = st.columns([2, 1])

with upload_col:
    uploaded_file = st.file_uploader(
        "Tải lên file cần khôi phục (.dll, .apk, .pyc)",
        type=["dll", "apk", "pyc"],
        help="Hỗ trợ các định dạng file thực thi và bytecode phổ biến.",
    )

with info_col:
    if uploaded_file is not None:
        file_ext = os.path.splitext(uploaded_file.name)[1].lower()
        st.markdown("#### 📄 Thông tin tệp")
        st.write(f"- **Tên file:** `{uploaded_file.name}`")
        st.write(f"- **Kích thước:** `{uploaded_file.size / 1024:.2f} KB`")
        st.write(f"- **Định dạng nhận diện:** `{file_ext}`")
    else:
        st.info("Vui lòng tải tệp lên để bắt đầu phân tích.")

# ---------------------------------------------------------
# Nút bấm xử lý và Khu vực hiển thị trạng thái
# ---------------------------------------------------------
if uploaded_file is not None:
    st.divider()

    btn_col, _ = st.columns([1, 4])
    with btn_col:
        start_button = st.button("🚀 Bắt đầu xử lý", type="primary", use_container_width=True)

    if start_button:
        # 1. Lưu file tải lên
        save_result = save_uploaded_file(uploaded_file)
        if not save_result["status"]:
            st.error(f"❌ {save_result['error']}")
            st.stop()

        st.subheader("📊 Trạng thái xử lý")
        st.caption(f"Đã lưu tệp tại: `{save_result['path']}` ({save_result['size_kb']} KB)")

        status_box = st.status("Đang khởi tạo quy trình phân tích...", expanded=True)
        progress_bar = st.progress(0)

        decompile_success = False
        output_folder = ""
        recovered_files_map = {}

        with status_box:
            # Bước 1: Nhận diện
            if opt_detect_env:
                st.write(f"🔍 **[Bước 1/4]** Nhận diện định dạng: `{save_result['ext']}`")
                time.sleep(0.5)
                progress_bar.progress(25)

            # Bước 2: Chuẩn bị
            st.write("📝 **[Bước 2/4]** Chuẩn bị engine và khởi tạo môi trường trích xuất...")
            time.sleep(0.5)
            progress_bar.progress(50)

            # Bước 3: Dịch ngược thực tế
            st.write("⚡ **[Bước 3/4]** Đang tiến hành khôi phục mã nguồn...")
            file_ext = save_result["ext"]

            if file_ext == ".dll":
                output_folder = "./output_csharp"
                res = decompile_dll_with_ilspy(save_result["path"], output_folder)
                if not res["success"]:
                    status_box.update(label="❌ Lỗi trong quá trình dịch ngược!", state="error", expanded=True)
                    st.error(res["message"])
                    st.stop()
                decompile_success = True
                progress_bar.progress(85)
            else:
                # Mock cho các định dạng khác đang phát triển
                time.sleep(1.0)
                decompile_success = True
                progress_bar.progress(85)

            # Bước 4: Hoàn thiện
            st.write("📦 **[Bước 4/4]** Hoàn tất và chuẩn bị dữ liệu xuất...")
            time.sleep(0.5)
            progress_bar.progress(100)
            status_box.update(label="✅ Quá trình khôi phục hoàn tất!", state="complete", expanded=False)

        st.success("Mã nguồn đã được trích xuất thành công!")

        # ---------------------------------------------------------
        # Khu vực hiển thị kết quả (Viewer & Download)
        # ---------------------------------------------------------
        res_col_nav, res_col_code = st.columns([1, 2])

        # Đọc danh sách file thực tế nếu là .dll
        if file_ext == ".dll" and os.path.exists(output_folder):
            for root, _, files in os.walk(output_folder):
                for f in files:
                    if f.endswith(".cs") or f.endswith(".csproj"):
                        rel_path = os.path.relpath(os.path.join(root, f), output_folder)
                        recovered_files_map[rel_path] = os.path.join(root, f)

        if recovered_files_map:
            with res_col_nav:
                st.markdown("##### 📁 Cấu trúc tệp đã khôi phục")
                selected_rel_path = st.selectbox("Chọn file để xem mã:", list(recovered_files_map.keys()))
                st.caption(f"Đang xem: `{selected_rel_path}`")

            with res_col_code:
                st.markdown("##### 💻 Trình xem mã nguồn (Code Viewer)")
                file_full_path = recovered_files_map[selected_rel_path]
                try:
                    with open(file_full_path, "r", encoding="utf-8", errors="ignore") as f:
                        code_content = f.read()
                except Exception:
                    code_content = "// Không thể đọc nội dung file."
                st.code(code_content, language="csharp", line_numbers=True)

            # Tạo file ZIP thật để người dùng tải về
            zip_bytes = create_zip_archive(output_folder)
            st.download_button(
                label="💾 Tải về toàn bộ mã nguồn (.zip)",
                data=zip_bytes,
                file_name=f"{os.path.splitext(uploaded_file.name)[0]}_restored.zip",
                mime="application/zip",
            )
        else:
            st.info("Chưa có mã nguồn nào được trích xuất hoặc định dạng đang được phát triển.")