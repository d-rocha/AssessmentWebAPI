using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain.AssessementWebAPI.Entities;
using Infrastrucuture.AssessementWebAPI.DataBase;
using Domain.AssessementWebAPI.Interfaces.Repositories;

namespace Infrastrucuture.AssessementWebAPI.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly DataBaseAccess _dataBaseAccess;

        public AuthorRepository(DataBaseAccess dataBaseAccess)
        {
            _dataBaseAccess = dataBaseAccess;
        }

        /// <summary>
        /// CRUD, create an author
        /// </summary>
        /// <param name="author"></param>
        public async Task Create(Author author)
        {
            _dataBaseAccess.Authors.Add(author);
            await _dataBaseAccess.SaveChangesAsync();
        }

        /// <summary>
        /// CRUD, read/list all authors
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Author>> ReadAll()
        {
            return await _dataBaseAccess.Authors.Include(x => x.Books).ToListAsync();
        }

        /// <summary>
        /// CRUD, read/list an author by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Author> ReadById(int id)
        {
            return await _dataBaseAccess.Authors.Include(x => x.Books).FirstOrDefaultAsync(x => x.Id == id);
        }        

        /// <summary>
        /// CRUD, update an author
        /// </summary>
        /// <param name="author"></param>
        public async Task Update(Author author)
        {
            _dataBaseAccess.Authors.Update(author);
            await _dataBaseAccess.SaveChangesAsync();
        }

        /// <summary>
        /// CRUD, remove an author
        /// </summary>
        /// <param name="author"></param>
        public async Task Delete(Author author)
        {
            _dataBaseAccess.Authors.Remove(author);
            await _dataBaseAccess.SaveChangesAsync();
        }

        /// <summary>
        /// Returns exactly the searched entity 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Author> GetSpecialId(int id)
        {
            return await _dataBaseAccess.Authors.FindAsync(id);
        }

        /// <summary>
        /// Checks if the author exists
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool AuthorExists(int id)
        {
            return _dataBaseAccess.Authors.Any(author => author.Id == id);
        }
    }
}
