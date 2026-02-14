# UserManagementAPI

## 📖 Overview
The **UserManagementAPI** is an ASP.NET Core Web API built for TechHive Solutions to manage internal user records. It provides CRUD operations for HR and IT departments, along with middleware for logging, error handling, and authentication to ensure compliance with corporate policies.

---

## 🚀 Features
- **CRUD Endpoints**
  - `GET /api/users` → Retrieve all users
  - `GET /api/users/{id}` → Retrieve a specific user
  - `POST /api/users` → Add a new user
  - `PUT /api/users/{id}` → Update an existing user
  - `DELETE /api/users/{id}` → Remove a user

- **Middleware**
  - **Error Handling**: Catches unhandled exceptions and returns consistent JSON error responses.
  - **Authentication**: Validates tokens in the `Authorization` header.
  - **Logging**: Logs HTTP method, request path, and response status code for auditing.

- **Validation**
  - User model enforces required fields (`Name`, `Email`, `Department`) and proper email format.

---

## 📂 Project Structure
```
UserManagementAPI/
│
├── Controllers/
│   └── UsersController.cs
│
├── Middleware/
│   ├── ErrorHandlingMiddleware.cs
│   ├── RequestResponseLoggingMiddleware.cs
│   └── TokenAuthenticationMiddleware.cs
│
│
├── Program.cs
├── appsettings.json
├── Properties/
│   └── launchSettings.json
└── UserManagementAPI.csproj
```

---

## 🛠 Setup & Run
1. Clone the repository:
   ```bash
   git clone https://github.com/your-org/UserManagementAPI.git
   cd UserManagementAPI
   ```

2. Install dependencies:
   ```bash
   dotnet restore
   ```

3. Run the project:
   ```bash
   dotnet run
   ```

---

## 🔐 Authentication
- Requests must include an `Authorization` header:
  ```
  Authorization: Bearer valid-token
  ```
- Invalid or missing tokens return `401 Unauthorized`.

---

## 🧪 Testing
Use **Postman** or curl to test endpoints:
- Create a user:
  ```json
  {
    "name": "Alice Johnson",
    "email": "alice.johnson@techhive.com",
    "department": "HR"
  }
  ```
- Try invalid inputs (e.g., missing fields, bad email) to confirm validation and error handling.
- Check console logs for request/response logging.

---

## 📌 Copilot Contributions
Microsoft Copilot assisted by:
- Scaffolding boilerplate code in `Program.cs`.
- Generating CRUD endpoints and validation attributes.
- Suggesting middleware templates for logging, error handling, and authentication.
- Improving error messages and optimizing ID assignment logic.
