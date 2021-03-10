using BooksReaded.Models;
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

        public IEnumerable<T> Query<T>(string query, object parameters)
        {
            IEnumerable<T> objects;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    objects = (AutoMapper.MapDynamic<T>(connection.Query<dynamic>(query, parameters)) as IEnumerable<T>).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, new Exception(ex.InnerException.Message));
            }

            return objects;
        }

        public IEnumerable<T> Query<T>(string query)
        {
            IEnumerable<T> objects;

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    
                    objects = (AutoMapper.MapDynamic<T>(connection.Query<dynamic>(query)) as IEnumerable<T>).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, new Exception(ex.InnerException.Message));
            }

            return objects;
        }
    }
}
