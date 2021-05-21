dotnet publish /p:PublishProfile=win-x86
dotnet publish /p:PublishProfile=win-x64
dotnet publish /p:PublishProfile=win-arm
cd "Cemu Graphic Pack Generator/bin/Release/net5.0-windows/publish"
7z a ../../../../../Build.zip win-x86
7z a ../../../../../Build.zip win-x64
7z a ../../../../../Build.zip win-arm
echo Complete