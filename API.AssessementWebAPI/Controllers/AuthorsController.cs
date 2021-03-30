using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain.AssessementWebAPI.Entities;
using Domain.AssessementWebAPI.Interfaces.Services;

namespace API.AssessementWebAPI.Controllers
{
    [Route("api/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        public IAuthorService AuthorService { get; }
        public IBookService BookService { get; }

        public AuthorsController(IAuthorService authorService, IBookService bookService)
        {
            AuthorService = authorService;
            BookService = bookService;
        }

        [HttpPost]
        public async Task<ActionResult<Author>> CreateNewAuthor(Author author)
        {
            await AuthorService.CreateAuthor(author);
            return CreatedAtAction("GetAuthor", new { id = author.Id }, author);
        }

        [HttpGet]
        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await AuthorService.ListAllAuthors();            
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<Author>> GetAuthor(int id)
        {
            var author = await AuthorService.FindAuthorById(id);

            if (author == null)
                return NotFound();

            return author;
        }        

        [HttpPut("{id}")]
        public async Task<ActionResult<Author>> EditAuthor(int id, Author author)
        {
            if (id != author.Id)
                return BadRequest();

            var authorUpdate = await AuthorService.FindAuthorBySpecialId(id);

            authorUpdate.FirstName = author.FirstName;
            authorUpdate.LastName = author.LastName;

            try
            {
                await AuthorService.UpdateAuthor(authorUpdate);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuthorService.AuthorExists(id))
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
        public async Task<ActionResult<Author>> DeleteAuthor(int id)
        {
            var author = await AuthorService.FindAuthorById(id); 
            if (author == null)
                return NotFound();

            foreach (var book in author.Books)
            {
                await BookService.DeleteBook(book);                
            }
            await AuthorService.DeleteAuthor(author);

            return NoContent();
        }
    }
}
