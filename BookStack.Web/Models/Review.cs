using System.ComponentModel.DataAnnotations;

namespace BookStack.Web.Models;

public class Review
{
    public int Id { get; set; }

    public int BookId { get; set; }

    [Range(1, 5)]
    public int Rating { get; set; }

    [StringLength(2000)]
    public string? ReviewText { get; set; }

    public DateTime DateCreated { get; set; } = DateTime.UtcNow;

    public DateTime? DateModified { get; set; }

    // For future multi-user support
    public string? UserId { get; set; }

    // Navigation properties
    public Book Book { get; set; } = null!;
}
