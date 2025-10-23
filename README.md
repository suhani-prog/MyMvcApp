# MyMvcApp

A simple ASP.NET Core MVC CRUD Web Application built using Entity Framework Core and SQLite.  
This project demonstrates how to perform basic Create, Read, Update, and Delete operations on an Employee database.

## Features

- Add new employees  
- View employee list  
- Edit existing employee details  
- Delete employee records  
- Built with ASP.NET Core MVC and EF Core  
- Uses SQLite for easy local development


## Tech Stack

- .NET 9.0
- ASP.NET Core MVC
- Entity Framework Core
- SQLite Database
- Razor Views


## ⚙️ Installation Steps

Follow these steps to set up and run the project locally:

1. Clone the repository
git clone https://github.com/yourusername/MyMvcApp.git

2.Navigate into the project folder
cd MyMvcApp

3.Restore dependencies
dotnet restore

4.Apply database migrations
dotnet ef database update

5. Run the Application
dotnet run

The app will start on:
```bash
https://localhost:5001
or
http://localhost:5000

