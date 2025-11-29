# Azure DevOps Setup Guide - BookStack Project

## Step-by-Step Instructions

### 1. Create Azure DevOps Account and Organization

1. Go to [dev.azure.com](https://dev.azure.com)
2. Sign in with your Microsoft account (or create one)
3. If this is your first time, create an organization name (e.g., "david-esparza" or "byucse325")
4. Click **Continue**

### 2. Create the BookStack Project

1. Click **+ New project** (top right)
2. Fill in the form:
   - **Project name:** `BookStack`
   - **Description:** `Personal Library Management System - CSE 325 Group Project`
   - **Visibility:** **Public** (required for instructor access)
   - **Version control:** Git
   - **Work item process:** Agile
3. Click **Create**

### 3. Configure Board Settings (Optional but Recommended)

1. Go to **Project Settings** (bottom left gear icon)
2. Click **Team configuration** → **Iterations**
3. Add iterations if needed (e.g., Sprint 1, Sprint 2)

### 4. Create Work Items

Navigate to **Boards** → **Work Items** → **+ New Work Item** → **User Story**

#### Work Item 1: Setup Project Infrastructure

**Type:** User Story
**Title:** Setup Project Infrastructure
**State:** Done
**Assigned To:** David Esparza
**Description:**
```
Create the foundational structure for the BookStack application including:
- Blazor Server project with .NET 9
- Entity Framework Core with SQLite
- Project folder organization
- NuGet package dependencies
```

**Acceptance Criteria:**
- [x] Blazor Server project created
- [x] EF Core packages installed (Sqlite, Design, Tools)
- [x] Folder structure created (Models, Controllers, Data, Services)
- [x] Project builds successfully

**Tasks to add (under this work item):**
- Create Blazor Server application
- Add Microsoft.EntityFrameworkCore.Sqlite 9.0.0
- Add Microsoft.EntityFrameworkCore.Design 9.0.0
- Add Microsoft.EntityFrameworkCore.Tools 9.0.0
- Create folder structure

---

#### Work Item 2: Implement Data Models

**Type:** User Story
**Title:** Implement Data Models
**State:** Done
**Assigned To:** David Esparza
**Description:**
```
Create all entity models with proper validation attributes and navigation properties for the BookStack application.
```

**Models to implement:**
- Book (Title, Description, ISBN, PublicationYear, etc.)
- Author (Name, Biography, PhotoUrl)
- Genre (Name, Description)
- Shelf (Name, Description, IsDefault)
- Review (Rating, ReviewText, DateCreated)
- BookAuthor (many-to-many join table)
- BookGenre (many-to-many join table)
- ShelfBook (many-to-many join table with ReadingStatus)

**Acceptance Criteria:**
- [x] All 8 models created with data annotations
- [x] Navigation properties configured
- [x] ReadingStatus enum defined
- [x] Models follow best practices

---

#### Work Item 3: Setup Database Layer

**Type:** User Story
**Title:** Setup Database Layer
**State:** Done
**Assigned To:** David Esparza
**Description:**
```
Configure Entity Framework Core DbContext with relationship mappings and create seed data for initial testing.
```

**Acceptance Criteria:**
- [x] BookStackContext created with DbSet properties
- [x] Many-to-many relationships configured using Fluent API
- [x] SeedData class implemented with:
  - 10 sample books
  - 10 authors
  - 10 genres
  - 4 default shelves
  - Sample relationships
  - 2 sample reviews
- [x] Database initialization configured in Program.cs
- [x] Database creates and seeds successfully on first run

---

#### Work Item 4: Build REST API Controllers

**Type:** User Story
**Title:** Build REST API Controllers
**State:** Done
**Assigned To:** David Esparza
**Description:**
```
Implement Web API controllers for Books and Shelves with full CRUD operations and additional functionality.
```

**Acceptance Criteria:**
- [x] BooksController created with endpoints:
  - GET /api/books (list all with includes)
  - GET /api/books/{id} (single book details)
  - POST /api/books (create new book)
  - PUT /api/books/{id} (update book)
  - DELETE /api/books/{id} (delete book)
  - GET /api/books/search (search by title/author/genre)
- [x] ShelvesController created with endpoints:
  - GET /api/shelves (list all with books)
  - GET /api/shelves/{id} (single shelf)
  - POST /api/shelves (create shelf)
  - PUT /api/shelves/{id} (update shelf)
  - DELETE /api/shelves/{id} (delete non-default shelf)
  - POST /api/shelves/{shelfId}/books/{bookId} (add book to shelf)
  - DELETE /api/shelves/{shelfId}/books/{bookId} (remove book from shelf)
- [x] All endpoints use async/await
- [x] Proper HTTP status codes returned
- [x] Include navigation properties in responses

---

#### Work Item 5: Create Blazor UI Components

**Type:** User Story
**Title:** Create Blazor UI Components
**State:** Done
**Assigned To:** David Esparza
**Description:**
```
Build interactive Blazor Server pages for the BookStack application with responsive design.
```

**Acceptance Criteria:**
- [x] Home.razor updated with:
  - Welcome section with feature cards
  - Quick statistics dashboard
  - Navigation to main features
- [x] Books.razor created with:
  - Card-based book display
  - Book covers, titles, authors
  - Genre badges
  - Star ratings display
  - Review counts
- [x] Shelves.razor created with:
  - Shelf list with book counts
  - Books on each shelf
  - Reading status badges
  - Delete shelf functionality
- [x] NavMenu.razor updated with Books and Shelves links
- [x] All pages use @rendermode InteractiveServer
- [x] Bootstrap styling applied
- [x] Responsive design works on mobile

---

#### Work Item 6: Add Book Creation Dialog

**Type:** User Story
**Title:** Add Book Creation Dialog
**State:** New
**Assigned To:** Unassigned
**Priority:** 2
**Description:**
```
Implement a modal dialog that allows users to add new books to the library with all required information.
```

**Acceptance Criteria:**
- [ ] Modal component created
- [ ] Form includes: Title, Author(s), Genre(s), ISBN, Year, Pages, Cover URL, Description
- [ ] Form validation implemented
- [ ] Author autocomplete/selection
- [ ] Genre multi-select
- [ ] API integration to POST new book
- [ ] Success/error notifications
- [ ] Modal closes on success
- [ ] Book list refreshes after adding

---

#### Work Item 7: Implement Book Details Page

**Type:** User Story
**Title:** Implement Book Details Page
**State:** New
**Assigned To:** Unassigned
**Priority:** 2
**Description:**
```
Create a detailed view page for individual books showing full information, reviews, and actions.
```

**Acceptance Criteria:**
- [ ] BookDetails.razor page created
- [ ] Route: /books/{id}
- [ ] Display full book information
- [ ] Show all reviews with ratings
- [ ] Add to shelf functionality
- [ ] Edit book button (opens edit dialog)
- [ ] Delete book with confirmation
- [ ] Show which shelves contain this book
- [ ] Change reading status
- [ ] Add/edit review section

---

#### Work Item 8: Add User Authentication

**Type:** User Story
**Title:** Add User Authentication
**State:** New
**Assigned To:** Unassigned
**Priority:** 3
**Description:**
```
Implement ASP.NET Core Identity for user authentication and authorization.
```

**Acceptance Criteria:**
- [ ] ASP.NET Core Identity configured
- [ ] User registration page
- [ ] Login page
- [ ] Logout functionality
- [ ] User-specific data filtering
- [ ] Protect API endpoints
- [ ] Associate reviews with users
- [ ] Associate shelves with users
- [ ] Profile page

---

### 5. How to Add Work Items in Azure DevOps

**Method 1: From Boards**

1. Go to **Boards** → **Work Items**
2. Click **+ New Work Item** → **User Story**
3. Fill in:
   - Title
   - Assigned To (select your name)
   - State (New/Active/Done)
   - Description
   - Acceptance Criteria
4. Click **Save**

**Method 2: From Backlog**

1. Go to **Boards** → **Backlogs**
2. Click **+ New Work Item** at the top
3. Type the title and press Enter
4. Click on the work item to open details
5. Fill in the same fields as Method 1

**Adding Tasks to a User Story:**

1. Open the User Story
2. Scroll to **Related Work** section
3. Click **Add link** → **New item**
4. Select **Task**
5. Fill in task details
6. Click **Save**

### 6. Set All Completed Items to "Done"

For Work Items 1-5:
1. Open each work item
2. Change **State** dropdown from "New" to **"Done"**
3. Click **Save**

### 7. Get Your Project Board URL

1. Go to **Boards** → **Boards**
2. Copy the URL from your browser
3. It should look like: `https://dev.azure.com/{your-org}/BookStack/_boards/board/t/BookStack%20Team/Stories`
4. Or use the simpler project URL: `https://dev.azure.com/{your-org}/BookStack`

### 8. Make Project Public

1. Go to **Project Settings** (bottom left)
2. Click **Overview**
3. Under **Visibility**, ensure it's set to **Public**
4. Click **Save**

### 9. Update Your Submission Document

1. Open `W04_CHECKPOINT_SUMMARY.md`
2. Replace `[To be inserted - Create Azure DevOps project and add link here]` with your actual URL
3. Save the file

### 10. Submit to Canvas

Submit these two items:

1. **Azure DevOps Project Board URL** - Paste your URL
2. **Meeting Summary** - Copy/paste the content from `W04_CHECKPOINT_SUMMARY.md`

---

## Quick Reference: Work Item Summary

| # | Title | Type | State | Assigned To |
|---|-------|------|-------|-------------|
| 1 | Setup Project Infrastructure | User Story | Done | David Esparza |
| 2 | Implement Data Models | User Story | Done | David Esparza |
| 3 | Setup Database Layer | User Story | Done | David Esparza |
| 4 | Build REST API Controllers | User Story | Done | David Esparza |
| 5 | Create Blazor UI Components | User Story | Done | David Esparza |
| 6 | Add Book Creation Dialog | User Story | New | Unassigned |
| 7 | Implement Book Details Page | User Story | New | Unassigned |
| 8 | Add User Authentication | User Story | New | Unassigned |

---

## Troubleshooting

**Q: I can't make the project public**
A: Your organization settings might restrict this. Contact your instructor if this is required.

**Q: I don't see "Boards" menu**
A: Make sure Azure Boards is enabled in Project Settings → Overview → Azure Boards: On

**Q: Work items aren't showing up**
A: Check that you're in the correct project and that the work items are saved properly.

**Q: Can other team members see the work items?**
A: If the project is public and they have the URL, yes. If private, you need to add them as members in Project Settings → Teams → Members.

---

## Success Checklist

- [ ] Azure DevOps account created
- [ ] BookStack project created
- [ ] Project visibility set to Public
- [ ] At least 5 work items created and assigned to David Esparza
- [ ] Completed work items marked as "Done"
- [ ] 3 future work items added (can be unassigned)
- [ ] Project Board URL copied
- [ ] W04_CHECKPOINT_SUMMARY.md updated with URL
- [ ] Submission prepared for Canvas

---

**Estimated Time to Complete:** 20-30 minutes

Good luck with your submission!
