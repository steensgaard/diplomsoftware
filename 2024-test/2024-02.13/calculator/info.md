Start docker with mounted app and ports open.
```
    docker run --rm -it -v $(pwd):/app -p 8080:5002 -w /app mcr.microsoft.com/dotnet/sdk:8.0 bash
```


Start app with command when inside bash
```
    dotnet watch
```
