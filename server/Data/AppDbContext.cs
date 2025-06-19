using Microsoft.EntityFrameworkCore;
using System;

namespace CRUDTodoApp.Data
{
    public class Todo
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Todo> Todos { get; set; }
    }
}
