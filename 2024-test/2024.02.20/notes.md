Fetch the repo @ [https://github.com/AnkitSharma-007/ASPCore.BlazorDemo](https://github.com/AnkitSharma-007/ASPCore.BlazorDemo)

The application runs an old version of .net at therefor we need to 
docker run --rm -it -v $(pwd)/BlazorDemo:/app -w /app -p 3000:5000 mcr.microsoft.com/dotnet/sdk:3.1 bash

Run the command ```dotnet build``` to build the first time the container start to download nuget dependencies thereafter we can just run ```dotnet test``` to run all the tests!

Given When Then =?= Arrange Act Assert

 