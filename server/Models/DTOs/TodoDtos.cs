using System.ComponentModel.DataAnnotations;

namespace CRUDTodoApp.Models.DTOs
{
    public class CreateTodoDto
    {
        [Required(ErrorMessage = "Title is required")]
        [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
        public required string Title { get; set; }

        public bool IsCompleted { get; set; } = false;
    }

    public class UpdateTodoDto
    {
        [Required(ErrorMessage = "Title is required")]
        [StringLength(200, ErrorMessage = "Title cannot exceed 200 characters")]
        public required string Title { get; set; }

        public bool IsCompleted { get; set; }
    }

    public class TodoResponseDto
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
