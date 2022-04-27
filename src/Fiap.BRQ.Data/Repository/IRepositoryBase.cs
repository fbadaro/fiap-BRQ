using Fiap.BRQ.Core.Entities;

namespace Fiap.BRQ.Data.Repository;

public interface IRepositoryBase<TEntity, TPrimaryKey> : IDisposable where TEntity : IEntity<TPrimaryKey>
{
    Task<IEnumerable<TEntity>> GetAllAsync();

    Task<TEntity> GetById(TPrimaryKey id);

    Task<TEntity> CreateAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task DeleteAsync(TPrimaryKey id);
}
