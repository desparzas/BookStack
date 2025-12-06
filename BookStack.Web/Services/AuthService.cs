using System.Security.Cryptography;
using System.Text;
using BookStack.Web.Data;
using BookStack.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStack.Web.Services;

public class AuthService
{
    private readonly BookStackContext _context;

    public AuthService(BookStackContext context)
    {
        _context = context;
    }

    public async Task<User?> LoginAsync(string username, string password)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u => u.Username == username);

        if (user == null)
            return null;

        var passwordHash = HashPassword(password);
        if (user.PasswordHash != passwordHash)
            return null;

        user.LastLogin = DateTime.UtcNow;
        await _context.SaveChangesAsync();

        return user;
    }

    public async Task<(bool Success, string Message)> RegisterAsync(string username, string email, string password)
    {
        // Check if username already exists
        if (await _context.Users.AnyAsync(u => u.Username == username))
            return (false, "Username already exists");

        // Check if email already exists
        if (await _context.Users.AnyAsync(u => u.Email == email))
            return (false, "Email already exists");

        // Create new user
        var user = new User
        {
            Username = username,
            Email = email,
            PasswordHash = HashPassword(password),
            DateCreated = DateTime.UtcNow
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return (true, "Registration successful");
    }

    public static string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(password);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }
}
