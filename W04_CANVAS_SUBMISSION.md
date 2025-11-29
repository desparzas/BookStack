# W04 Team Activity: Project Checkpoint - BookStack

## Team Members
- Arthur Weale
- Jaime Santiago Herrera
- David Esparza

---

## Meeting Summary

### Meeting Details
- **Date:** November 29, 2024
- **Format:** Individual work (no group meeting held)

### Participants
- David Esparza

### Summary of Activity

Due to continued lack of communication from team members, this week's checkpoint was completed individually. Andrea Brenzink de Oliveira Ferreira had previously left the group, and despite multiple attempts to coordinate with Arthur Weale and Jaime Santiago Herrera, there was no response or participation from either member.

Given the project requirements and deadline, I proceeded with development independently, making significant progress on the BookStack application infrastructure and core features.

---

## Work Completed This Week

### 1. Project Infrastructure (Week 4 Progress)
- Created Blazor Server application with .NET 9
- Configured Entity Framework Core with SQLite
- Set up project folder structure (Models, Controllers, Data, Components)
- Added all required NuGet packages

### 2. Database Implementation
- Created 7 entity models with data validation:
  - Book, Author, Genre, Shelf, Review
  - BookAuthor, BookGenre, ShelfBook (join tables)
- Configured DbContext with Fluent API for many-to-many relationships
- Implemented comprehensive seed data:
  - 10 sample books (Harry Potter, 1984, LOTR, Clean Code, etc.)
  - 10 authors
  - 10 genres
  - 4 default shelves
  - Sample relationships and reviews

### 3. REST API Development
- **BooksController** - 6 endpoints:
  - GET /api/books (list all)
  - GET /api/books/{id} (single book)
  - POST /api/books (create)
  - PUT /api/books/{id} (update)
  - DELETE /api/books/{id} (delete)
  - GET /api/books/search (search by title/author/genre)

- **ShelvesController** - 7 endpoints:
  - Full CRUD operations
  - Add/remove books from shelves
  - Shelf management with default shelf protection

### 4. Blazor UI Components
- **Home.razor** - Dashboard with feature cards and statistics
- **Books.razor** - Book catalog with card layout showing covers, authors, genres, ratings
- **Shelves.razor** - Shelf management with book organization and reading status
- Updated navigation menu

### 5. Configuration & Integration
- Configured dependency injection in Program.cs
- Set up database initialization with automatic seeding
- Configured Blazor Server with interactive rendering
- Mapped API controllers and Razor components

---

## Challenges, Success, and Insights

### Challenges
1. **Team Coordination:** Complete lack of communication from team members required individual effort
2. **OpenAPI Compatibility:** Initial version incompatibility resolved by using simpler API setup
3. **Many-to-Many Relationships:** Required careful configuration with Fluent API for proper database schema
4. **Time Management:** Balancing comprehensive implementation with deadline constraints

### Successes
1. **Complete Working Application:** Built end-to-end functional application from scratch
2. **Database Design:** Successfully implemented complex relationships with seed data
3. **API Implementation:** Created RESTful API following best practices
4. **UI/UX:** Responsive Blazor pages with Bootstrap styling
5. **Build Status:** ✅ Project builds successfully with zero errors

### Insights
1. **Entity Framework Power:** EF Core's Fluent API provides elegant solutions for complex relationships
2. **Blazor Productivity:** Interactive server-side rendering simplifies development
3. **Async Patterns:** Consistent use of async/await improves scalability
4. **Code Organization:** Clear separation of concerns (Models, Controllers, Data, UI) aids maintainability
5. **Seed Data Value:** Comprehensive sample data crucial for testing and demonstration

---

## Technical Achievements

- ✅ 7 data models with validation annotations
- ✅ 3 many-to-many relationships configured
- ✅ 13 RESTful API endpoints
- ✅ 3 interactive Blazor pages
- ✅ SQLite database with EF Core
- ✅ Automatic database seeding
- ✅ Dependency injection configured
- ✅ Responsive Bootstrap UI

---

## Project Links

### GitHub Repository
**URL:** https://github.com/desparzas/BookStack

### Azure DevOps Project Board
**URL:** [TO BE INSERTED - Create Azure DevOps project and paste link here]

Example format: `https://dev.azure.com/{your-org}/BookStack`

**Note:** Azure DevOps board contains 8 User Stories:
- 5 completed and assigned to David Esparza (State: Done)
- 3 pending for future development (State: New, Unassigned)

---

## Work Items Summary (Azure DevOps)

### Completed Work Items (Assigned to David Esparza)
1. **Setup Project Infrastructure** - Done
2. **Implement Data Models** - Done
3. **Setup Database Layer** - Done
4. **Build REST API Controllers** - Done
5. **Create Blazor UI Components** - Done

### Pending Work Items (Unassigned)
6. **Add Book Creation Dialog** - New
7. **Implement Book Details Page** - New
8. **Add User Authentication** - New

---

## Next Steps

Planned features for future checkpoints:
1. Book creation dialog with form validation
2. Book details page with full information
3. Review creation and editing UI
4. Search functionality in frontend
5. User authentication with ASP.NET Identity
6. Enhanced statistics dashboard
7. Book cover image upload
8. Data export/import functionality

---

## Build & Run Instructions

To run the application:

```bash
cd BookStack.Web
dotnet build
dotnet run
```

Navigate to: `http://localhost:5159`

The database will be created automatically with sample data on first run.

---

## Documentation

Complete project documentation available in:
- **README.md** - Technical documentation and API reference
- **AZURE_DEVOPS_SETUP_GUIDE.md** - Step-by-step guide for Azure DevOps setup

---

**Submitted by:** David Esparza
**Submission Date:** November 29, 2024
**Course:** CSE 325 - .NET Development
**Assignment:** W04 Team Activity: Project Checkpoint
