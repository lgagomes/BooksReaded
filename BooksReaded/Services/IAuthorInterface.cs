using BooksReaded.Models;
using System;
using System.Collections.Generic;

namespace BooksReaded.Services
{
    public interface IAuthorInterface
    {
        Author GetAuthorById(int id);
        List<Author> GetAuthorsList();
        void SaveAuthor(Author author);
        void EditAuthor(Author author);
    }
}
