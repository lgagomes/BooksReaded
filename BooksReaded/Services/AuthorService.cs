using BooksReaded.Models;
using BooksReaded.Repository;
using System;
using System.Collections.Generic;

namespace BooksReaded.Services
{
    public class AuthorService : IAuthorInterface
    {
        private IBaseRepository<Author> _authorRepository;

        public AuthorService()
        {
            _authorRepository = new AuthorRepository();
        }
        
        public void EditAuthor(Author author)
        {
            _authorRepository.Edit(author);
        }

        public Author GetAuthorById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public List<Author> GetAuthorsList()
        {
            return _authorRepository.GetList();
        }

        public void SaveAuthor(Author author)
        {
            _authorRepository.Save(author);
        }
    }
}
