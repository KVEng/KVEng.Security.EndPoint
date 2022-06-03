@ECHO OFF
dotnet publish -c Release -o publish -p:PublishReadyToRun=true -p:PublishSingleFile=true --self-contained true -p:IncludeNativeLibrariesForSelfExtract=true --runtime win10-x64
PAUSE
REM -p:PublishTrimmed=false 