@echo off
set /p version="Version (ex. 4.5.0): "
nuget.exe pack Krypton.Components.Suite.nuspec -Version %version%
nuget.exe push Krypton.Components.Suite.%version%.nupkg