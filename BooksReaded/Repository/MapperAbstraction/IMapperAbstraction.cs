using System.Collections.Generic;

namespace BooksReaded.Repository.MapperAbstraction
{
    public interface IMapperAbstraction
    {
        IEnumerable<T> Query<T>(string query, object parameters = null);
        T ExecuteScalar<T>(string query, object parameters = null);
        int Execute(string query, object parameters = null);
    }
}
