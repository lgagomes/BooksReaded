using BooksReaded.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BooksReaded.Repository
{
    public class BookRepository : IBaseRepository<Book>
    {
        private readonly string _connectionString = "Data Source=DESKTOP-A8U9VRT;Initial Catalog=Books;User Id=admin;Password=123";

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
            Book book = new Book();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        StringBuilder query = new StringBuilder(Resources.Book.GetBookBase).Append(" WHERE Book.IdBook = @IdBook");

                        SqlCommand sqlCommand = new SqlCommand(query.ToString(), connection);
                        sqlCommand.Parameters.AddWithValue("@IdBook", Id);
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            book = FillBookByReader(reader);
                        }
                        else
                        {
                            throw new Exception("No books found");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error at BookRepository, 'GetById' method {Environment.NewLine}{ex.Message}",
                   ex.InnerException);
            }

            return book;
        }

        public List<Book> GetList()
        {
            List<Book> books = new List<Book>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlCommand = new SqlCommand(Resources.Book.GetBookBase, connection);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                books.Add(FillBookByReader(reader));
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error at BookRepository, 'GetList' method {Environment.NewLine}{ex.Message}",
                    ex.InnerException);
            }
            return books;
        }

        private Book FillBookByReader(SqlDataReader dataReader)
        {
            return new Book
            {
                IdBook = (int)dataReader["IdBook"],
                Title = (string)dataReader["Title"],
                YearPublication = (string)dataReader["YearPublication"],
                Author = new Author
                {
                    IdAuthor = (int)dataReader["IdAuthor"],
                    Name = (string)dataReader["Name"]
                }
            };
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