@echo off
title CodeRecoveryStudio
echo Dang khoi dong CodeRecoveryStudio...
python main.py
if %ERRORLEVEL% NEQ 0 (
    echo.
    echo [!] Co loi xay ra khi khoi chay ung dung.
    pause
)
