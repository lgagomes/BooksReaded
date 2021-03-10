using BooksReaded.Models;
using BooksReaded.Repository.MapperAbstraction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

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
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlCommand = new SqlCommand(Resources.Book.Edit, connection);
                        sqlCommand.Parameters.AddWithValue("@IdAuthor", book.Author.IdAuthor);
                        sqlCommand.Parameters.AddWithValue("@Title", book.Title);
                        sqlCommand.Parameters.AddWithValue("@YearPublication", book.YearPublication);
                        sqlCommand.Parameters.AddWithValue("@IdBook", book.IdBook);

                        int rowsAfected = sqlCommand.ExecuteNonQuery();
                        if (rowsAfected != 1)
                        {
                            throw new Exception("Coundn't edit the book");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error at BookRepository, 'Edit' method {Environment.NewLine}{ex.Message}",
                   ex.InnerException);
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
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlCommand = new SqlCommand(Resources.Book.Insert, connection);
                        sqlCommand.Parameters.AddWithValue("@IdAuthor", book.Author.IdAuthor);
                        sqlCommand.Parameters.AddWithValue("@Title", book.Title);
                        sqlCommand.Parameters.AddWithValue("@YearPublication", book.YearPublication);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error at BookRepository, 'Save' method {Environment.NewLine}{ex.Message}",
                    ex.InnerException);
            }
        }
    }
}