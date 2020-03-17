# Build/Run

### Requirements

- [.NET Core 3.1 SDK](https://www.microsoft.com/net/download/core)
- [SQL Server 2017](https://docs.microsoft.com/en-us/sql/index)

*These dependencies are free to use.*

### Recommended Development Tooling

- [Visual Studio](https://www.visualstudio.com/vs/) (Windows and macOS)
- [Visual Studio Code](https://code.visualstudio.com/) (other)

*These tools are free to use.*

## Database
```
docker pull mcr.microsoft.com/mssql/server
docker run --name mydatabase -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=Passw0rd' -p 1434:1433 -d mcr.microsoft.com/mssql/server
```

```
dotnet restore
dotnet build
dotnet run
```

visit http://localhost:5000

## Deploy

You can deploy SimpleBlazorTasker using Docker containers on Windows, macOS, and Linux distributions. 

### Requirements

- [Docker](https://www.docker.com/community-edition#/download)
- [Docker Compose](https://docs.docker.com/compose/install/) (already included with some Docker installations)

*These dependencies are free to use.*

### Build Docker Image

```
docker image build -t simpleblazortasker .
```


### Run Docker Image

```
docker run -d -p 8080:80 --name simpleblazortasker simpleblazortasker
```

visit http://localhost:8080

## Contribute

Code contributions are welcome! Visual Studio or VS Code is highly recommended if you are working on this project. Please commit any pull requests against the `master` branch.
