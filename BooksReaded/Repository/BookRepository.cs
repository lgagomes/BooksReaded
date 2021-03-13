using BooksReaded.Models;
using BooksReaded.Repository.MapperAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BooksReaded.Repository
{
    public class BookRepository : IBaseRepository<Book>
    {
        private readonly string _connectionString = "Data Source=DESKTOP-A8U9VRT;Initial Catalog=Books;User Id=admin;Password=123";
        private IMapperAbstraction MapperAbstraction;

        public BookRepository()
        {
            MapperAbstraction = new MapperAbstraction.MapperAbstraction(_connectionString);
        }

        public void Edit(Book book)
        {
            int rowsAfected = 
                MapperAbstraction.Execute(Resources.Book.Edit,
                    new
                    {
                        book.Author.IdAuthor,
                        book.Title,
                        book.YearPublication,
                        book.IdBook
                    });

            if (rowsAfected != 1)
            {
                throw new Exception("Coundn't edit the book");
            }           
        }

        public Book GetById(int Id)
        {
           return 
                MapperAbstraction.Query<Book>(
                    $"{Resources.Book.GetBookBase} WHERE Book.IdBook = @IdBook",
                    new { IdBook = Id })
                .FirstOrDefault();
        }

        public List<Book> GetList()
        {
            return MapperAbstraction.Query<Book>(Resources.Book.GetBookBase).ToList();
        }       

        public void Save(Book book)
        {
            book.Id =
               MapperAbstraction.ExecuteScalar<int>(Resources.Book.Insert,
               new
               {
                   book.Author.IdAuthor,
                   book.Title,
                   book.YearPublication
               });

            if (book.Id == 0)
            {
                throw new Exception("Could not save the book");
            }
        }
    }
}