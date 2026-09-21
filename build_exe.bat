@echo off
chcp 65001 >nul
title Đóng Gói CodeRecoveryStudio Thành File Thực Thi Standalone (.EXE)
color 0b

echo ===============================================================================
echo        HỆ THỐNG ĐÓNG GÓI TỰ ĐỘNG CODERECOVERYSTUDIO (.EXE)
echo ===============================================================================
echo.

echo [BƯỚC 1/4] Kiểm tra môi trường Python & PyInstaller...
python --version >nul 2>&1
if %ERRORLEVEL% NEQ 0 (
    color 0c
    echo [LỖI] Không tìm thấy Python trong hệ thống! Vui lòng cài đặt Python 3.9+ và thêm vào PATH.
    pause
    exit /b 1
)

pip show pyinstaller >nul 2>&1
if %ERRORLEVEL% NEQ 0 (
    echo [*] Đang tự động cài đặt PyInstaller mới nhất...
    pip install pyinstaller
)
echo [OK] Môi trường hợp lệ.

echo.
echo [BƯỚC 2/4] Dọn dẹp các bản dựng cũ...
if exist "build" rmdir /s /q "build"
if exist "dist\CodeRecoveryStudio" rmdir /s /q "dist\CodeRecoveryStudio"
echo [OK] Đã dọn dẹp sạch sẽ thư mục build và dist.

echo.
echo [BƯỚC 3/4] Đang tiến hành biên dịch ứng dụng với CodeRecoveryStudio.spec...
echo (Quá trình này có thể mất từ 1-2 phút, vui lòng đợi...)
echo.

pyinstaller CodeRecoveryStudio.spec --clean --noconfirm

if %ERRORLEVEL% NEQ 0 (
    color 0c
    echo.
    echo ===============================================================================
    echo [LỖI] Quá trình biên dịch thất bại! Vui lòng kiểm tra log lỗi bên trên.
    echo ===============================================================================
    pause
    exit /b 1
)

echo.
echo [BƯỚC 4/4] Đồng bộ các tệp phụ thuộc & công cụ (tools)...
if exist "tools" (
    if not exist "dist\CodeRecoveryStudio\tools" mkdir "dist\CodeRecoveryStudio\tools"
    xcopy /e /y /i "tools\*" "dist\CodeRecoveryStudio\tools\" >nul
)

:: Tạo kịch bản khởi chạy nhanh bên trong dist
(
    echo @echo off
    echo title CodeRecoveryStudio Launcher
    echo start "" "CodeRecoveryStudio.exe"
) > "dist\CodeRecoveryStudio\CHAY_UNG_DUNG.bat"

color 0a
echo.
echo ===============================================================================
echo              ĐÓNG GÓI THÀNH CÔNG RỰC RỠ!
echo ===============================================================================
echo Tệp thực thi độc lập đã sẵn sàng tại:
echo   dist\CodeRecoveryStudio\CodeRecoveryStudio.exe
echo.
echo Thư mục này có thể nén thành ZIP hoặc chia sẻ sang bất kỳ máy tính Windows nào
echo để sử dụng trực tiếp mà KHÔNG CẦN cài đặt Python!
echo ===============================================================================
echo.

set /p RUN_NOW="Bạn có muốn chạy thử ứng dụng ngay bây giờ không? (Y/N): "
if /i "%RUN_NOW%"=="Y" (
    echo Đang khởi chạy CodeRecoveryStudio.exe...
    start "" "dist\CodeRecoveryStudio\CodeRecoveryStudio.exe"
)

echo.
echo Hoàn tất.
pause
