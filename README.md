# Employee Management System

A simple **Employee Management System** built with **ASP.NET Core Web API**, **Alpine.js**, **MySQL**, and **Entity Framework Core**. The application provides a clean interface to perform CRUD (Create, Read, Update, Delete) operations on employee records through a RESTful API.

## Features

* Add a new employee
* View all employees
* Update employee information
* Delete employee records
* RESTful Web API
* Responsive frontend using Alpine.js
* MySQL database integration using Entity Framework Core

## Tech Stack

### Backend

* ASP.NET Core (.NET 10)
* C#
* Entity Framework Core
* Pomelo Entity Framework Core MySQL Provider

### Frontend

* HTML5
* CSS3
* Alpine.js

### Database

* MySQL

## Project Structure

```
DemoApp1/
│
├── Controllers/
│   └── EmployeeApiController.cs
├── Employee/
│   ├── Emp.cs
│   ├── Dept.cs
│   └── EmployeeDbContext.cs
├── Model/
│   └── EmpModel.cs
├── wwwroot/
│   ├── index.html
│   └── alpine.js
├── Program.cs
└── DemoApp.csproj
```

## API Endpoints

| Method | Endpoint                | Description            |
| ------ | ----------------------- | ---------------------- |
| GET    | `/api/EmployeeApi`      | Retrieve all employees |
| POST   | `/api/EmployeeApi`      | Add a new employee     |
| PUT    | `/api/EmployeeApi/{id}` | Update an employee     |
| DELETE | `/api/EmployeeApi/{id}` | Delete an employee     |

## Getting Started

### Prerequisites

* .NET SDK 10
* MySQL Server
* Git

### Installation

1. Clone the repository

```bash
git clone https://github.com/Nikhil23108/Employee-Management-System-AlpineJS.git
```

2. Navigate to the project directory

```bash
cd Employee-Management-System-AlpineJS
```

3. Restore dependencies

```bash
dotnet restore
```

4. Update the MySQL connection string in `appsettings.json`.

5. Run the application

```bash
dotnet run
```

6. Open your browser and navigate to

```
http://localhost:5000
```

(or the URL displayed in the terminal)

## Screenshots

You can add screenshots of:

* Employee Dashboard
* Add Employee Form
* Edit Employee Form
* Employee List

## Future Improvements

* Authentication & Authorization
* Search and Filter Employees
* Pagination
* Form Validation
* Department Management
* Docker Support
* Unit Testing

## Author

**Nikhil**

GitHub: https://github.com/Nikhil23108

## License

This project is intended for learning and educational purposes.

# Website Image :-

<img width="1362" height="681" alt="image" src="https://github.com/user-attachments/assets/19e5e92a-c36a-4d61-a55f-b5ce48e30044" />

