# BookStack - Video Demonstration Script
**W07 Final Project Presentation**

Duration: 5-7 minutes
Presenter: David Esparza

---

## Pre-Recording Checklist

- [ ] Delete `bookstack.db` to ensure fresh seed data
- [ ] Build and run the application (`dotnet run`)
- [ ] Test that all features work
- [ ] Close unnecessary browser tabs
- [ ] Set browser zoom to 100%
- [ ] Clear browser console
- [ ] Have GitHub and Azure DevOps tabs ready
- [ ] Check microphone and camera
- [ ] Close distracting applications

---

## Video Structure (5-7 minutes)

### 1. Introduction (30 seconds)
**[Camera ON, Show your face]**

> "Hello! My name is David Esparza, and I'm presenting my W07 Group Project for CSE 325 - .NET Development.
>
> Today I'll be demonstrating **BookStack**, a Personal Library Management System built with ASP.NET Core 9.0 and Blazor Server.
>
> This project was planned as a group effort, but due to lack of team communication, I completed it individually. Let me show you what I've built."

**[Switch to screen share]**

---

### 2. Project Overview (1 minute)

**[Show GitHub Repository]**

> "First, let me show you the project repository on GitHub."

Navigate to: `https://github.com/desparzas/BookStack`

> "As you can see, the repository contains:
> - Complete source code for the application
> - Documentation including README, User Guide, and weekly checkpoint reports
> - Commit history showing incremental development across 6 weeks
> - The project uses .NET 9, Blazor Server, Entity Framework Core, and SQLite"

**[Show Azure DevOps Board]**

> "Here's our Azure DevOps board where I tracked all user stories and tasks throughout the project."

Navigate to your Azure DevOps URL

> "The board shows completed user stories including:
> - Book management features
> - Shelf organization
> - User authentication
> - Book details page
> - All planned features are marked as Done"

---

### 3. Application Demonstration (4-5 minutes)

**[Navigate to `https://localhost:5001`]**

#### 3.1 Home Page & Overview (30 seconds)

> "This is the BookStack home page. The dashboard shows:
> - 10 books in our library
> - 10 authors
> - 10 different genres
> - 4 organizational shelves
>
> The navigation sidebar provides quick access to all features."

#### 3.2 User Authentication (1 minute)

**[Click "Register" in sidebar]**

> "Let's start by creating a new user account. BookStack includes a complete authentication system."

Fill out the form:
- Username: `testuser`
- Email: `test@bookstack.com`
- Password: `test123`
- Confirm Password: `test123`

> "The form includes validation - usernames must be unique, emails must be valid, and passwords must match."

**[Click "Create Account"]**

> "After successful registration, we're redirected to the login page."

**[Login with the demo account instead]**
- Username: `demo`
- Password: `demo123`

> "I'll use the demo account for this demonstration. After login, you can see my username appears in the sidebar with a logout option."

#### 3.3 Books Management (1.5 minutes)

**[Click "Books" in sidebar]**

> "The Books page displays all books in a card-based layout. Each card shows:
> - Book cover image or placeholder
> - Title and authors
> - Publication year and average rating
> - ISBN if available"

**[Click "Add New Book" button]**

> "Let's add a new book to the library. This opens a modal dialog with a comprehensive form."

Fill out the form:
- Title: `The Pragmatic Programmer`
- Authors: Check `Robert C. Martin` (scroll and find it or use existing)
- Genres: Check `Technology`
- ISBN: `9780135957059`
- Publication Year: `2019`
- Description: `A guide to software craftsmanship and best practices`
- Cover URL: (leave blank or use a URL)

> "The form includes multi-select checkboxes for authors and genres, demonstrating many-to-many relationships. All data is validated before submission."

**[Click "Add Book"]**

> "The book is instantly added to our library and appears in the list."

**[Click "View Details" on any book]**

#### 3.4 Book Details Page (1 minute)

> "The book details page provides comprehensive information:
>
> At the top, we have breadcrumb navigation for easy movement.
>
> The main section shows:
> - Full book information with metadata
> - All authors with badges
> - All genres with badges
> - Star rating visualization
>
> Below that, we have the Reviews section showing all reviews with:
> - Star ratings
> - Review text
> - Delete functionality
>
> And finally, the Shelves section showing which shelves contain this book and the reading status."

**[If there's a review, click Delete and confirm]**

> "I can delete reviews with a simple click, which immediately updates the display."

#### 3.5 Shelves Organization (1 minute)

**[Click "Shelves" in sidebar]**

> "The Shelves page helps organize books into reading lists. We have four default shelves:
> - Want to Read
> - Currently Reading
> - Read
> - Favorites
>
> Each shelf displays all books it contains with their reading status."

**[Scroll to a shelf, click "Add Book to Shelf"]**

Select a book and status:
- Book: Select any book
- Status: `In Progress`

**[Click "Add to Shelf"]**

> "Books can appear on multiple shelves with different statuses. This helps track reading progress across different categories."

**[Click "Remove" on a book]**

> "Books can be removed from shelves without deleting them from the library."

#### 3.6 Additional Features (30 seconds)

> "The application also includes:
> - RESTful API endpoints for books and shelves that can be accessed programmatically
> - Responsive design that works on mobile devices
> - Automatic database creation and seeding with sample data
> - Real-time UI updates using Blazor Server's SignalR connection
> - Form validation throughout the application"

---

### 4. Technical Highlights (30 seconds)

**[Can show code in VS Code briefly, or just explain]**

> "From a technical perspective, BookStack demonstrates:
> - Clean architecture with separation of concerns
> - Entity Framework Core with many-to-many relationships
> - DTO pattern for API data transfer
> - Service layer for authentication logic
> - Event-driven state management for authentication
> - Async/await patterns throughout
> - Dependency injection
> - Blazor components with proper lifecycle management"

---

### 5. Conclusion (30 seconds)

**[Camera ON, Show your face]**

> "To summarize, BookStack is a fully functional personal library management system that meets all project requirements:
>
> ✓ Complete CRUD functionality for books and shelves
> ✓ User authentication and registration
> ✓ Responsive and accessible design
> ✓ RESTful API
> ✓ Clean, well-documented code
> ✓ Proper use of the .NET ecosystem including Blazor, EF Core, and ASP.NET Core
>
> All source code, documentation, and this presentation are available on GitHub and Azure DevOps.
>
> Thank you for watching, and I'm happy to answer any questions about the implementation."

**[End recording]**

---

## Important Notes

### Talking Tips
- Speak clearly and at a moderate pace
- Show enthusiasm about your work
- Explain WHY you made certain decisions, not just WHAT you built
- Point out interesting technical challenges you solved
- Be professional but personable

### Technical Tips
- **Browser**: Use Chrome or Edge for best Blazor performance
- **Resolution**: Record at 1080p if possible
- **Audio**: Use a good microphone, minimize background noise
- **Speed**: Don't rush through features - show them working
- **Errors**: If something goes wrong, acknowledge it and continue professionally

### What to Avoid
- Don't spend too much time on any one feature
- Don't read the screen - explain what you're doing
- Don't use filler words excessively ("um", "uh", "like")
- Don't apologize for the project - be confident!
- Don't show your face for the whole video - mix it with screen share

---

## Recording Tools

### Recommended Software
1. **OBS Studio** (Free) - Professional recording
2. **Zoom** (Record yourself) - Easy to use
3. **Loom** (Free tier) - Quick and simple
4. **Windows Game Bar** (Built-in) - Win+G

### Video Editing (Optional)
- **DaVinci Resolve** (Free) - Professional editing
- **Shotcut** (Free) - Simple editing
- **iMovie** (Mac) - Built-in, easy to use

---

## Upload to YouTube

### Steps
1. Go to [YouTube Studio](https://studio.youtube.com/)
2. Click "Create" → "Upload videos"
3. Select your video file
4. Fill in details:
   - **Title**: "BookStack - Personal Library Management System | CSE 325 Final Project"
   - **Description**:
     ```
     Final project demonstration for BYU CSE 325 - .NET Development

     BookStack is a personal library management system built with:
     - ASP.NET Core 9.0
     - Blazor Server
     - Entity Framework Core
     - SQLite Database

     Features:
     - User authentication
     - Book catalog management
     - Shelf organization
     - Reviews and ratings
     - RESTful API

     GitHub: [Your repository URL]
     Azure DevOps: [Your board URL]

     Developer: David Esparza
     Course: CSE 325 - .NET Development
     Institution: BYU
     ```
   - **Visibility**: Unlisted (so only people with the link can see it)
   - **Audience**: Not made for kids
5. Click "Next" through the settings
6. Click "Publish"
7. Copy the video URL for submission

---

## Time Management Breakdown

| Section | Time | Content |
|---------|------|---------|
| Introduction | 0:30 | Who you are, project name |
| Project Overview | 1:00 | GitHub, Azure DevOps |
| Home & Dashboard | 0:30 | Overview statistics |
| Authentication | 1:00 | Register + Login demo |
| Books Management | 1:30 | Browse + Add book |
| Book Details | 1:00 | Full information display |
| Shelves | 1:00 | Add/remove from shelves |
| Technical Highlights | 0:30 | Architecture overview |
| Conclusion | 0:30 | Summary and thanks |
| **Total** | **~7:00** | **Target range: 5-7 min** |

---

## Backup Plan

If something goes wrong during recording:

1. **App crashes**: Restart it and continue from where you left off
2. **Forgot a feature**: Make a note and come back to it in editing
3. **Stumble on words**: Pause, take a breath, and continue
4. **Technical issue**: Acknowledge it briefly and move on
5. **Too long**: Edit out pauses and slow sections
6. **Too short**: Add more detail to feature explanations

---

## Post-Recording Checklist

- [ ] Watch the entire video
- [ ] Check audio quality
- [ ] Verify all features were demonstrated
- [ ] Ensure video is 5-7 minutes
- [ ] Edit if necessary
- [ ] Upload to YouTube as Unlisted
- [ ] Test the YouTube link
- [ ] Copy URL for submission
- [ ] Add URL to final submission document

---

## Alternative: Live Demonstration

If you prefer to do a live demonstration instead of pre-recording:

1. Practice the script multiple times
2. Have the application running and tested
3. Use Zoom to record yourself presenting
4. Follow the same script structure
5. Upload the recording to YouTube

---

Good luck with your presentation! Remember: you built a complete, functional application - be proud of your work!

**Show confidence, speak clearly, and let your project speak for itself.**
