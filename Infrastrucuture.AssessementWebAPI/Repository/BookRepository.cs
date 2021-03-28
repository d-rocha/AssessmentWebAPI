using System;
using System.Linq;
using System.Collections.Generic;
using Domain.AssessementWebAPI.Entities;
using Infrastrucuture.AssessementWebAPI.DataBase;
using Domain.AssessementWebAPI.Interfaces.Repositories;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucuture.AssessementWebAPI.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly DataBaseAccess _dataBaseAccess;

        public BookRepository(DataBaseAccess dataBaseAccess)
        {
            _dataBaseAccess = dataBaseAccess;
        }

        /// <summary>
        /// CRUD, create a book
        /// </summary>
        /// <param name="book"></param>
        public async Task Create(Book book)
        {
            _dataBaseAccess.Books.Add(book);
            await _dataBaseAccess.SaveChangesAsync();
        }

        /// <summary>
        /// CRUD, read/list all books
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Book>> ReadAll()
        {
            return await _dataBaseAccess.Books.ToListAsync();
        }

        /// <summary>
        /// CRUD, read/list a book by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Book> ReadById(int id)
        {
            return await _dataBaseAccess.Books.FindAsync(id);
        }

        /// <summary>
        /// CRUD, update a book
        /// </summary>
        /// <param name="book"></param>
        public async Task Update(Book book)
        {
            _dataBaseAccess.Books.Update(book);
            await _dataBaseAccess.SaveChangesAsync();
        }

        /// <summary>
        /// CRUD, delete a book
        /// </summary>
        /// <param name="book"></param>
        public async Task Delete(Book book)
        {
            _dataBaseAccess.Books.Remove(book);
            await _dataBaseAccess.SaveChangesAsync();
        }
    }
}
