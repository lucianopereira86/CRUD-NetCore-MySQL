# CRUD-NetCore-MySQL

Simple CRUD example by using .Net Core with DDD structure, Swagger, FluentValidation, AutoMapper, Entity Framework Core and MySQL Connection.

## Technologies:

- .Net Core 2.2
- Swagger
- FluentValidation
- AutoMapper
- Entity Framework Core
- MySQL Database


## To run this project

- Run the script located at "/Docs/script.sql" to create the database on MySQL Workbench or on another program of your preference.

- Open the solution located at "/APICRUDCoreRegister/APICRUDCoreRegister.sln" and configure the database connection on appsettings.json:

![Alt Text](/Docs/appsettings.PNG)

- Run the application and it will open on:
  `http://localhost:63850/swagger`

![Alt Text](/Docs/swagger.PNG)

## DDD Structure

- Solution:

![Alt Text](/Docs/DDD-0.PNG)

- Presentation Layer:

![Alt Text](/Docs/DDD-1.PNG)

- Domain Layer:

![Alt Text](/Docs/DDD-2.PNG)

- Infra Layer:

![Alt Text](/Docs/DDD-3.PNG)
