# CRUDTodoApp

Ứng dụng Todo CRUD đơn giản sử dụng ASP.NET Core Web API (backend) + Angular + TailwindCSS (frontend)

## 🚀 Tech Stack

**Frontend:** Angular 20, TailwindCSS, TypeScript  
**Backend:** ASP.NET Core 8.0, Entity Framework Core, Swagger  
**Database:** SQL Server  

![Light Mode](LightMode.png)
![Dark Mode](DarkMode.png)

## 📋 Yêu cầu hệ thống

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
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

## ✨ Tính năng

- ✅ Thêm, sửa, xóa, xem todo
- ✅ Dark/Light mode
- ✅ Responsive design với TailwindCSS
- ✅ RESTful API với Swagger documentation
- ✅ Entity Framework Core với SQL Server

## 🤝 Contributing

1. Fork repository
2. Tạo feature branch: `git checkout -b feature/ten-tinh-nang`
3. Commit thay đổi: `git commit -m 'Thêm tính năng mới'`
4. Push lên branch: `git push origin feature/ten-tinh-nang`
5. Tạo Pull Request

## 📄 License

Dự án này sử dụng giấy phép MIT License.





