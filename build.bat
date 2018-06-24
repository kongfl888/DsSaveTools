@ECHO OFF
title Release...

cd "%~dp0"
SET "WORK_DIR=%~dp0"

SET "MYVSCOMNTOOLS=C:\Program Files (x86)\Microsoft Visual Studio\2017\Professional\Common7\Tools\"

call "%MYVSCOMNTOOLS%VsDevCmd.bat"

MSBuild.exe %WORK_DIR%DSSaveTools.sln /nologo /m /t:Rebuild /property:Configuration=Release

call %WORK_DIR%OkRelease.bat
title OkRelease

MSBuild.exe %WORK_DIR%DSSaveTools.sln /nologo /m /t:Clean /property:Configuration=Release

rem explorer OkRelease
exit /b
