using CRUDTodoApp.Models;
using CRUDTodoApp.Models.DTOs;

namespace CRUDTodoApp.Services
{
    public interface ITodoService
    {
        Task<IEnumerable<TodoResponseDto>> GetAllTodosAsync();
        Task<TodoResponseDto?> GetTodoByIdAsync(Guid id);
        Task<TodoResponseDto> CreateTodoAsync(CreateTodoDto createTodoDto);
        Task<bool> UpdateTodoAsync(Guid id, UpdateTodoDto updateTodoDto);
        Task<bool> DeleteTodoAsync(Guid id);
    }
}
