using System.Collections.Generic;

namespace BooksReaded.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        T GetById(int Id);
        List<T> GetList();
        void Save(T entity);
        void Edit(T entity);
    }
}