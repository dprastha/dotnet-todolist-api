namespace TodoApi.ModelInterfaces;

interface ITodoItem
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}