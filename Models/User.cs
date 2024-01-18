using TodoApi.ModelInterfaces;

namespace TodoApi.Models;

public class User : IUser
{
    public long Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
}