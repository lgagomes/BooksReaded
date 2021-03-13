using BooksReaded.Models;
using BooksReaded.Repository.MapperAbstraction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace BooksReaded.Repository
{
    public class AuthorRepository : IBaseRepository<Author>
    {
        private readonly string _connectionString = "Data Source=DESKTOP-A8U9VRT;Initial Catalog=Books;User Id=admin;Password=123";
        private IMapperAbstraction MapperAbstraction;

        public AuthorRepository()
        {
            MapperAbstraction = new MapperAbstraction.MapperAbstraction(_connectionString);
        }

        public void Edit(Author author)
        {
            var execution =
                MapperAbstraction.ExecuteScalar<int>(Resources.Author.Edit,
                new
                {
                    author.IdAuthor,
                    author.Name
                });

            if (execution != 1)
            {
                throw new Exception("Coundn't edit the author");
            }
        }

        public Author GetById(int Id)
        {
            return
                MapperAbstraction.Query<Author>(
                    $"{Resources.Author.GetAuthorBase} WHERE Author.IdAuthor = @IdAuthor",
                    new { IdAuthor = Id})
                .FirstOrDefault();
        }

        public List<Author> GetList()
        {
            return 
                MapperAbstraction.Query<Author>(Resources.Author.GetAuthorBase)
                .OrderBy(x => x.Name)
                .ToList();
        }

        public void Save(Author author)
        {
            author.Id = 
                MapperAbstraction.ExecuteScalar<int>(Resources.Author.Insert,
                new { author.Name});

            if (author.Id == 0)
            {
                throw new Exception("Could not create author");
            }
        }
    }
}
