using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain.AssessementWebAPI.Entities;
using Infrastrucuture.AssessementWebAPI.DataBase;
using Domain.AssessementWebAPI.Interfaces.Services;

namespace API.AssessementWebAPI.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public IBookService BookService { get; }
        public IAuthorService AuthorService { get; }

        public BooksController(IBookService bookService, IAuthorService authorService)
        {
            BookService = bookService;
            AuthorService = authorService;            
        }       

        [HttpGet]
        public async Task<IEnumerable<Book>> GetBooks()
        {
            return await BookService.ListAllBooks();
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = await BookService.FindBookById(id);

            if (book == null)
                return NotFound();

            return book;
        }
        
        [HttpPost]
        public async Task<ActionResult<Book>> CreateNewBook(BookBind bookBind)
        {
            var authors = await AuthorService.ListAllAuthors();
            bookBind.Author = authors.FirstOrDefault(x => x.Id == bookBind.Author.Id);

            Book book = new Book()
            {
                Isbn = bookBind.Isbn,
                Title = bookBind.Title,
                Year = bookBind.Year,
                Author = bookBind.Author,
            };
            await BookService.CreateBook(book);

            return CreatedAtAction("GetBook", new { id = book.Id }, book);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> EditBook(int id, Book book)
        {   
            if (id != book.Id)
                return BadRequest();

            var bookUpdate = await BookService.FindBookById(id);
            bookUpdate.Isbn = book.Isbn;
            bookUpdate.Title = book.Title;
            bookUpdate.Year = book.Year;

            try
            {
                await BookService.UpdateBook(bookUpdate);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BookService.BookExists(id))
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
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> Delete(int id)
        {
            var book = await BookService.FindBookById(id);
            if (book == null)
                return NotFound();

            await BookService.DeleteBook(book);

            return book;
        }
    }
}
