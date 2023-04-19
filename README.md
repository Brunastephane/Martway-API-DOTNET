# Martway



Instalar via NugetPackage

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer


Rodar comando abaixo no Package Manager Console:

dotnet tool install --global dotnet-ef


Comando para o Entity Framework(ORM)

dotnet ef migrations add [NOMEDAMIGRACAO] #Para criar novas migrations
dotnet ef database update                 #Para atualizar o DB seguindos as novas migracoes