using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookStack.Web.Data;
using BookStack.Web.Models;

namespace BookStack.Web.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ShelvesController : ControllerBase
{
    private readonly BookStackContext _context;

    public ShelvesController(BookStackContext context)
    {
        _context = context;
    }

    // GET: api/Shelves
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Shelf>>> GetShelves()
    {
        return await _context.Shelves
            .Include(s => s.ShelfBooks)
                .ThenInclude(sb => sb.Book)
                    .ThenInclude(b => b.BookAuthors)
                        .ThenInclude(ba => ba.Author)
            .ToListAsync();
    }

    // GET: api/Shelves/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Shelf>> GetShelf(int id)
    {
        var shelf = await _context.Shelves
            .Include(s => s.ShelfBooks)
                .ThenInclude(sb => sb.Book)
                    .ThenInclude(b => b.BookAuthors)
                        .ThenInclude(ba => ba.Author)
            .FirstOrDefaultAsync(s => s.Id == id);

        if (shelf == null)
        {
            return NotFound();
        }

        return shelf;
    }

    // POST: api/Shelves
    [HttpPost]
    public async Task<ActionResult<Shelf>> PostShelf(Shelf shelf)
    {
        _context.Shelves.Add(shelf);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetShelf), new { id = shelf.Id }, shelf);
    }

    // PUT: api/Shelves/5
    [HttpPut("{id}")]
    public async Task<IActionResult> PutShelf(int id, Shelf shelf)
    {
        if (id != shelf.Id)
        {
            return BadRequest();
        }

        _context.Entry(shelf).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!ShelfExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    // DELETE: api/Shelves/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteShelf(int id)
    {
        var shelf = await _context.Shelves.FindAsync(id);
        if (shelf == null)
        {
            return NotFound();
        }

        // Don't allow deletion of default shelves
        if (shelf.IsDefault)
        {
            return BadRequest("Cannot delete default shelves");
        }

        _context.Shelves.Remove(shelf);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    // POST: api/Shelves/5/books/3
    [HttpPost("{shelfId}/books/{bookId}")]
    public async Task<ActionResult<ShelfBook>> AddBookToShelf(int shelfId, int bookId)
    {
        var shelf = await _context.Shelves.FindAsync(shelfId);
        if (shelf == null)
        {
            return NotFound("Shelf not found");
        }

        var book = await _context.Books.FindAsync(bookId);
        if (book == null)
        {
            return NotFound("Book not found");
        }

        // Check if book is already on shelf
        var exists = await _context.ShelfBooks
            .AnyAsync(sb => sb.ShelfId == shelfId && sb.BookId == bookId);

        if (exists)
        {
            return BadRequest("Book already on this shelf");
        }

        var shelfBook = new ShelfBook
        {
            ShelfId = shelfId,
            BookId = bookId,
            ReadingStatus = ReadingStatus.NotStarted
        };

        _context.ShelfBooks.Add(shelfBook);
        await _context.SaveChangesAsync();

        return Ok(shelfBook);
    }

    // DELETE: api/Shelves/5/books/3
    [HttpDelete("{shelfId}/books/{bookId}")]
    public async Task<IActionResult> RemoveBookFromShelf(int shelfId, int bookId)
    {
        var shelfBook = await _context.ShelfBooks
            .FirstOrDefaultAsync(sb => sb.ShelfId == shelfId && sb.BookId == bookId);

        if (shelfBook == null)
        {
            return NotFound();
        }

        _context.ShelfBooks.Remove(shelfBook);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool ShelfExists(int id)
    {
        return _context.Shelves.Any(e => e.Id == id);
    }
}
