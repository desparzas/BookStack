# BookStack - Personal Library Management System

[![.NET Version](https://img.shields.io/badge/.NET-9.0-512BD4)](https://dotnet.microsoft.com/)
[![Blazor](https://img.shields.io/badge/Blazor-Server-512BD4)](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)
[![License](https://img.shields.io/badge/License-Educational-blue)](LICENSE)

A comprehensive personal library management system built with ASP.NET Core 9.0, Blazor Server, and Entity Framework Core.

## 📚 Project Information

**Course:** CSE 325 - .NET Development
**Institution:** BYU
**Term:** 2025 Term 6
**Project Type:** Group Project (Individual Development)

### Team Members
- **David Esparza** (Primary Developer - Working individually)
- ~~Arthur Weale~~ (No communication)
- ~~Jaime Santiago Herrera~~ (No communication)
- ~~Andrea Brenzink de Oliveira Ferreira~~ (Left the group)

### Project Links
- **GitHub Repository:** https://github.com/desparzas/BookStack
- **Azure DevOps Board:** [Your Azure DevOps URL]
- **Live Demo:** [Your deployed URL]

---

## 🎯 Project Overview

BookStack is a modern web application designed to help book enthusiasts organize, track, and manage their personal book collections. The application provides comprehensive tools to catalog books, organize them into shelves, track reading progress, write reviews, and manage user accounts.

### Key Features
- 📖 **Book Management** - Add, view, and organize books with detailed information
- 👤 **User Authentication** - Secure registration and login system
- 📚 **Smart Shelves** - Organize books into customizable reading lists
- ⭐ **Reviews & Ratings** - Write and manage book reviews with star ratings
- 🔍 **Book Details** - Comprehensive view of book information, authors, genres, and reviews
- 📊 **Dashboard** - Quick statistics and overview of your library
- 🎨 **Modern UI** - Responsive design with Bootstrap 5

---

## 🛠️ Technologies Used

### Backend
- **ASP.NET Core 9.0** - Web API and application framework
- **Entity Framework Core 9.0** - ORM for database operations
- **SQLite** - Lightweight relational database
- **C# 13** - Programming language

### Frontend
- **Blazor Server** - Interactive web UI framework
- **Razor Components** - Component-based architecture
- **Bootstrap 5** - Responsive CSS framework
- **Bootstrap Icons** - Icon library

### Development Tools
- **Visual Studio Code / Visual Studio 2022**
- **Git & GitHub** - Version control
- **Azure DevOps** - Project management
- **.NET CLI** - Build and development tools

---

## 📂 Project Structure

```
BookStack/
├── BookStack.Web/                    # Main web application
│   ├── Components/
│   │   ├── Pages/
│   │   │   ├── Home.razor           # Dashboard with statistics
│   │   │   ├── Books.razor          # Book catalog with add dialog
│   │   │   ├── BookDetails.razor    # Detailed book view
│   │   │   ├── Shelves.razor        # Shelf management
│   │   │   ├── Login.razor          # User login page
│   │   │   └── Register.razor       # User registration page
│   │   ├── Dialogs/
│   │   │   └── AddBookDialog.razor  # Modal dialog for adding books
│   │   └── Layout/
│   │       ├── MainLayout.razor     # Main application layout
│   │       └── NavMenu.razor        # Navigation sidebar with auth
│   ├── Controllers/
│   │   ├── BooksController.cs       # RESTful API for books
│   │   └── ShelvesController.cs     # RESTful API for shelves
│   ├── Data/
│   │   ├── BookStackContext.cs      # EF Core DbContext
│   │   └── SeedData.cs              # Database seeding
│   ├── Models/
│   │   ├── Book.cs                  # Book entity
│   │   ├── Author.cs                # Author entity
│   │   ├── Genre.cs                 # Genre entity
│   │   ├── Shelf.cs                 # Shelf entity
│   │   ├── Review.cs                # Review entity
│   │   ├── User.cs                  # User entity (authentication)
│   │   ├── BookCreateDto.cs         # DTO for book creation
│   │   ├── BookAuthor.cs            # Many-to-many join table
│   │   ├── BookGenre.cs             # Many-to-many join table
│   │   └── ShelfBook.cs             # Many-to-many join with status
│   ├── Services/
│   │   ├── AuthService.cs           # Authentication logic
│   │   └── AuthStateService.cs      # Auth state management
│   ├── wwwroot/                     # Static assets
│   ├── Program.cs                   # Application configuration
│   └── BookStack.Web.csproj         # Project file
├── W04_CHECKPOINT.md                # Week 4 documentation
├── W05_FINAL_REPORT.txt             # Week 5 documentation
├── W06_CHECKPOINT_REPORT.txt        # Week 6 documentation
├── USER_GUIDE.md                    # User documentation
└── README.md                        # This file
```

---

## ✅ Features Implemented

### Week 04 - Initial Setup
- ✅ Complete entity models with relationships
- ✅ SQLite database with Entity Framework Core
- ✅ RESTful Web API controllers
- ✅ Blazor Server UI with pages for Books and Shelves
- ✅ Seed data with 10 books, 10 authors, 10 genres, 4 shelves
- ✅ Azure DevOps board setup
- ✅ GitHub repository with initial commit

### Week 05 - Book Creation Dialog
- ✅ Add Book modal dialog component
- ✅ Form validation with DataAnnotations
- ✅ Multi-select for authors and genres
- ✅ Cover image URL input
- ✅ EventCallback pattern for component communication
- ✅ Many-to-many relationship creation

### Week 06 - Details & Authentication
- ✅ Book Details page with comprehensive information
- ✅ Navigation from Books list to details
- ✅ Review display and deletion
- ✅ User entity and authentication system
- ✅ Registration page with validation
- ✅ Login page with credentials verification
- ✅ Password hashing with SHA256
- ✅ Authentication state management
- ✅ Navigation menu with login/logout
- ✅ Demo user accounts seeded

---

## 🚀 Getting Started

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- Modern web browser (Chrome, Firefox, Edge, Safari)
- Git (optional, for cloning)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/desparzas/BookStack.git
   cd BookStack
   ```

2. **Navigate to the project directory**
   ```bash
   cd BookStack.Web
   ```

3. **Restore dependencies**
   ```bash
   dotnet restore
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Open in browser**
   - Navigate to `https://localhost:5001` or `http://localhost:5000`
   - The database will be created automatically on first run
   - Sample data will be seeded automatically

### Demo Credentials
For testing, use these pre-seeded accounts:

**Demo User:**
- Username: `demo`
- Password: `demo123`

**Personal Account:**
- Username: `david`
- Password: `password123`

---

## 🗄️ Database Schema

### Entities

**Book**
- Id, Title, ISBN, PublicationYear, Description, CoverImageUrl, AverageRating

**Author**
- Id, Name, Biography

**Genre**
- Id, Name, Description

**Shelf**
- Id, Name, Description, IsDefault

**Review**
- Id, BookId, Rating, ReviewText, DateCreated

**User**
- Id, Username, Email, PasswordHash, DateCreated, LastLogin

### Relationships

- **Book ↔ Author** (Many-to-Many via BookAuthor)
- **Book ↔ Genre** (Many-to-Many via BookGenre)
- **Shelf ↔ Book** (Many-to-Many via ShelfBook with ReadingStatus)
- **Book → Review** (One-to-Many)

---

## 🌐 API Endpoints

### Books API (`/api/books`)

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/books` | Get all books with authors and genres |
| GET | `/api/books/{id}` | Get book by ID with full details |
| POST | `/api/books` | Create new book |
| PUT | `/api/books/{id}` | Update existing book |
| DELETE | `/api/books/{id}` | Delete book |
| GET | `/api/books/search` | Search books by title/author/genre |

### Shelves API (`/api/shelves`)

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/shelves` | Get all shelves with books |
| GET | `/api/shelves/{id}` | Get shelf by ID with books |
| POST | `/api/shelves` | Create new shelf |
| PUT | `/api/shelves/{id}` | Update shelf |
| DELETE | `/api/shelves/{id}` | Delete shelf (non-default only) |
| POST | `/api/shelves/{shelfId}/books/{bookId}` | Add book to shelf |
| DELETE | `/api/shelves/{shelfId}/books/{bookId}` | Remove book from shelf |

---

## 💻 Development

### Build the Project
```bash
dotnet build
```

### Run Tests (Coming Soon)
```bash
dotnet test
```

### Clean Build
```bash
dotnet clean
dotnet build
```

### Reset Database
Delete the `bookstack.db` file and restart the application to recreate with seed data.

```bash
# Windows (PowerShell)
Remove-Item bookstack.db*

# Linux/Mac
rm bookstack.db*

# Then run the app
dotnet run
```

---

## 📱 User Interface

### Pages

1. **Home** (`/`)
   - Dashboard with library statistics
   - Quick navigation cards
   - Overview of total books, authors, genres, shelves

2. **Books** (`/books`)
   - Card-based book catalog
   - Add new book button (opens dialog)
   - View details button for each book
   - Search functionality (coming soon)

3. **Book Details** (`/books/{id}`)
   - Full book information
   - Authors and genres
   - Reviews section
   - Shelves containing the book
   - Breadcrumb navigation

4. **Shelves** (`/shelves`)
   - List of all shelves
   - Books organized by shelf
   - Add/remove books from shelves
   - Reading status tracking

5. **Login** (`/login`)
   - User authentication
   - Demo credentials displayed
   - Error handling

6. **Register** (`/register`)
   - New user registration
   - Form validation
   - Password confirmation
   - Success redirect to login

### Components

**AddBookDialog**
- Modal dialog for adding books
- Multi-select authors and genres
- Form validation
- Cover image URL input
- Success/error messaging

**NavMenu**
- Responsive sidebar navigation
- Authentication state display
- Login/logout buttons
- Username display when authenticated

---

## 🔒 Security

### Authentication
- SHA256 password hashing (basic implementation for demo)
- Username/password based authentication
- Session state management via AuthStateService
- Protected routes (planned)

### Future Security Enhancements
- Migrate to bcrypt or Argon2id for password hashing
- Add password salt per user
- Implement JWT tokens
- Add email verification
- Rate limiting on login attempts
- CSRF protection
- Security headers (CSP, HSTS)

---

## 🎨 Design Patterns

### Architecture Patterns
- **Repository Pattern** - DbContext as data access layer
- **DTO Pattern** - BookCreateDto for API inputs
- **Service Layer** - AuthService, AuthStateService
- **Event-Driven** - OnAuthStateChanged events
- **Component-Based** - Blazor components for UI

### Best Practices
- Async/await throughout
- Dependency injection
- Data validation with annotations
- Proper error handling
- Responsive design
- Semantic HTML
- Accessibility considerations

---

## 📊 Database Seed Data

The application automatically seeds the following data on first run:

- **10 Books**: Harry Potter, 1984, Lord of the Rings, The Shining, Murder on the Orient Express, Foundation, American Gods, Outliers, Sapiens, Clean Code
- **10 Authors**: J.K. Rowling, George Orwell, J.R.R. Tolkien, Stephen King, Agatha Christie, Isaac Asimov, Neil Gaiman, Malcolm Gladwell, Yuval Noah Harari, Robert C. Martin
- **10 Genres**: Fiction, Non-Fiction, Science Fiction, Fantasy, Mystery, Romance, Biography, Self-Help, History, Technology
- **4 Shelves**: Want to Read, Currently Reading, Read, Favorites
- **2 Reviews**: Sample reviews for Harry Potter and Clean Code
- **2 Users**: demo and david with hashed passwords

---

## 🚀 Deployment

### Local Deployment
The application runs locally using Kestrel web server on:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`

### Cloud Deployment (Azure App Service)
*Deployment instructions coming soon*

1. Publish the application
2. Configure Azure App Service
3. Deploy via Git or FTP
4. Configure connection strings
5. Set environment variables

---

## 📈 Future Enhancements

### Planned Features
- [ ] User-specific shelves (associate shelves with users)
- [ ] Review editing functionality
- [ ] Advanced search with filters
- [ ] Reading statistics and analytics
- [ ] Book cover image upload
- [ ] Import from Goodreads
- [ ] Export library to CSV/Excel
- [ ] Reading goals and progress tracking
- [ ] Social features (follow users, share lists)
- [ ] Email notifications
- [ ] Dark mode
- [ ] Mobile app (MAUI)
- [ ] Barcode scanning for book addition
- [ ] Recommendation engine
- [ ] Book series tracking
- [ ] Public vs private shelves
- [ ] Comments on reviews
- [ ] ISBN API integration for automatic book data

### Technical Improvements
- [ ] Unit tests
- [ ] Integration tests
- [ ] E2E tests
- [ ] Performance optimization
- [ ] Caching layer
- [ ] Database migrations
- [ ] Logging and monitoring
- [ ] CI/CD pipeline
- [ ] Docker containerization
- [ ] Kubernetes deployment

---

## 🧪 Testing

### Manual Testing Checklist
- ✅ User registration with validation
- ✅ User login with credentials
- ✅ Logout functionality
- ✅ Add new book with dialog
- ✅ View book details
- ✅ Add book to shelf
- ✅ Remove book from shelf
- ✅ Delete review
- ✅ Navigation between pages
- ✅ Authentication state persistence

### Automated Testing (Planned)
- Unit tests for services
- Integration tests for API endpoints
- Component tests for Blazor pages
- E2E tests for user workflows

---

## 📝 Documentation

- **[USER_GUIDE.md](USER_GUIDE.md)** - Comprehensive user documentation
- **[W04_CHECKPOINT.md](W04_CHECKPOINT.md)** - Week 4 checkpoint documentation
- **[W05_FINAL_REPORT.txt](W05_FINAL_REPORT.txt)** - Week 5 detailed report
- **[W06_CHECKPOINT_REPORT.txt](W06_CHECKPOINT_REPORT.txt)** - Week 6 detailed report
- **Code Comments** - Inline documentation throughout the codebase

---

## 🤝 Contributing

This is an educational project for BYU CSE 325. Contributions are not currently accepted as this is a graded assignment.

---

## 📄 License

This project is for educational purposes as part of BYU CSE 325 course.

---

## 👨‍💻 Developer

**David Esparza**
- Course: CSE 325 - .NET Development
- Institution: BYU
- Term: 2025 Term 6
- GitHub: [@desparzas](https://github.com/desparzas)

---

## 🙏 Acknowledgments

- BYU CSE 325 course instructors
- Microsoft .NET documentation
- Blazor community resources
- Bootstrap framework
- Entity Framework Core documentation

---

## 📞 Support

For issues, questions, or support:
- GitHub Issues: [Report an issue](https://github.com/desparzas/BookStack/issues)
- Azure DevOps: Use the project board
- Course Portal: Contact through BYU portal

---

## 📜 Version History

### v1.0.0 (Week 06 - December 2024)
- Complete user authentication system
- Book details page
- Review management
- Navigation integration
- Demo user accounts

### v0.2.0 (Week 05 - November 2024)
- Add Book dialog component
- Form validation
- Multi-select functionality

### v0.1.0 (Week 04 - November 2024)
- Initial project setup
- Database schema and models
- RESTful API
- Basic Blazor UI
- Seed data

---

## 🏗️ Build Status

✅ **Build:** Successful (0 errors, 0 warnings)
✅ **Database:** SQLite - Auto-created with seed data
✅ **Tests:** Manual testing complete
✅ **Deployment:** Ready for cloud deployment

---

**Last Updated:** December 5, 2024
**Version:** 1.0.0
**Status:** ✅ Production Ready (Educational Demo)

---

*Built with ❤️ using ASP.NET Core and Blazor Server*
