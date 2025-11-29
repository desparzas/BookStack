using System.ComponentModel.DataAnnotations;

namespace BookStack.Web.Models;

public class Author
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [StringLength(1000)]
    public string? Biography { get; set; }

    [StringLength(500)]
    public string? PhotoUrl { get; set; }

    // Navigation properties
    public List<BookAuthor> BookAuthors { get; set; } = new();
}
