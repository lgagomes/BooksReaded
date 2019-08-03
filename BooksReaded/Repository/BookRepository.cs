using BooksReaded.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace BooksReaded.Repository
{
    public class BookRepository : IBaseRepository<Book>
    {
        private readonly string _connectionString = "Data Source=DESKTOP-A8U9VRT;Initial Catalog=Books;User Id=admin;Password=123";

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
            List<Book> books = new List<Book>();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlCommand = new SqlCommand(Resources.Book.GetList, connection);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                books.Add
                                (
                                    new Book
                                    {
                                        IdBook = (int)reader["IdBook"],
                                        Title = (string)reader["Title"],
                                        YearPublication = (string)reader["YearPublication"],
                                        Author = new Author
                                        {
                                            IdAuthor = (int)reader["IdAuthor"],
                                            Name = (string)reader["Name"]
                                        }
                                    }                                    
                                );
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