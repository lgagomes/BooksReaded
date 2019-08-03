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
            _bookRepository.Edit(book);
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public List<Book> GetBooksList()
        {
            return _bookRepository.GetList();
        }

        public void SaveBook(Book book)
        {
            _bookRepository.Save(book);
        }
    }
}
