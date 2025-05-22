# 📦 Inventory Management System - Clean Architecture Template

A modular and extensible Inventory Management System built with **ASP.NET Core**, **Entity Framework Core**, and **Clean Architecture** principles. This template is designed to help developers quickly start building robust enterprise-level applications with best practices.

---

## 🏗️ Tech Stack

- ✅ ASP.NET Core Web API
- ✅ Entity Framework Core (SQL Server or PostgreSQL)
- ✅ Clean Architecture (Domain, Application, Infrastructure, API)
- ✅ Repository & Service Pattern
- ✅ Role-Based Authentication (JWT)
- ✅ Swagger/OpenAPI Documentation
- ✅ Unit Testing (xUnit)

---


---

## 🧩 Features

- Item, Supplier, Stock, and Sale Management
- Secure API with JWT Authentication and Role-Based Access
- Clean separation of concerns using Clean Architecture
- Swagger UI for API exploration
- Easy to extend and maintain

---

## 🚀 Getting Started

### 1️⃣ Clone the Repository

```bash
git clone https://github.com/yourusername/InventoryManagementSystem.git
cd InventoryManagementSystem
Setup the Database
By default, it uses SQL Server or In-Memory (for dev/testing).

Update your connection string in:

bash
Copy
Edit
src/InventorySystem.API/appsettings.json
json
Copy
Edit
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=InventoryDb;Trusted_Connection=True;"
}
3️⃣ Run the Application
Use Visual Studio or CLI:

bash
Copy
Edit
dotnet build
dotnet run --project src/InventorySystem.API
Visit Swagger UI:

bash
Copy
Edit
https://localhost:5001/swagger
✅ Default Roles & Authentication
🔐 Admin and User roles are supported.

JWT-based Authentication with token generation.

🧪 Running Unit Tests
bash
Copy
Edit
dotnet test tests/InventorySystem.Tests
