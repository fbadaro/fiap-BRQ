using Fiap.BRQ.Core.Entities;

namespace Fiap.BRQ.Data;

public interface IRepositoryBase<TEntity, TPrimaryKey> : IDisposable where TEntity : class, IEntity<TPrimaryKey>
{
    Task<IEnumerable<TEntity>> GetAllAsync();

    Task<TEntity> GetById(TPrimaryKey id);

    Task<TEntity> CreateAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task DeleteAsync(TPrimaryKey id);
}
