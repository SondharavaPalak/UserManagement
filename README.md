# 🚀 User Management System 

A full-stack **User Management Application** built using **ASP.NET Core Web API (.NET)** and **React.js**.
This project allows users to perform complete **CRUD operations** (Create, Read, Update, Delete) with a clean and simple UI.

---

## 📌 Project Overview

This project was developed as part of a backend development activity to demonstrate:

* API development using .NET
* Frontend integration using React
* Use of AI tools (Copilot) for development
* GitHub project deployment

---

## ✨ Features

* ✅ Create new users
* ✅ View all users
* ✅ Update user details
* ✅ Delete users
* ✅ Input validation (Name, Email, Age)
* ✅ RESTful API design
* ✅ Simple and responsive UI

---

## 🧱 Tech Stack

### Backend

* ASP.NET Core Web API (.NET)
* C#
* Swagger (API testing)

### Frontend

* React.js
* JavaScript (Fetch API)

### Tools

* Visual Studio Code
* Git & GitHub
* Postman (for API testing)
* GitHub Copilot (AI assistance)

---

## 📂 Project Structure

```
CourseEra/
│
├── UserManagementAPI/     # .NET Backend
│   ├── Controllers/
│   ├── Program.cs
│
├── user-frontend/         # React Frontend
│   ├── src/
│   ├── App.js
│
└── README.md
```

---

## ⚙️ Project Setup

### 🔹 1. Clone Repository

```
git clone https://github.com/SondharavaPalak/UserManagement.git
cd UserManagement
```

---

## 🖥️ Backend Setup (.NET API)

### Step 1: Navigate to backend

```
cd UserManagementAPI
```

### Step 2: Install dependencies

```
dotnet restore
```

### Step 3: Run the API

```
dotnet run
```

### Step 4: Open Swagger

```
http://localhost:5090/swagger
```

---

## 🌐 Frontend Setup (React)

### Step 1: Navigate to frontend

```
cd user-frontend
```

### Step 2: Install dependencies

```
npm install
```

### Step 3: Start frontend

```
npm start
```

### Step 4: Open browser

```
http://localhost:3000
```

---

## 🔗 API Endpoints

| Method | Endpoint       | Description    |
| ------ | -------------- | -------------- |
| GET    | /api/user      | Get all users  |
| GET    | /api/user/{id} | Get user by ID |
| POST   | /api/user      | Create user    |
| PUT    | /api/user/{id} | Update user    |
| DELETE | /api/user/{id} | Delete user    |

---

## 🤖 Use of GitHub Copilot

GitHub Copilot was used as an AI coding assistant during development:

* Generated CRUD API endpoints
* Suggested validation attributes
* Helped debug runtime errors
* Assisted in writing cleaner and optimized code
* Provided sample JSON for API testing

Copilot significantly improved development speed and productivity.

---

## 🧪 Testing

* API tested using **Swagger UI** and **Postman**
* All endpoints verified:

  * GET ✅
  * POST ✅
  * PUT ✅
  * DELETE ✅

---

## ⚠️ Notes

* Data is stored in-memory (no database)
* Data will reset when server restarts

---

## 🚀 Future Improvements

* Add database (MongoDB / SQL Server)
* Implement authentication (JWT)
* Improve UI design
* Add pagination & search

---

## 👨‍💻 Author

**Palak Sondharava**

---

## ⭐ Conclusion

This project demonstrates a complete full-stack application with:

* Backend API development
* Frontend integration
* CRUD operations
* Real-world development workflow

---
