using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Services;

public class UserService(Context context)
{
    private readonly Context _context = context;

    public async Task<User?> FindByEmail(string email)
    {
        return await _context.Users.Where(user => user.Email == email).FirstOrDefaultAsync();
    }

    public async Task Create(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }
}