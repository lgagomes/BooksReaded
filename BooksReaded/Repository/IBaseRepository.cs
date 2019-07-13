using System.Collections.Generic;

namespace BooksReaded.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int Id);
        List<TEntity> GetList();
        void Save(TEntity entity);
        void Edit(TEntity entity);
    }
}