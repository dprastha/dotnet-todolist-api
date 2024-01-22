using System.ComponentModel.DataAnnotations;

namespace TodoApi.Requests;

public class AuthRegister
{
    [Required, EmailAddress]
    public string? Email { get; set; }
    [Required, MinLength(8)]
    public string? Password { get; set; }
    // First name
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
}

public class Login
{
    [Required, EmailAddress]
    public required string Email { get; set; }
    [Required, MinLength(8)]
    public required string Password { get; set; }
}