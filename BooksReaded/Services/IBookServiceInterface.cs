using BooksReaded.Models;
using System.Collections.Generic;

namespace BooksReaded.Services
{
    public interface IBookServiceInterface
    {
        Book GetBookById(int id);
        List<Book> GetBooksList();
        void SaveBook(Book book);
        void EditBook(Book book);
    }
}