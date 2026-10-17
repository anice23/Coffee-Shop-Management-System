
# Coffee Shop Management System

A desktop application developed with C# and .NET 8 to help coffee shops manage their daily operations.

## Overview

Coffee Shop Management System provides a centralized interface for managing products, categories, users, orders, inventory, sales reports, and café settings.

The project was built to practise layered architecture, database integrity, asynchronous programming, and maintainable application design.

## Features

- **Dashboard:** Sales statistics, recent orders, low-stock alerts, and revenue charts.
- **Point of Sale (POS):** Product search, category filtering, shopping cart, checkout confirmation, and stock validation.
- **Product Management:** Add, edit, search, deactivate, and restore products, including product images.
- **Category Management:** Create, edit, search, deactivate, and restore categories.
- **User Management:** Admin and Cashier roles with BCrypt password hashing.
- **Order Management:** Order history, date and payment filters, and order details.
- **Reports:** Revenue summaries, payment analysis, best-selling products, and CSV export.
- **Receipt Printing:** Printable receipts with configurable café information.
- **Settings:** Café details, receipt footer, and low-stock threshold.
- **Data Integrity:** Entity Framework Core, SQL Server, asynchronous database operations, and transactional checkout.

## Technologies

- C#
- .NET 8
- Windows Forms
- Entity Framework Core 8
- Microsoft SQL Server
- LINQ
- Async / Await
- Git and GitHub

## Architecture

The solution is organized into three main projects:

```text
CoffeSystem_1UI
       |
       v
CoffeSystem_Business
       |
       v
CoffeSystem_DataAccess
       |
       v
SQL Server
```

- **UI Layer:** Windows Forms and user interactions.
- **Business Layer:** Services and business rules.
- **Data Access Layer:** Entities, repositories, EF Core, and database operations.

## Setup

1. Clone or download the repository.
2. Open the solution file in Visual Studio.
3. Review `appsettings.example.json` and create a local `appsettings.json` in the startup project.
4. Configure the SQL Server connection string for your environment.
5. Restore NuGet packages and apply the existing EF Core migrations.
6. Build and run the Windows Forms application.

Do not commit local connection strings, credentials, or real database files.

## Author

**Anis Chaabouni**

Junior .NET / Full-Stack Developer
