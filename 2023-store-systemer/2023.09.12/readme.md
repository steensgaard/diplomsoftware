# docker as development environment

See here for overall links to running .net stuff i containers https://hub.docker.com/_/microsoft-dotnet-sdk/

Docker image to use 
```
    docker pull mcr.microsoft.com/dotnet/sdk:7.0
```




The project is based on https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio-code

Enter container and see app 
```
    docker run --rm -it -v $(pwd)/rejser:/app -w /app mcr.microsoft.com/dotnet/sdk:7.0 bash
```

With open port
```
    docker run --rm -it -v $(pwd)/rejser:/app -p 8080:5002 -w /app mcr.microsoft.com/dotnet/sdk:7.0 bash
```
To se how to freeze urls see: https://stackoverflow.com/questions/37365277/how-to-specify-the-port-an-asp-net-core-application-is-hosted-on

To run the app the execute the command in the docker context
```
    dotnet run
```
