# CRUDTodoApp

Ứng dụng Todo Fullstack: ASP.NET Core Web API (backend) + Angular + TailwindCSS (frontend)

## Tech Stack

**Client:** Angular, TailwindCSS

**Server:** ASP.NET Core Web API, Entity Framework Core, Swagger

## Hướng dẫn chạy dự án

### Backend (Server)
```bash
cd server
  # Cài dotnet-ef nếu chưa có
  # dotnet tool install --global dotnet-ef
  # Xóa migration cũ, tạo migration mới nếu cần
  # dotnet ef migrations add InitTodoGuidCreatedAt --project ./CRUDTodoApp.csproj
  # dotnet ef database update --project ./CRUDTodoApp.csproj
  # Chạy API
 dotnet run --project ./CRUDTodoApp.csproj
```
### Frontend (Client)
```bash
cd client
npm install
ng serve
```
Truy cập tại: http://localhost:4200

## API Reference

Truy cập Swagger UI tại: http://localhost:5014/swagger/index.html





