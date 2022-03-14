# Truck-Api
Api de criação de caminhões

appsettings.json
```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "Connection": "Data Source=localhost;Initial Catalog=DATABASE;User Id=USER;Password=PASSWORD;MultipleActiveResultSets=true;"
  }
}
```
Trocar o DATABASE pelo nome do seu Banco, USER para o seu usuário e PASSWORD para a sua senha.


Migrations
```
Abrir o Package Manager Console 
Rodar o comando Update-Database

```
