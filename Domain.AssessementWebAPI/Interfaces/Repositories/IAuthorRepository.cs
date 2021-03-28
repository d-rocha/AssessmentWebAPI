using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.AssessementWebAPI.Entities;

namespace Domain.AssessementWebAPI.Interfaces.Repositories
{
    public interface IAuthorRepository
    {
        Task Create(Author author);
        Task<IEnumerable<Author>> ReadAll();
        Task<Author> ReadById(int id);
        Task Update(Author author);
        Task Delete(Author author);
        Task<Author> GetSpecialId(int id);
        bool AuthorExists(int id);
    }
}
