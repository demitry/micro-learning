# dotnet --list-sdks

dotnet --list-sdks
7.0.100-rc.2.22477.23 [C:\Program Files\dotnet\sdk]

dotnet new blazorserver -f net6.0

# dotnet new blazorserver

The template "Blazor Server App" was created successfully.
This template contains technologies from parties other than Microsoft, see https://aka.ms/aspnetcore/7.0-third-party-notices for details.

Processing post-creation actions...
Restoring F:\src\micro-learning\BlazorAppFromScratch\BlazorAppFromScratch.csproj:
  Determining projects to restore...
  Restored F:\src\micro-learning\BlazorAppFromScratch\BlazorAppFromScratch.csproj (in 118 ms).
Restore succeeded.

# dotnet watch run

dotnet watch run
dotnet watch 🔥 Hot reload enabled. For a list of supported edits, see https://aka.ms/dotnet/hot-reload.
  💡 Press "Ctrl + R" to restart.
dotnet watch 🔧 Building...
  Determining projects to restore...
  All projects are up-to-date for restore.
C:\Program Files\dotnet\sdk\7.0.100-rc.2.22477.23\Sdks\Microsoft.NET.Sdk\targets\Microsoft.NET.RuntimeIde
ntifierInference.targets(257,5): message NETSDK1057: You are using a preview version of .NET. See: https: 
//aka.ms/dotnet-support-policy [...\BlazorAppFromScratch.csproj]
  BlazorAppFromScratch -> ...\bin\Debug\net7.0\BlazorAppFromScratch.dll
dotnet watch 🚀 Started
info: Microsoft.Hosting.Lifetime[14]
      Now listening on: http://localhost:<port>
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Development
info: Microsoft.Hosting.Lifetime[0]
      Content root path: F:\...\BlazorAppFromScratch
warn: Microsoft.AspNetCore.HttpsPolicy.HttpsRedirectionMiddleware[3]
      Failed to determine the https port for redirect.
