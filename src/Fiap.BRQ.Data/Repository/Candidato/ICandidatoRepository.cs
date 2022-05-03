namespace Fiap.BRQ.Data.Repository.Candidato;

public interface ICandidatoRepository : IRepositoryBase<Core.Domain.Candidato, Guid>
{
    IQueryable<Core.Domain.Candidato> FindAllByEspecialidadeAsync(int page, int pageSize, string especialidade, string candidato);
}
