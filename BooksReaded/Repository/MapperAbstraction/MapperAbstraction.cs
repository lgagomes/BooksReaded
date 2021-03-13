using Dapper;
using Slapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace BooksReaded.Repository.MapperAbstraction
{
    public class MapperAbstraction : IMapperAbstraction
    {
        public string ConnectionString { get; private set; }

        public MapperAbstraction(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IEnumerable<T> Query<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    return (AutoMapper.MapDynamic<T>(connection.Query<dynamic>(query, parameters)) as IEnumerable<T>).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, new Exception(ex.InnerException.Message));
            }
        }

        public T ExecuteScalar<T>(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    return connection.ExecuteScalar<T>(query, parameters);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, new Exception(ex.InnerException.Message));
            }
        }

        public int Execute(string query, object parameters = null)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                   return connection.Execute(query, parameters);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, new Exception(ex.InnerException.Message));
            }
        }
    }
}