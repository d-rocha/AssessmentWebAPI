using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.AssessementWebAPI.Entities;
using Domain.AssessementWebAPI.Interfaces.Services;
using Domain.AssessementWebAPI.Interfaces.Repositories;

namespace Domain.AssessementWebAPI.Services
{
    public class BookService : IBookService
    {
        public IBookRepository BookRepository { get; }

        public BookService(IBookRepository bookRepository)
        {
            BookRepository = bookRepository;
        }

        public async Task CreateBook(Book book)
        {
            await BookRepository.Create(book);
        }

        public async Task<IEnumerable<Book>> ListAllBooks()
        {
            return await BookRepository.ReadAll();
        }

        public async Task<Book> FindBookById(int id)
        {
            var book = await BookRepository.ReadById(id);
            return book;
        }

        public async Task UpdateBook(Book book)
        {
            await BookRepository.Update(book);
        }

        public async Task DeleteBook(Book book)
        {
            await BookRepository.Delete(book);
        }       

        public bool BookExists(int id)
        {
            return BookRepository.BookExists(id);
        }
    }
}
