@echo off
set /p last=<last_version
@echo Last published version is %last%
set /p version="Version (ex. 4.5.0): "
nuget.exe pack Krypton.Components.Suite.nuspec -Version %version%
nuget.exe push Krypton.Components.Suite.%version%.nupkg