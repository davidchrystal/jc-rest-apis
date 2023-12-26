# Julio Casal: Building dotnet rest APIs

This repository is a collection of the course files created while learning to build high-quality REST APIs following Julio Casal's course. The course provides a comprehensive step-by-step guide for building production-ready APIs. Full course details can be found at the link below.

https://dotnetrestapis.com/

## Running the API locally
WIP

## Starting SQL Server
```powershell
$sa_password = "[SA PASSWORD HERE]"
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=$sa_password" -p 1433:1433 -v sqlvolume:/var/opt/mssql -d --rm --name mssql mcr.microsoft.com/mssql/server:2022-latest
```

## Setting SQL connection string in user-secrets
```powershell
$database = "[DATABASE NAME HERE]"
$sa_password = "[SA PASSWORD HERE]"
dotnet user-secrets set "ConnectionStrings:GameStoreContext" "Server=localhost;Database=$database;User Id=sa;Password=$sa_password;TrustServerCertificate=True"
```