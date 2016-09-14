@ECHO OFF
title Release...

call "%VS140COMNTOOLS%vsvars32.bat"

MSBuild.exe DSSaveTools.sln /nologo /m /t:Rebuild /property:Configuration=Release

call OkRelease.bat
title OkRelease

MSBuild.exe DSSaveTools.sln /nologo /m /t:Clean /property:Configuration=Release

rem explorer OkRelease
exit /b
