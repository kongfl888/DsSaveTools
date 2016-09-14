@echo off
md OkRelease 2>nul
xcopy bin\Release\DSSaveTools.exe OkRelease /Y/R
xcopy docs OkRelease\docs /Y/I/E
copy LICENSE OkRelease /Y

exit /b