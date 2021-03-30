using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.AssessementWebAPI.Entities;

namespace Domain.AssessementWebAPI.Interfaces.Services
{
    public interface IBookService
    {
        Task CreateBook(Book book);
        Task<IEnumerable<Book>> ListAllBooks();
        Task<Book> FindBookById(int id);
        Task UpdateBook(Book book);
        Task DeleteBook(Book book);
        bool BookExists(int id);
    }
}
