using BooksReaded.Models;
using System;
using System.Collections.Generic;

namespace BooksReaded.Repository
{
    public class BookRepository : IBaseRepository<Book>
    {
        public void Edit(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetList()
        {
            throw new NotImplementedException();
        }

        public void Save(Book book)
        {
            throw new NotImplementedException();
        }
    }
}