using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<TodoItem> TodoItems { get; set; }

    public DbSet<User> Users { get; set; }
}