using BooksReaded.Models;
using BooksReaded.Repository.MapperAbstraction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
