using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.AssessementWebAPI.Entities;

namespace Domain.AssessementWebAPI.Interfaces.Services
{
    public interface IAuthorService
    {
        Task CreateAuthor(Author author);
        Task<IEnumerable<Author>> ListAllAuthors();
        Task<Author> FindAuthorById(int id);
        Task UpdateAuthor(Author author);
        Task DeleteAuthor(Author author);
        Task<Author> FindAuthorBySpecialId(int id);
        bool AuthorExists(int id);
    }
}
