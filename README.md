# BookStack - Personal Library Management System

## Team Members
- David Esparza (Individual Development)
- ~~Arthur Weale~~ (No communication)
- ~~Jaime Santiago Herrera~~ (No communication)
- ~~Andrea Brenzink de Oliveira Ferreira~~ (Left the group)

## Project Overview
BookStack is a web application designed to help book enthusiasts organize, track, and manage their personal book collections. The application provides tools to catalog books, organize them into shelves, track reading progress, and write personal reviews.

## Technologies Used
- **Backend:** ASP.NET Core Web API (.NET 9)
- **Frontend:** Blazor Server with Razor Components
- **Database:** SQLite with Entity Framework Core 9.0
- **Styling:** Bootstrap 5

## Project Structure
```
BookStack.Web/
├── Components/
│   ├── Pages/
│   │   ├── Home.razor          # Dashboard with quick stats
│   │   ├── Books.razor         # Book catalog view
│   │   └── Shelves.razor       # Shelf management
│   └── Layout/
│       └── NavMenu.razor       # Navigation menu
├── Controllers/
│   ├── BooksController.cs      # Books API endpoints
│   └── ShelvesController.cs    # Shelves API endpoints
├── Data/
│   ├── BookStackContext.cs     # EF Core DbContext
│   └── SeedData.cs             # Initial data population
├── Models/
│   ├── Book.cs                 # Book entity
│   ├── Author.cs               # Author entity
│   ├── Genre.cs                # Genre entity
│   ├── Shelf.cs                # Shelf entity
│   ├── Review.cs               # Review entity
│   ├── BookAuthor.cs           # Many-to-many join table
│   ├── BookGenre.cs            # Many-to-many join table
│   └── ShelfBook.cs            # Many-to-many join table with reading status
└── Program.cs                  # Application configuration
```

## Features Implemented (W04 Checkpoint)

### ✅ Completed Features
1. **Data Models** - Complete entity models with relationships:
   - Book, Author, Genre, Shelf, Review
   - Many-to-many relationships (Book↔Author, Book↔Genre, Shelf↔Book)
   - Data validation with annotations

2. **Database Layer**:
   - DbContext with SQLite
   - Automatic database creation
   - Seed data with 10 books, 10 authors, 10 genres, 4 shelves

3. **Web API**:
   - BooksController (GET, POST, PUT, DELETE, Search)
   - ShelvesController (GET, POST, PUT, DELETE, AddBook, RemoveBook)
   - Async/await patterns throughout

4. **Blazor UI**:
   - Home page with dashboard and statistics
   - Books page with card-based layout
   - Shelves page with book organization
   - Responsive Bootstrap design

5. **Project Setup**:
   - Dependency injection configured
   - HttpClient for API calls
   - Navigation menu updated

## How to Run
```bash
cd BookStack.Web
dotnet run
```
Then navigate to `https://localhost:5001` or `http://localhost:5000`

## Database
The application uses SQLite with the database file `bookstack.db` created automatically on first run. Sample data includes:
- 10 books from various genres
- 10 authors
- 10 genres
- 4 default shelves (Want to Read, Currently Reading, Read, Favorites)
- 2 sample reviews

## API Endpoints

### Books
- `GET /api/books` - Get all books
- `GET /api/books/{id}` - Get book by ID
- `POST /api/books` - Create new book
- `PUT /api/books/{id}` - Update book
- `DELETE /api/books/{id}` - Delete book
- `GET /api/books/search?title=...&author=...&genre=...` - Search books

### Shelves
- `GET /api/shelves` - Get all shelves
- `GET /api/shelves/{id}` - Get shelf by ID
- `POST /api/shelves` - Create new shelf
- `PUT /api/shelves/{id}` - Update shelf
- `DELETE /api/shelves/{id}` - Delete shelf (non-default only)
- `POST /api/shelves/{shelfId}/books/{bookId}` - Add book to shelf
- `DELETE /api/shelves/{shelfId}/books/{bookId}` - Remove book from shelf

## Next Steps (Future Checkpoints)
- [ ] Add book creation dialog
- [ ] Implement book details page
- [ ] Add shelf management features
- [ ] Implement review creation/editing
- [ ] Add search functionality to UI
- [ ] User authentication with ASP.NET Identity
- [ ] Enhanced statistics and analytics
- [ ] Book cover upload functionality
- [ ] Export/import features

## Build Status
✅ Project builds successfully with no errors (1 warning about analyzer version)
