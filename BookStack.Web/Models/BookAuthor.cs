namespace BookStack.Web.Models;

// Join table for Book-Author many-to-many relationship
public class BookAuthor
{
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;

    public int AuthorId { get; set; }
    public Author Author { get; set; } = null!;
}
