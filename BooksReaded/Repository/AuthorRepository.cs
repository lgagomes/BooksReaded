using BooksReaded.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace BooksReaded.Repository
{
    public class AuthorRepository : IBaseRepository<Author>
    {
        private readonly string _connectionString = "Data Source=DESKTOP-A8U9VRT;Initial Catalog=Books;User Id=admin;Password=123";

        public void Edit(Author author)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlCommand = new SqlCommand(Resources.Author.Edit, connection);
                        sqlCommand.Parameters.AddWithValue("@IdAuthor", author.IdAuthor);
                        sqlCommand.Parameters.AddWithValue("@Name", author.Name);

                        int rowsAfected = sqlCommand.ExecuteNonQuery();
                        if(rowsAfected != 1)
                        {
                            throw new Exception("Coundn't edit the author");
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error at AuthorRepository, 'Edit' method {Environment.NewLine}{ex.Message}",
                   ex.InnerException);
            }
        }

        public Author GetById(int Id)
        {
            Author author = new Author();

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        StringBuilder query = new StringBuilder(Resources.Author.GetAuthorBase).Append(" WHERE Author.IdAuthor = @IdAuthor");

                        SqlCommand sqlCommand = new SqlCommand(query.ToString(), connection);
                        sqlCommand.Parameters.AddWithValue("@IdAuthor", Id);
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        if (reader.Read())
                        {
                            author = FillAuthorByReader(reader);
                        }
                        else
                        {
                            throw new Exception("No authors found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error at AuthorRepository, 'GetById' method {Environment.NewLine}{ex.Message}",
                   ex.InnerException);
            }
            return author;
        }

        public List<Author> GetList()
        {
            List<Author> authors = new List<Author>();
            try
            {                
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlCommand = new SqlCommand(Resources.Author.GetAuthorBase, connection);
                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                authors.Add(FillAuthorByReader(reader));
                            }
                        }
                    }
                }                
            }
            catch(Exception ex)
            {
                throw new Exception($"Error at AuthorRepository, 'GetList' method {Environment.NewLine}{ex.Message}",
                    ex.InnerException);
            }
            return authors;
        }

        private Author FillAuthorByReader(SqlDataReader dataReader)
        {
            return new Author
            {
                IdAuthor = (int)dataReader["IdAuthor"],
                Name = (string)dataReader["Name"]
            };
        }

        public void Save(Author author)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        SqlCommand sqlCommand = new SqlCommand(Resources.Author.Insert, connection);
                        sqlCommand.Parameters.AddWithValue("@Name", author.Name);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Error at AuthorRepository, 'Save' method {Environment.NewLine}{ex.Message}",
                    ex.InnerException);
            }
        }
    }
}
