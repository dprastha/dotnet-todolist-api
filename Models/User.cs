using TodoApi.ModelInterfaces;

namespace TodoApi.Models;

public class User : IUser
{
    public long Id { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    // User have list of TodoItem
    public List<TodoItem> TodoItems { get; set; } = [];
}