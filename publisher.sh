dotnet pack --configuration Release
dotnet nuget push "bin/Release/OdinPlugs.SnowFlake.1.0.5.nupkg"  --api-key "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" --source "github"
dotnet nuget add source --username odinsam --password "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" --store-password-in-clear-text --name github "https://nuget.pkg.github.com/odinsam/index.json"

