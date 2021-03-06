@ECHO OFF
dotnet publish KVEng.Security.EndPoint.WpfClient -c Release -o publish -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true --runtime win10-x64 --no-self-contained -v normal
MOVE publish\KVEng.Security.EndPoint.WpfClient.exe publish\KSE-win10-x64.exe

dotnet publish KVEng.Security.EndPoint.WpfClient -c Release -o publish -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true --runtime win10-x64 --self-contained true
MOVE publish\KVEng.Security.EndPoint.WpfClient.exe publish\KSE-c-win10-x64.exe
PAUSE

REM -p:PublishTrimmed=false     NOT SUPPORTED
REM --self-contained true       DO NOT CONTAINES .NET
REM -p:PublishReadyToRun=true   DO NOT AOT