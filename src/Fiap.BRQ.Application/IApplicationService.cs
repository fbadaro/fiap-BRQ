namespace Fiap.BRQ.Application;

public interface IApplicationService<TEntityDTO> : IDisposable where TEntityDTO : EntityDTO
{
    Task<List<TEntityDTO>> GetAllAsync();

    Task<TEntityDTO> GetById(Guid id);

    Task<TEntityDTO> CreateAsync(TEntityDTO entityDTO);

    Task<TEntityDTO> UpdateAsync(TEntityDTO entityDTO);

    Task DeleteAsync(Guid id);
}