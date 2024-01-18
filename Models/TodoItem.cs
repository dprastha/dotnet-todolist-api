using TodoApi.ModelInterfaces;

namespace TodoApi.Models;

public class TodoItem : ITodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}