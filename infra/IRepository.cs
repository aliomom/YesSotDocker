using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace infra
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        List<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate);
        TEntity FindById(object id);
        Task<TEntity> FindByIdAsync(CancellationToken cancellationToken, object id);
        Task<TEntity> FindByIdAsync(object id);
        TEntity FindSingleBy(Expression<Func<TEntity, bool>> predicate);
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(CancellationToken cancellationToken);
        List<TEntity> PageAll(int skip, int take);
        Task<List<TEntity>> PageAllAsync(CancellationToken cancellationToken, int skip, int take);
        Task<List<TEntity>> PageAllAsync(int skip, int take);
        void Remove(TEntity entity);
        void Update(TEntity entity);
    }
}