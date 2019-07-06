using System.Collections.Generic;

namespace BooksReaded.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Get(TEntity entity);
        List<TEntity> GetList(TEntity entity);
        void Save(TEntity entity);
        void Edit(TEntity entity);
    }
}