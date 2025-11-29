namespace BookStack.Web.Models;

// Join table for Shelf-Book many-to-many relationship
public class ShelfBook
{
    public int ShelfId { get; set; }
    public Shelf Shelf { get; set; } = null!;

    public int BookId { get; set; }
    public Book Book { get; set; } = null!;

    public ReadingStatus ReadingStatus { get; set; } = ReadingStatus.NotStarted;

    public DateTime DateAdded { get; set; } = DateTime.UtcNow;
}

public enum ReadingStatus
{
    NotStarted = 0,
    InProgress = 1,
    Completed = 2
}
