rm -r -f ./published
dotnet publish ./src/AutoCursor/AutoCursor.csproj -c Release -o ./published -p:PublishTrimmed=true -r win-x86
