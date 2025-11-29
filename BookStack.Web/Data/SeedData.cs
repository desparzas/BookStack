using BookStack.Web.Models;

namespace BookStack.Web.Data;

public static class SeedData
{
    public static void Initialize(BookStackContext context)
    {
        // Check if database already has data
        if (context.Books.Any())
        {
            return; // Database has been seeded
        }

        // Seed Genres
        var genres = new List<Genre>
        {
            new Genre { Name = "Fiction", Description = "Literary works based on imagination" },
            new Genre { Name = "Non-Fiction", Description = "Factual and informative works" },
            new Genre { Name = "Science Fiction", Description = "Speculative fiction based on science" },
            new Genre { Name = "Fantasy", Description = "Fiction with magical or supernatural elements" },
            new Genre { Name = "Mystery", Description = "Fiction dealing with solving crimes" },
            new Genre { Name = "Romance", Description = "Fiction focused on romantic relationships" },
            new Genre { Name = "Biography", Description = "Life stories of real people" },
            new Genre { Name = "Self-Help", Description = "Books for personal development" },
            new Genre { Name = "History", Description = "Books about historical events" },
            new Genre { Name = "Technology", Description = "Books about technology and computing" }
        };
        context.Genres.AddRange(genres);
        context.SaveChanges();

        // Seed Authors
        var authors = new List<Author>
        {
            new Author { Name = "J.K. Rowling", Biography = "British author, best known for Harry Potter series" },
            new Author { Name = "George Orwell", Biography = "English novelist and essayist" },
            new Author { Name = "J.R.R. Tolkien", Biography = "English writer and philologist, author of The Lord of the Rings" },
            new Author { Name = "Stephen King", Biography = "American author of horror, supernatural fiction" },
            new Author { Name = "Agatha Christie", Biography = "English writer known for detective novels" },
            new Author { Name = "Isaac Asimov", Biography = "American writer and professor of biochemistry" },
            new Author { Name = "Neil Gaiman", Biography = "English author of novels, comics, and films" },
            new Author { Name = "Malcolm Gladwell", Biography = "Canadian journalist and author" },
            new Author { Name = "Yuval Noah Harari", Biography = "Israeli public intellectual and historian" },
            new Author { Name = "Robert C. Martin", Biography = "American software engineer and author" }
        };
        context.Authors.AddRange(authors);
        context.SaveChanges();

        // Seed Default Shelves
        var shelves = new List<Shelf>
        {
            new Shelf { Name = "Want to Read", Description = "Books I want to read", IsDefault = true },
            new Shelf { Name = "Currently Reading", Description = "Books I am currently reading", IsDefault = true },
            new Shelf { Name = "Read", Description = "Books I have finished reading", IsDefault = true },
            new Shelf { Name = "Favorites", Description = "My favorite books", IsDefault = false }
        };
        context.Shelves.AddRange(shelves);
        context.SaveChanges();

        // Seed Books
        var books = new List<Book>
        {
            new Book
            {
                Title = "Harry Potter and the Philosopher's Stone",
                Description = "A young wizard's journey begins at Hogwarts",
                ISBN = "9780747532699",
                PublicationYear = 1997,
                PageCount = 223,
                CoverImageUrl = "https://m.media-amazon.com/images/I/81m1s4wIPML._SY466_.jpg"
            },
            new Book
            {
                Title = "1984",
                Description = "A dystopian social science fiction novel",
                ISBN = "9780451524935",
                PublicationYear = 1949,
                PageCount = 328,
                CoverImageUrl = "https://m.media-amazon.com/images/I/71kxa1-0mfL._SY466_.jpg"
            },
            new Book
            {
                Title = "The Lord of the Rings",
                Description = "Epic high-fantasy novel",
                ISBN = "9780618640157",
                PublicationYear = 1954,
                PageCount = 1178,
                CoverImageUrl = "https://m.media-amazon.com/images/I/71jLBXtWJWL._SY466_.jpg"
            },
            new Book
            {
                Title = "The Shining",
                Description = "Horror novel about a family in an isolated hotel",
                ISBN = "9780385121675",
                PublicationYear = 1977,
                PageCount = 447,
                CoverImageUrl = "https://m.media-amazon.com/images/I/91U7HNa2NQL._SY466_.jpg"
            },
            new Book
            {
                Title = "Murder on the Orient Express",
                Description = "Detective novel featuring Hercule Poirot",
                ISBN = "9780062693662",
                PublicationYear = 1934,
                PageCount = 256,
                CoverImageUrl = "https://m.media-amazon.com/images/I/71P6RanYEwL._SY466_.jpg"
            },
            new Book
            {
                Title = "Foundation",
                Description = "Science fiction novel about the fall of galactic empire",
                ISBN = "9780553293357",
                PublicationYear = 1951,
                PageCount = 255,
                CoverImageUrl = "https://m.media-amazon.com/images/I/81x4S0fTfUL._SY466_.jpg"
            },
            new Book
            {
                Title = "American Gods",
                Description = "Fantasy novel about old gods vs new gods",
                ISBN = "9780062572110",
                PublicationYear = 2001,
                PageCount = 635,
                CoverImageUrl = "https://m.media-amazon.com/images/I/91NPXkhIe+L._SY466_.jpg"
            },
            new Book
            {
                Title = "Outliers",
                Description = "The story of success",
                ISBN = "9780316017930",
                PublicationYear = 2008,
                PageCount = 309,
                CoverImageUrl = "https://m.media-amazon.com/images/I/71XhJ3gKFmL._SY466_.jpg"
            },
            new Book
            {
                Title = "Sapiens",
                Description = "A brief history of humankind",
                ISBN = "9780062316097",
                PublicationYear = 2011,
                PageCount = 443,
                CoverImageUrl = "https://m.media-amazon.com/images/I/71f5Qn6DMIL._SY466_.jpg"
            },
            new Book
            {
                Title = "Clean Code",
                Description = "A handbook of agile software craftsmanship",
                ISBN = "9780132350884",
                PublicationYear = 2008,
                PageCount = 464,
                CoverImageUrl = "https://m.media-amazon.com/images/I/51E2055ZGUL._SY466_.jpg"
            }
        };
        context.Books.AddRange(books);
        context.SaveChanges();

        // Seed Book-Author relationships
        var bookAuthors = new List<BookAuthor>
        {
            new BookAuthor { BookId = books[0].Id, AuthorId = authors[0].Id }, // Harry Potter - Rowling
            new BookAuthor { BookId = books[1].Id, AuthorId = authors[1].Id }, // 1984 - Orwell
            new BookAuthor { BookId = books[2].Id, AuthorId = authors[2].Id }, // LOTR - Tolkien
            new BookAuthor { BookId = books[3].Id, AuthorId = authors[3].Id }, // The Shining - King
            new BookAuthor { BookId = books[4].Id, AuthorId = authors[4].Id }, // Murder - Christie
            new BookAuthor { BookId = books[5].Id, AuthorId = authors[5].Id }, // Foundation - Asimov
            new BookAuthor { BookId = books[6].Id, AuthorId = authors[6].Id }, // American Gods - Gaiman
            new BookAuthor { BookId = books[7].Id, AuthorId = authors[7].Id }, // Outliers - Gladwell
            new BookAuthor { BookId = books[8].Id, AuthorId = authors[8].Id }, // Sapiens - Harari
            new BookAuthor { BookId = books[9].Id, AuthorId = authors[9].Id }  // Clean Code - Martin
        };
        context.BookAuthors.AddRange(bookAuthors);
        context.SaveChanges();

        // Seed Book-Genre relationships
        var bookGenres = new List<BookGenre>
        {
            new BookGenre { BookId = books[0].Id, GenreId = genres[3].Id }, // Harry Potter - Fantasy
            new BookGenre { BookId = books[1].Id, GenreId = genres[2].Id }, // 1984 - Sci-Fi
            new BookGenre { BookId = books[2].Id, GenreId = genres[3].Id }, // LOTR - Fantasy
            new BookGenre { BookId = books[3].Id, GenreId = genres[0].Id }, // The Shining - Fiction
            new BookGenre { BookId = books[4].Id, GenreId = genres[4].Id }, // Murder - Mystery
            new BookGenre { BookId = books[5].Id, GenreId = genres[2].Id }, // Foundation - Sci-Fi
            new BookGenre { BookId = books[6].Id, GenreId = genres[3].Id }, // American Gods - Fantasy
            new BookGenre { BookId = books[7].Id, GenreId = genres[1].Id }, // Outliers - Non-Fiction
            new BookGenre { BookId = books[8].Id, GenreId = genres[8].Id }, // Sapiens - History
            new BookGenre { BookId = books[9].Id, GenreId = genres[9].Id }  // Clean Code - Technology
        };
        context.BookGenres.AddRange(bookGenres);
        context.SaveChanges();

        // Seed some books to shelves
        var shelfBooks = new List<ShelfBook>
        {
            new ShelfBook { ShelfId = shelves[2].Id, BookId = books[0].Id, ReadingStatus = ReadingStatus.Completed }, // Harry Potter - Read
            new ShelfBook { ShelfId = shelves[1].Id, BookId = books[1].Id, ReadingStatus = ReadingStatus.InProgress }, // 1984 - Currently Reading
            new ShelfBook { ShelfId = shelves[0].Id, BookId = books[2].Id, ReadingStatus = ReadingStatus.NotStarted }, // LOTR - Want to Read
            new ShelfBook { ShelfId = shelves[2].Id, BookId = books[9].Id, ReadingStatus = ReadingStatus.Completed }  // Clean Code - Read
        };
        context.ShelfBooks.AddRange(shelfBooks);
        context.SaveChanges();

        // Seed some reviews
        var reviews = new List<Review>
        {
            new Review
            {
                BookId = books[0].Id,
                Rating = 5,
                ReviewText = "An amazing start to a magical series! Loved every page.",
                DateCreated = DateTime.UtcNow.AddDays(-30)
            },
            new Review
            {
                BookId = books[9].Id,
                Rating = 5,
                ReviewText = "Essential reading for any software developer. Changed how I write code.",
                DateCreated = DateTime.UtcNow.AddDays(-10)
            }
        };
        context.Reviews.AddRange(reviews);
        context.SaveChanges();
    }
}
