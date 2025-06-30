using CRUDTodoApp.Models.DTOs;
using CRUDTodoApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUDTodoApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodosController : ControllerBase
    {
        private readonly ITodoService _todoService;

        public TodosController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoResponseDto>>> GetTodos()
        {
            var todos = await _todoService.GetAllTodosAsync();
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoResponseDto>> GetTodo(Guid id)
        {
            var todo = await _todoService.GetTodoByIdAsync(id);
            if (todo == null)
                return NotFound();
            
            return Ok(todo);
        }

        [HttpPost]
        public async Task<ActionResult<TodoResponseDto>> CreateTodo(CreateTodoDto createTodoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var todo = await _todoService.CreateTodoAsync(createTodoDto);
            return CreatedAtAction(nameof(GetTodo), new { id = todo.Id }, todo);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTodo(Guid id, UpdateTodoDto updateTodoDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var success = await _todoService.UpdateTodoAsync(id, updateTodoDto);
            if (!success)
                return NotFound();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(Guid id)
        {
            var success = await _todoService.DeleteTodoAsync(id);
            if (!success)
                return NotFound();

            return NoContent();
        }
    }
}
