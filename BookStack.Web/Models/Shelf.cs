using System.ComponentModel.DataAnnotations;

namespace BookStack.Web.Models;

public class Shelf
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    public bool IsDefault { get; set; } = false;

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    // For future multi-user support
    public string? UserId { get; set; }

    // Navigation properties
    public List<ShelfBook> ShelfBooks { get; set; } = new();
}
