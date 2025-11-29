using Microsoft.EntityFrameworkCore;
using BookStack.Web.Models;

namespace BookStack.Web.Data;

public class BookStackContext : DbContext
{
    public BookStackContext(DbContextOptions<BookStackContext> options)
        : base(options)
    {
    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Shelf> Shelves { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<BookAuthor> BookAuthors { get; set; }
    public DbSet<BookGenre> BookGenres { get; set; }
    public DbSet<ShelfBook> ShelfBooks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure Book-Author many-to-many relationship
        modelBuilder.Entity<BookAuthor>()
            .HasKey(ba => new { ba.BookId, ba.AuthorId });

        modelBuilder.Entity<BookAuthor>()
            .HasOne(ba => ba.Book)
            .WithMany(b => b.BookAuthors)
            .HasForeignKey(ba => ba.BookId);

        modelBuilder.Entity<BookAuthor>()
            .HasOne(ba => ba.Author)
            .WithMany(a => a.BookAuthors)
            .HasForeignKey(ba => ba.AuthorId);

        // Configure Book-Genre many-to-many relationship
        modelBuilder.Entity<BookGenre>()
            .HasKey(bg => new { bg.BookId, bg.GenreId });

        modelBuilder.Entity<BookGenre>()
            .HasOne(bg => bg.Book)
            .WithMany(b => b.BookGenres)
            .HasForeignKey(bg => bg.BookId);

        modelBuilder.Entity<BookGenre>()
            .HasOne(bg => bg.Genre)
            .WithMany(g => g.BookGenres)
            .HasForeignKey(bg => bg.GenreId);

        // Configure Shelf-Book many-to-many relationship
        modelBuilder.Entity<ShelfBook>()
            .HasKey(sb => new { sb.ShelfId, sb.BookId });

        modelBuilder.Entity<ShelfBook>()
            .HasOne(sb => sb.Shelf)
            .WithMany(s => s.ShelfBooks)
            .HasForeignKey(sb => sb.ShelfId);

        modelBuilder.Entity<ShelfBook>()
            .HasOne(sb => sb.Book)
            .WithMany(b => b.ShelfBooks)
            .HasForeignKey(sb => sb.BookId);

        // Configure Review-Book relationship
        modelBuilder.Entity<Review>()
            .HasOne(r => r.Book)
            .WithMany(b => b.Reviews)
            .HasForeignKey(r => r.BookId);
    }
}
