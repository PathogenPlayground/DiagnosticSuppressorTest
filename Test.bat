@echo off
:START
color 0f
cd TestLibrary
cls
dotnet build --no-incremental
pause
goto START
