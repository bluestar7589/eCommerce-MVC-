# eCommerce(MVC) with Entity Framework
Using Entity Framework to create a simple eCommerce website with MVC.

## Getting Started
- VS 2022
- .NET 8
- Entity Framework Core

### Install packages needed
- Right click on the project and select `Manage NuGet Packages`
- Search for `Microsoft.EntityFrameworkCore.SqlServer` and install it
- Search for `Microsoft.EntityFrameworkCore.Tools` and install it
- Search for `Microsoft.AspNetCore.Identity.EntityFrameworkCore` and install it


### Guides how to create database from Entity Framework (EF) with command
- Create ASP .NET Core MVC project
- Create the model(s) for the class needed
- Create the DbContext class
- Add the connection string to the appsettings.json
- Add the DbContext to the services in the Program.cs

Run the command `Add-Migration InitialDatabase` in the Package Manager Console with InitialDatabase is just a name/ nothing special
Run the command `Update-Database` in the Package Manager Console
