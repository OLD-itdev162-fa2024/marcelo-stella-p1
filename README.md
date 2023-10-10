# marcelo-stella-p1
Marcelo Stella Project 1

PROJECT DESCRIPTION
MyCompanyWebsite is an application built in VSCode and Visual Code 2022 using .NET Core, EntityFramework and an internal API with SQL Server where you can add, edit or delete employees for your company and will be displayed in a table. This project has been created based on a Youtube Tutorial "Angular 14 CRUD with .NET 6 Web API using Entity Framework Core"

FEATURE LIST

Frontend features:

*Angular Body: Application was created using Angular as base body

*Basic Navigation Bar: HTML body copied from Bootstrap to create a navigation bar to connect all the pages

*Table Display: Table HTML body copied from Bootstrap connected to an internal API in SQL Server. Employees will be sorted from A-Z

*VIEW Button: Button set to open a second page where you can either edit or delete existing employees

*Employee Form: Form connected to API and SQL server that allows you to enter or register new employees. All requests will go through an authentication process

Backend Features:

*API Connection: Application is connected to an API created in Visual Studio 2022 that will also update a database in SQL Server. Every request will go though a verification process before accepted

*.NET Controller: Controller created in the API that will contain all important methods needed for the application

*CORS activated: Cors had to be activated in order to connect to internal database

*SQL Database: Database was created from Visual Studio using commands such as "Add-Migration" and giving an specific "ConnectionString"

*ASP.NET: Project was created using an Angular command such as "ng new MyCompanyWebsite" to generate an static Angular website
