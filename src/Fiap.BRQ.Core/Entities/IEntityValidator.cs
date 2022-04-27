namespace Fiap.BRQ.Core.Entities;

internal interface IEntityValidator<TEntity, TPrimaryKey> where TEntity : IEntity<TPrimaryKey>
{
    Task<EntityValidationResult> Validate(EntityValidationType validationType, TEntity entity);
}
