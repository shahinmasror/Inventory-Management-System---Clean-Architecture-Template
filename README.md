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

## 🗂️ Project Structure
InventoryManagementSystem/
├── src/
│ ├── InventorySystem.Domain/ # Domain entities and core models
│ ├── InventorySystem.Application/ # Interfaces and use case services
│ ├── InventorySystem.Infrastructure/ # Database context and service implementations
│ └── InventorySystem.API/ # Web API layer (controllers, authentication, Swagger)
├── tests/
│ └── InventorySystem.Tests/ # Unit tests using xUnit
├── README.md
