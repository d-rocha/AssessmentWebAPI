using System.Threading.Tasks;
using System.Collections.Generic;
using Domain.AssessementWebAPI.Entities;
using Domain.AssessementWebAPI.Interfaces.Services;
using Domain.AssessementWebAPI.Interfaces.Repositories;

namespace Domain.AssessementWebAPI.Services
{
    public class AuthorService : IAuthorService
    {
        //Attribute that contains access to the repository
        public IAuthorRepository AuthorRepository { get; }

        //Constructor
        public AuthorService(IAuthorRepository authorRepository)
        {
            AuthorRepository = authorRepository;
        }

        /// <summary>
        /// Create author
        /// </summary>
        /// <param name="author"></param>
        /// <returns>Return a new Author</returns>
        public async Task CreateAuthor(Author author)
        {
            await AuthorRepository.Create(author);
        }

        /// <summary>
        /// List All Authors
        /// </summary>
        /// <returns>Returns all authors already created</returns>
        public async Task<IEnumerable<Author>> ListAllAuthors()
        {
            return await AuthorRepository.ReadAll();
        }

        /// <summary>
        /// Find Author by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List only a author</returns>
        public async Task<Author> FindAuthorById(int id)
        {
            var author = await AuthorRepository.ReadById(id);

            return author;
        }

        /// <summary>
        /// Update Author
        /// </summary>
        /// <param name="author"></param>
        /// <returns>Return a author updated</returns>
        public async Task UpdateAuthor(Author author)
        {
            await AuthorRepository.Update(author);
        }

        /// <summary>
        /// Delete Author
        /// </summary>
        /// <param name="author"></param>
        /// <returns>Remove author in a database</returns>
        public async Task DeleteAuthor(Author author)
        {
            await AuthorRepository.Delete(author);
        }

        /// <summary>
        /// Find Author by Special Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Returns exactly the author searched for by the id in the parameter</returns>
        public async Task<Author> FindAuthorBySpecialId(int id)
        {
            var author = await AuthorRepository.GetSpecialId(id);
            return author;
        }

        /// <summary>
        /// Author Exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Checks if author actually exists in the database</returns>
        public bool AuthorExists(int id)
        {
            return AuthorRepository.AuthorExists(id);
        }
    }
}
