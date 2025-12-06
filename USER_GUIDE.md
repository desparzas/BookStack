# BookStack User Guide
**Personal Library Management System**

Version 1.0
Last Updated: December 5, 2024

---

## Table of Contents
1. [Getting Started](#getting-started)
2. [Creating an Account](#creating-an-account)
3. [Logging In](#logging-in)
4. [Managing Books](#managing-books)
5. [Working with Shelves](#working-with-shelves)
6. [Viewing Book Details](#viewing-book-details)
7. [Adding Reviews](#adding-reviews)
8. [Troubleshooting](#troubleshooting)
9. [FAQ](#faq)

---

## Getting Started

### What is BookStack?
BookStack is a personal library management system that helps you organize, track, and review your book collection. With BookStack, you can:

- Catalog your books with detailed information
- Organize books into custom shelves
- Track your reading progress
- Write and manage book reviews
- Discover books by authors and genres
- Manage your reading list

### System Requirements
- Modern web browser (Chrome, Firefox, Edge, Safari)
- Internet connection
- JavaScript enabled

### Demo Credentials
For testing purposes, you can use these demo accounts:

**Demo User:**
- Username: `demo`
- Password: `demo123`

**Personal Account:**
- Username: `david`
- Password: `password123`

---

## Creating an Account

### Step 1: Navigate to Registration
1. Open BookStack in your web browser
2. Click on **"Register"** in the left sidebar
3. You will be taken to the registration page

### Step 2: Fill Out the Registration Form
Enter the following information:

- **Username**: Choose a unique username (3-50 characters)
- **Email**: Enter a valid email address
- **Password**: Create a secure password (minimum 6 characters)
- **Confirm Password**: Re-enter your password to confirm

### Step 3: Submit Registration
1. Click the **"Create Account"** button
2. If successful, you'll see a success message
3. You'll be automatically redirected to the login page

### Registration Validation
- Username must be unique (not already taken)
- Email must be unique and in valid format
- Passwords must match
- All fields are required

---

## Logging In

### Standard Login
1. Click **"Login"** in the left sidebar
2. Enter your **Username**
3. Enter your **Password**
4. Click **"Login"** button

### After Login
- Your username will appear in the sidebar
- You'll be redirected to the home page
- You'll have access to all features

### Logging Out
1. Click **"Logout"** in the left sidebar
2. You'll be logged out and redirected to the home page
3. Your session will end

---

## Managing Books

### Viewing All Books
1. Click **"Books"** in the left sidebar
2. Browse the list of all books in the library
3. Each book card shows:
   - Cover image (or placeholder)
   - Title and authors
   - Publication year
   - Average rating
   - ISBN (if available)

### Adding a New Book
1. Navigate to the **Books** page
2. Click the **"Add New Book"** button (top right)
3. Fill out the book information:

   **Required Fields:**
   - **Title**: The book's title
   - **Authors**: Select one or more authors (checkboxes)
   - **Genres**: Select one or more genres (checkboxes)

   **Optional Fields:**
   - **ISBN**: 10 or 13 digit ISBN number
   - **Publication Year**: Year the book was published
   - **Description**: Brief description or synopsis
   - **Cover Image URL**: Link to the book's cover image

4. Click **"Add Book"** to save
5. The new book will appear in your library

### Editing Book Information
*Note: Edit functionality is currently in development*

### Deleting a Book
*Note: Delete functionality is available through the API but not yet in the UI*

### Searching for Books
- Use the search bar to find books by title
- Filter by clicking on authors or genres
- Sort books by title, year, or rating (coming soon)

---

## Working with Shelves

### What are Shelves?
Shelves help you organize your books into categories like:
- Want to Read
- Currently Reading
- Read
- Favorites
- Custom categories

### Viewing Shelves
1. Click **"Shelves"** in the left sidebar
2. See all available shelves
3. Each shelf shows:
   - Shelf name and description
   - Number of books
   - List of books on that shelf
   - Reading status for each book

### Understanding Reading Status
Each book on a shelf has a status:
- **Not Started** (gray badge)
- **In Progress** (yellow badge)
- **Completed** (green badge)

### Adding a Book to a Shelf
1. Go to the **Shelves** page
2. Find the shelf you want to use
3. Click **"Add Book to Shelf"** button
4. Select the book from the dropdown
5. Choose the reading status
6. Click **"Add to Shelf"**

### Removing a Book from a Shelf
1. Find the book on the shelf
2. Click the **"Remove"** button next to the book
3. Confirm the removal
4. The book will be removed from that shelf only (not deleted from library)

### Creating Custom Shelves
*Note: Custom shelf creation is in development*

---

## Viewing Book Details

### Accessing Book Details
1. Go to the **Books** page
2. Click **"View Details"** on any book card
3. Or click on a book from a shelf

### Book Details Page Shows:
- **Cover Image**: Large book cover or placeholder
- **Book Information**:
  - Full title
  - Complete list of authors
  - All genres
  - ISBN
  - Publication year
  - Average rating (1-5 stars)
- **Description**: Full book synopsis
- **Reviews**: All reviews for this book
- **Shelves**: Which shelves contain this book
- **Reading Status**: Current status on each shelf

### Breadcrumb Navigation
- Use the breadcrumb at the top: **Home > Books > [Book Title]**
- Click any part to navigate back

---

## Adding Reviews

### Writing a Review
1. Navigate to a book's details page
2. Scroll to the **Reviews** section
3. Find the **"Add Review"** area (coming soon)
4. Enter your review:
   - **Rating**: Select 1-5 stars
   - **Review Text**: Write your thoughts

### Viewing Reviews
- All reviews appear on the book details page
- Each review shows:
  - Star rating (★★★★★)
  - Review text
  - Date created

### Deleting a Review
1. Find your review on the book details page
2. Click the **"Delete"** button
3. Confirm deletion
4. The review will be permanently removed

### Review Guidelines
- Be respectful and constructive
- Provide helpful insights for other readers
- Rate honestly based on your experience
- Spoilers should be clearly marked (future feature)

---

## Troubleshooting

### Login Issues

**Problem: "Invalid username or password"**
- Check that you're entering the correct username (not email)
- Verify your password is correct
- Usernames and passwords are case-sensitive
- Try using a demo account to verify the system is working

**Problem: Can't remember password**
- Password reset feature is in development
- Contact support or create a new account

### Registration Issues

**Problem: "Username already exists"**
- Choose a different username
- Usernames must be unique

**Problem: "Email already exists"**
- This email is already registered
- Try logging in instead
- Or use a different email address

**Problem: "Passwords do not match"**
- Ensure both password fields contain the exact same text
- Check for accidental spaces or typos

### Book Management Issues

**Problem: Can't add a book**
- Ensure Title, at least one Author, and at least one Genre are selected
- Check that ISBN (if provided) is 10 or 13 digits
- Verify all required fields are filled

**Problem: Book not appearing**
- Refresh the page
- Check if the book was successfully added (look for success message)
- Search for the book by title

### Shelf Issues

**Problem: Can't add book to shelf**
- Ensure you've selected both a book and a reading status
- Check that the book isn't already on that shelf
- Refresh the page and try again

**Problem: Can't remove book from shelf**
- Make sure you're clicking the correct Remove button
- Refresh the page if the button doesn't respond

### General Issues

**Problem: Page not loading**
- Check your internet connection
- Refresh the page (F5 or Ctrl+R)
- Clear your browser cache
- Try a different browser

**Problem: Changes not saving**
- Wait for the loading spinner to complete
- Check for error messages
- Don't navigate away while changes are saving

**Problem: Logout button not working**
- Refresh the page
- Clear your browser cookies
- Close and reopen the browser

---

## FAQ

### General Questions

**Q: Is BookStack free to use?**
A: Yes, BookStack is a free educational project for managing your personal library.

**Q: Can I access BookStack from my phone?**
A: Yes! BookStack is responsive and works on mobile devices, tablets, and desktops.

**Q: Is my data secure?**
A: User passwords are hashed using SHA256 encryption. However, this is a demo/educational application and should not be used for sensitive data.

**Q: Can I import my books from Goodreads?**
A: Not yet. Import functionality is planned for a future release.

### Account Questions

**Q: Can I change my username?**
A: Username changes are not currently available. You would need to create a new account.

**Q: Can I change my password?**
A: Password change functionality is in development.

**Q: What happens if I forget my password?**
A: Password reset is in development. For now, you would need to contact support or create a new account.

**Q: Can I delete my account?**
A: Account deletion is not yet implemented. Contact support for assistance.

### Book Management Questions

**Q: How many books can I add?**
A: There is currently no limit on the number of books you can add to your library.

**Q: Can I add books without an ISBN?**
A: Yes! ISBN is optional. You only need a title, author(s), and genre(s).

**Q: Can I add custom authors or genres?**
A: Currently, you can only select from existing authors and genres. The system starts with 10 of each seeded in the database.

**Q: Can I upload my own book covers?**
A: Not yet. Currently, you can only provide a URL to an existing image online. Image upload is planned for a future release.

### Shelf Questions

**Q: How many shelves can I create?**
A: Currently, the application comes with 4 default shelves. Custom shelf creation is in development.

**Q: Can I have a book on multiple shelves?**
A: Yes! A book can be on multiple shelves with different reading statuses.

**Q: What's the difference between shelves?**
A: Shelves are organizational categories. The default shelves are:
- **Want to Read**: Books you plan to read
- **Currently Reading**: Books you're reading now
- **Read**: Books you've finished
- **Favorites**: Your favorite books

**Q: Can I rename shelves?**
A: Shelf renaming is not yet available.

### Review Questions

**Q: Can I edit my reviews?**
A: Review editing is in development. Currently, you can only delete and re-add reviews.

**Q: Can I see who wrote each review?**
A: Currently, reviews are anonymous. User attribution is planned for a future release.

**Q: How is the average rating calculated?**
A: The average rating is calculated from all reviews for a book, averaged across all star ratings.

### Technical Questions

**Q: What technology is BookStack built with?**
A: BookStack is built with:
- ASP.NET Core 9.0
- Blazor Server
- Entity Framework Core
- SQLite Database
- Bootstrap 5

**Q: Can I host BookStack myself?**
A: Yes! BookStack is open-source. See the README.md for deployment instructions.

**Q: Does BookStack work offline?**
A: No, BookStack requires an internet connection as it's a server-side application.

**Q: What browsers are supported?**
A: BookStack works on all modern browsers:
- Chrome/Edge (recommended)
- Firefox
- Safari
- Opera

---

## Additional Resources

### Documentation
- **README.md**: Technical documentation for developers
- **W06_CHECKPOINT_REPORT.txt**: Detailed feature documentation
- **GitHub Repository**: Source code and issue tracking

### Support
- For technical issues, report them on the GitHub repository
- For feature requests, submit via Azure DevOps board
- For course-related questions, contact through the BYU portal

### Future Features
Planned enhancements include:
- User-specific shelves
- Password reset functionality
- Book cover image upload
- Advanced search and filtering
- Reading statistics and goals
- Social features (following users, sharing lists)
- Import from Goodreads
- Export to CSV/Excel
- Mobile app

---

## Quick Reference Guide

### Common Tasks

| Task | Steps |
|------|-------|
| Create Account | Register → Fill form → Create Account |
| Login | Login → Enter credentials → Login button |
| Add Book | Books → Add New Book → Fill form → Add Book |
| View Book | Books → View Details |
| Add to Shelf | Shelves → Add Book to Shelf → Select book & status |
| Write Review | Book Details → Reviews → Add Review (coming soon) |
| Delete Review | Book Details → Find review → Delete |
| Logout | Click Logout in sidebar |

### Keyboard Shortcuts
*Note: Keyboard shortcuts are planned for a future release*

### Status Badge Colors
- **Gray**: Not Started
- **Yellow**: In Progress
- **Green**: Completed

### Rating Stars
- ★ = Filled star (counted in rating)
- ☆ = Empty star (not counted)

---

## Glossary

**Author**: The writer or creator of a book

**Book**: A literary work in your library

**Genre**: A category of literature (Fiction, Non-Fiction, Mystery, etc.)

**ISBN**: International Standard Book Number - a unique identifier for books

**Reading Status**: Current state of reading (Not Started, In Progress, Completed)

**Review**: Your written opinion and rating of a book

**Shelf**: A collection or category for organizing books

**Star Rating**: A 1-5 star scale for rating books

---

## Version History

### Version 1.0 (December 2024)
- Initial release
- User authentication (login/register)
- Book management (view, add)
- Shelf organization
- Book details page
- Review system
- Demo user accounts

---

## Credits

**Developer**: David Esparza
**Course**: CSE 325 - .NET Development
**Institution**: BYU
**Term**: 2025 Term 6

Built with ASP.NET Core, Blazor Server, and Entity Framework Core.

---

## License

This is an educational project developed for BYU CSE 325 course.

---

**End of User Guide**

For technical documentation, see README.md
For detailed feature documentation, see W06_CHECKPOINT_REPORT.txt

Last Updated: December 5, 2024
