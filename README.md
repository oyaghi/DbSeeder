# DbSeeder

A high-performance data seeding utility built with **.NET 10** and **Bogus** for the ExitZero blog project. This tool is optimized for massive datasets using high-speed bulk insertion.

## 🚀 Features

* **Bulk Insertion:** Uses [EFCore.BulkExtensions](https://github.com/borisdj/EFCore.BulkExtensions) to bypass the standard EF Core change tracker for 10x-100x faster data ingestion.
* **Realistic Data:** Leverages **Bogus** to generate high-fidelity, randomized company and employee profiles.
* **Identity Mapping:** Implements a two-stage seeding process to ensure Foreign Key integrity across bulk batches.
* **Graceful Shutdown:** Fully integrated with `IHostApplicationLifetime` and `CancellationToken` for safe termination.

## 🛠️ Tech Stack

* **Framework:** .NET 10
* **ORM:** Entity Framework Core
* **Bulk Provider:** EFCore.BulkExtensions.SqlServer
* **Database:** SQL Server / LocalDB
* **Data Generation:** Bogus

## 📋 Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server LocalDB

## ⚙️ Setup & Configuration

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/oyaghi/DbSeeder.git](https://github.com/oyaghi/DbSeeder.git)