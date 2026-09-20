@echo off
title Build CodeRecoveryStudio Standalone EXE
echo ========================================================
echo   DONG GOI CODERECOVERYSTUDIO THANH FILE THUC THI (.EXE)
echo ========================================================
echo.

echo [1/3] Kiem tra PyInstaller...
pip show pyinstaller >nul 2>&1
if %ERRORLEVEL% NEQ 0 (
    echo Dang cai dat PyInstaller...
    pip install pyinstaller
)

echo.
echo [2/3] Dang bien dich thanh file exe...
pyinstaller --noconsole --name "CodeRecoveryStudio" --icon=NONE ^
    --add-data "tools;tools" ^
    --hidden-import "pefile" ^
    --hidden-import "PyQt6" ^
    --clean main.py

echo.
echo [3/3] Hoan tat! File thuc thi duoc luu tai thu muc: dist\CodeRecoveryStudio\
pause
