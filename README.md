# DbSeeder

A high-performance data seeding utility built with **.NET 10** and **Bogus** for the ExitZero blog project. This tool populates a SQL Server database with realistic, randomized company and employee data.

## 🚀 Features

* **Realistic Data:** Uses the [Bogus](https://github.com/b_chavez/Bogus) library to generate names, locations, and salaries.
* **Graceful Shutdown:** Implements `IHostApplicationLifetime` and `CancellationToken` for safe cancellation during heavy seeding operations.
* **EF Core Integration:** Demonstrates clean relationship seeding between Companies and Employees.
* **Generic Positions:** Includes a comprehensive list of corporate job titles for realistic organizational modeling.

## 🛠️ Tech Stack

* **Framework:** .NET 10
* **ORM:** Entity Framework Core
* **Database:** SQL Server / LocalDB
* **Libraries:** Bogus, Microsoft.Extensions.Hosting

## 📋 Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server LocalDB (installed with Visual Studio)

## ⚙️ Setup & Configuration

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/oyaghi/DbSeeder.git](https://github.com/oyaghi/DbSeeder.git)
