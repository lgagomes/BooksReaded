using System.Collections.Generic;

namespace BooksReaded.Repository.MapperAbstraction
{
    public interface IMapperAbstraction
    {
        IEnumerable<T> Query<T>(string query, object parameters);
        IEnumerable<T> Query<T>(string query);
    }
}
