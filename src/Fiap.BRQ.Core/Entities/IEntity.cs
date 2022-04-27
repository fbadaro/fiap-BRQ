namespace Fiap.BRQ.Core.Entities;

public interface IEntity<TPrimaryKey>
{
    TPrimaryKey? Id { get; set; }
}
