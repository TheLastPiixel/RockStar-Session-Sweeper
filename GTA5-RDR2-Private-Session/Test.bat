@ECHO OFF
title Grand Theft Auto V Suspender
tasklist /FI "IMAGENAME eq notepad++.exe" 2>NUL | find /I /N "notepad++.exe">NUL
if "%ERRORLEVEL%"=="0" (
start pssuspend64.exe notepad++.exe
echo Succesfully suspended process.
timeout /t 7 /nobreak
start pssuspend64.exe -r notepad++.exe
) else (
Echo Grand Theft Auto V is not running.
pause
)