$options= @('--configuration', 'Release', '-p:PublishSingleFile=true', '-p:DebugType=embedded', '--self-contained', 'false')
dotnet publish PTK-led-sandbox $options --runtime win-x64 --framework net5.0 -o build/win-x64
dotnet publish PTK-led-sandbox $options --runtime linux-x64 --framework net5.0 -o build/linux-x64