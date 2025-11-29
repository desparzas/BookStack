using System.ComponentModel.DataAnnotations;

namespace BookStack.Web.Models;

public class Genre
{
    public int Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;

    [StringLength(500)]
    public string? Description { get; set; }

    // Navigation properties
    public List<BookGenre> BookGenres { get; set; } = new();
}
