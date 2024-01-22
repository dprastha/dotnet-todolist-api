using System.ComponentModel.DataAnnotations.Schema;
using TodoApi.ModelInterfaces;

namespace TodoApi.Models
{
    [Table("user")]
    public class User : IUser
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("email")]
        public required string Email { get; set; }
        [Column("password")]
        public required string Password { get; set; }
        [Column("first_name")]
        public required string FirstName { get; set; }
        [Column("last_name")]
        public required string LastName { get; set; }

        // User have list of TodoItem
        public List<TodoItem> TodoItems { get; set; } = [];
    }
}


