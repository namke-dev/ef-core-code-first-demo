install package

```powershell
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Designdotnet
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

migrations

```powershell
dotnet ef migrations add InitialCreate --context DataContext
```

remove the line from .csproj

```powershell
<InvariantGlobalization>true</InvariantGlobalization>
```

Use EF core to create database

```powershell
dotnet ef database update --context DataContext
```

my connection string

```powershell
"Server=.;Database=superherodb;Trusted_Connection=True;Encrypt=False;"
```
