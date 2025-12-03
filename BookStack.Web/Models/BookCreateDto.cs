using System.ComponentModel.DataAnnotations;

namespace BookStack.Web.Models;

// DTO for creating new books
public class BookCreateDto
{
    [Required(ErrorMessage = "Title is required")]
    [StringLength(200, ErrorMessage = "Title must be less than 200 characters")]
    public string Title { get; set; } = string.Empty;

    [StringLength(2000, ErrorMessage = "Description must be less than 2000 characters")]
    public string? Description { get; set; }

    [StringLength(20, ErrorMessage = "ISBN must be less than 20 characters")]
    [RegularExpression(@"^\d{10}(\d{3})?$", ErrorMessage = "ISBN must be 10 or 13 digits")]
    public string? ISBN { get; set; }

    [Range(1000, 9999, ErrorMessage = "Publication year must be between 1000 and 9999")]
    public int? PublicationYear { get; set; }

    [StringLength(500)]
    public string? CoverImageUrl { get; set; }

    [Range(1, 10000, ErrorMessage = "Page count must be between 1 and 10000")]
    public int? PageCount { get; set; }

    [Required(ErrorMessage = "At least one author is required")]
    public List<int> AuthorIds { get; set; } = new();

    [Required(ErrorMessage = "At least one genre is required")]
    public List<int> GenreIds { get; set; } = new();
}
