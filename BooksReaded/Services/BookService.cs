using BooksReaded.Models;
using BooksReaded.Repository;
using System;
using System.Collections.Generic;

namespace BooksReaded.Services
{
    public class BookService : IBookServiceInterface
    {
        private IBaseRepository<Book> _bookRepository;

        public BookService()
        {
            _bookRepository = new BookRepository();
        }

        public void EditBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksList()
        {
            throw new NotImplementedException();
        }

        public void SaveBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
