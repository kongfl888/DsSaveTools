@echo off
SET "WORK_DIR=%~dp0"
md OkRelease 2>nul
del OkRelease\DSSaveTools*.exe 2>nul
xcopy %WORK_DIR%bin\Release\DSSaveToolskmod.exe %WORK_DIR%OkRelease /Y/R
xcopy %WORK_DIR%docs %WORK_DIR%OkRelease\docs /Y/I/E
copy %WORK_DIR%LICENSE %WORK_DIR%OkRelease /Y

exit /b