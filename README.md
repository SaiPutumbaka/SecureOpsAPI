# Secure Operations Management API

A robust, RESTful backend Web API engineered to securely process, validate, and serve operational business data. 

Built with **.NET 10.0** and **C#**, this system replaces disjointed manual tracking methods (such as regional Excel spreadsheets) with a centralized, strictly typed, and highly resilient architecture. 

## 📊 Business Significance & Use Case

In decentralized operational environments—managing 80+ regional projects simultaneously—relying on manual data entry via spreadsheets introduces massive risks regarding data integrity, version control, and regulatory exposure. 

This API was created to solve those business bottlenecks by serving as a secure "gatekeeper" between end-users and the corporate database. 

**Core Business Benefits:**
* **Data Integrity:** Enforces strict data types and prevents invalid or incomplete records from being saved to the database.
* **Audit Traceability:** Automatically timestamps the creation of every operational record, enabling leadership to accurately assess risk, pricing, and project compliance.
* **System Resiliency:** Utilizes comprehensive error handling to ensure the system gracefully manages failed requests without crashing or leaking sensitive backend architecture details.

---

## 🏗️ Technical Architecture

This application is built using the **Model-View-Controller (MVC)** architectural pattern, separating data representation from business logic and request routing. 

### Tech Stack
* **Framework:** .NET 10.0 / ASP.NET Core
* **Language:** C#
* **Database:** SQLite (Configured for rapid local development; perfectly mirrors SQL Server enterprise deployment)
* **ORM:** Entity Framework Core (EF Core)
* **API Documentation:** Swagger / OpenAPI

---

## 🧩 Code Structure & Components

The codebase is modular, ensuring it is highly maintainable and scalable for future enterprise integrations.

### 1. The Data Model (`OperationalRecord.cs`)
Acts as the blueprint for the database schema. It utilizes strong C# typing to ensure data consistency.
* Tracks: `Id` (Primary Key), `LocationName`, `Revenue`, `Status`, and a strictly enforced `CreatedAt` timestamp (UTC).

### 2. The ORM Translator (`AppDbContext.cs`)
Inherits from Entity Framework's `DbContext`. This class maps the C# object models directly to relational database tables, allowing the application to execute complex SQL operations securely without writing raw, vulnerable SQL strings.

### 3. The API Controller (`RecordsController.cs`)
The core routing logic of the application. It listens for standard HTTP requests and executes database operations asynchronously (`async/await`) to prevent server bottlenecking under heavy load.
* **`[HttpGet]` Endpoint:** Safely queries and returns all operational records formatted as JSON.
* **`[HttpPost]` Endpoint:** Receives incoming JSON payloads, validates the structure, and commits the data to the database. It is wrapped in strict `try-catch` blocks to catch exceptions and return standardized `500 Internal Server Error` responses, preventing application crashes.

---

## 🚀 How to Run Locally

To test this API on your local machine, ensure you have the .NET 10.0 SDK installed.

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/yourusername/SecureOpsAPI.git](https://github.com/yourusername/SecureOpsAPI.git)
   cd SecureOpsAPI
