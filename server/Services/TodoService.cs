using CRUDTodoApp.Data;
using CRUDTodoApp.Models;
using CRUDTodoApp.Models.DTOs;
using Microsoft.EntityFrameworkCore;

namespace CRUDTodoApp.Services
{
    public class TodoService : ITodoService
    {
        private readonly AppDbContext _context;

        public TodoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TodoResponseDto>> GetAllTodosAsync()
        {
            var todos = await _context.Todos
                .OrderBy(t => t.CreatedAt)
                .ToListAsync();

            return todos.Select(MapToResponseDto);
        }

        public async Task<TodoResponseDto?> GetTodoByIdAsync(Guid id)
        {
            var todo = await _context.Todos.FindAsync(id);
            return todo == null ? null : MapToResponseDto(todo);
        }

        public async Task<TodoResponseDto> CreateTodoAsync(CreateTodoDto createTodoDto)
        {
            var todo = new Todo
            {
                Id = Guid.NewGuid(),
                Title = createTodoDto.Title,
                IsCompleted = createTodoDto.IsCompleted,
                CreatedAt = DateTime.UtcNow
            };

            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();

            return MapToResponseDto(todo);
        }

        public async Task<bool> UpdateTodoAsync(Guid id, UpdateTodoDto updateTodoDto)
        {
            var existingTodo = await _context.Todos.FindAsync(id);
            if (existingTodo == null)
                return false;

            existingTodo.Title = updateTodoDto.Title;
            existingTodo.IsCompleted = updateTodoDto.IsCompleted;
            // Note: CreatedAt is not updated

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTodoAsync(Guid id)
        {
            var todo = await _context.Todos.FindAsync(id);
            if (todo == null)
                return false;

            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();
            return true;
        }

        private static TodoResponseDto MapToResponseDto(Todo todo)
        {
            return new TodoResponseDto
            {
                Id = todo.Id,
                Title = todo.Title,
                IsCompleted = todo.IsCompleted,
                CreatedAt = todo.CreatedAt
            };
        }
    }
}
