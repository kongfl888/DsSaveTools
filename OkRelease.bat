@echo off
md OkRelease 2>nul
del OkRelease\DSSaveTools*.exe 2>nul
xcopy bin\Release\DSSaveToolskmod.exe OkRelease /Y/R
xcopy docs OkRelease\docs /Y/I/E
copy LICENSE OkRelease /Y

exit /b