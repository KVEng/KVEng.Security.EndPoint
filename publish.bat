@ECHO OFF
dotnet publish KVEng.Security.EndPoint.WpfClient -c Release -o publish -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true --runtime win10-x64 --no-self-contained -v normal

PAUSE

REM -p:PublishTrimmed=false     NOT SUPPORTED
REM --self-contained true       DO NOT CONTAINES .NET
REM -p:PublishReadyToRun=true   DO NOT AOT