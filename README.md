# CRUDTodoApp

Ứng dụng Todo CRUD đơn giản sử dụng ASP.## 📁 Cấu trúc dự án

```
CRUDTodoApp/
├── client/                    # Angular frontend
│   ├── src/
│   │   ├── app/
│   │   └── styles.css
│   ├── angular.json
│   └── package.json
├── server/                    # .NET backend
│   ├── Controllers/           # API Controllers
│   │   └── TodosController.cs
│   ├── Models/               # Data models
│   │   ├── Todo.cs
│   │   └── DTOs/
│   │       └── TodoDtos.cs
│   ├── Services/             # Business logic
│   │   ├── ITodoService.cs
│   │   └── TodoService.cs
│   ├── Data/                 # Data access
│   │   └── AppDbContext.cs
│   ├── Migrations/           # EF migrations
│   ├── Program.cs           # Application entry point
│   └── CRUDTodoApp.csproj   # Project file
├── .gitignore
└── README.md
```ackend) + Angular + TailwindCSS (frontend)

## 🚀 Tech Stack

**Frontend:** Angular 20, TailwindCSS, TypeScript  
**Backend:** ASP.NET Core 9.0, Entity Framework Core, Swagger  
**Database:** SQL Server  

![Light Mode](LightMode.png)
![Dark Mode](DarkMode.png)

## 📋 Yêu cầu hệ thống

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Node.js 18+ và npm](https://nodejs.org/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Angular CLI](https://angular.io/cli): `npm install -g @angular/cli`

## 🔧 Hướng dẫn cài đặt

### 1. Clone Repository
```bash
git clone https://github.com/vuongsongtoan/crud-todo-app.git
cd crud-todo-app
```

### 2. Cài đặt Backend
```bash
cd server
dotnet restore
dotnet ef database update
dotnet run
```
Backend sẽ chạy tại: http://localhost:5014

### 3. Cài đặt Frontend
```bash
cd client
npm install
ng serve
```
Frontend sẽ chạy tại: http://localhost:4200

## 📚 API Documentation

Truy cập Swagger UI: http://localhost:5014/swagger

### Các endpoint chính:
- `GET /api/todos` - Lấy danh sách todos
- `POST /api/todos` - Tạo todo mới
- `PUT /api/todos/{id}` - Cập nhật todo
- `DELETE /api/todos/{id}` - Xóa todo

## � Cấu trúc dự án

```
CRUDTodoApp/
├── client/                    # Angular frontend
│   ├── src/
│   │   ├── app/
│   │   └── styles.css
│   ├── angular.json
│   └── package.json
├── server/                    # .NET backend
│   ├── Controllers/
│   ├── Data/
│   ├── Migrations/
│   ├── Program.cs
│   └── CRUDTodoApp.csproj
├── .gitignore
└── README.md
```

## �️ Development

### Build cho Production
```bash
# Backend
cd server
dotnet publish -c Release

# Frontend
cd client
ng build --configuration=production
```

## 🏗️ Kiến trúc

Dự án được xây dựng theo mô hình **MVC (Model-View-Controller)** và **Clean Architecture**:

- **Models**: Định nghĩa cấu trúc dữ liệu và DTOs
- **Controllers**: Xử lý HTTP requests và responses  
- **Services**: Business logic và xử lý nghiệp vụ
- **Data**: Data access layer với Entity Framework Core
- **DTOs**: Data Transfer Objects cho API communication

### Các tính năng kiến trúc:
- ✅ Separation of Concerns
- ✅ Dependency Injection
- ✅ Repository Pattern via EF Core
- ✅ Service Layer Pattern
- ✅ DTO Pattern for API
- ✅ Model Validation







