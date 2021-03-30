using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.AssessementWebAPI.Entities;

namespace Domain.AssessementWebAPI.Interfaces.Repositories
{
    public interface IBookRepository
    {
        Task Create(Book book);
        Task<IEnumerable<Book>> ReadAll();
        Task<Book> ReadById(int id);
        Task Update(Book book);
        Task Delete(Book book);
        bool BookExists(int id);
    }
}
