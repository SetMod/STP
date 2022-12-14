# STP

Django project.

1. Activate virtualvenv:
```sh
source venv/bin/activate
```

1. Start Django app:
```sh
python3 mysite/manage.py runserver 0.0.0.0:8000
```

## .NET 6 WCF

> **Maybe do gRPC instead of WCF**

> [!!!!!] https://learn.microsoft.com/ru-ru/dotnet/framework/wcf/feature-details/how-to-create-a-basic-wcf-web-http-service

> https://devblogs.microsoft.com/dotnet/corewcf-v1-released/

> https://github.com/CoreWCF/CoreWCF

> https://github.com/CoreWCF/CoreWCF/blob/main/Documentation/Walkthrough.md

> https://www.codemag.com/Article/2211092/Using-CoreWCF-to-Move-WCF-Services-to-.NET-Core

1. Cerate new solution called "CalcService":
```sh
dotnet new sln --output CalcService
cd CalcService/
```

1. Create three new projects, two console projects with names "CalcServer" and "CalcClient", also class library with name "CalcInterfaces":
    ```sh
    dotnet new console -n CalcServer
    dotnet new console -n CalcClient
    dotnet new classlib -n CalcInterfaces
    ```

1. Add newly created projects to so "CalcService" solution
    ```sh
    dotnet sln add CalcServer/CalcServer.csproj
    dotnet sln add CalcClient/CalcClient.csproj 
    dotnet sln add CalcInterfaces/CalcInterfaces.csproj 
    dotnet sln list
    ```

1. Reference "CalcInterfaces" project in "CalcServer" project:
    ```sh
    dotnet add CalcServer/CalcServer.csproj reference CalcInterfaces/CalcInterfaces.csproj 
    ```

1. Install CoreWCF packages in "CalcServer" and "CalcInterfaces" projects:
    ```sh
    dotnet list CalcServer/CalcServer.csproj package
    dotnet add CalcServer/CalcServer.csproj package CoreWCF.Primitives
    dotnet add CalcServer/CalcServer.csproj package CoreWCF.Http

    dotnet list CalcInterfaces/CalcInterfaces.csproj package
    dotnet add CalcInterfaces/CalcInterfaces.csproj package CoreWCF.Primitives
    ```

1. Build and run:
    ```sh
    dotnet run --project CalcServer/CalcServer.csproj &
    dotnet run --project CalcClient/CalcClient.csproj --interactive
    fg
    ```