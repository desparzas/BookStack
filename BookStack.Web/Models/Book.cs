using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStack.Web.Models;

public class Book
{
    public int Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; } = string.Empty;

    [StringLength(2000)]
    public string? Description { get; set; }

    [StringLength(20)]
    public string? ISBN { get; set; }

    [Range(1000, 9999)]
    public int? PublicationYear { get; set; }

    [StringLength(500)]
    public string? CoverImageUrl { get; set; }

    [Range(1, 10000)]
    public int? PageCount { get; set; }

    public DateTime DateAdded { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public List<BookAuthor> BookAuthors { get; set; } = new();
    public List<BookGenre> BookGenres { get; set; } = new();
    public List<ShelfBook> ShelfBooks { get; set; } = new();
    public List<Review> Reviews { get; set; } = new();
}
