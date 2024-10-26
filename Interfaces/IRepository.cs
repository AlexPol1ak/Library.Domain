using System.Linq.Expressions;

namespace Library.Domain.Interfaces
{
    /// <summary>
    /// Интерфейс репозитория управления записями в базы данных.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll(params string[] includes);
        TEntity Get(int id, params string[] includes);
        IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Create(TEntity entity);
        void Update(TEntity entity);
        bool Delete(int id);
        bool Contains(TEntity entity);
        int Count();
    }
}
