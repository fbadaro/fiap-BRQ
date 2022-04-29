namespace Fiap.BRQ.Data.Repository.Candidato;

internal class CandidatoRepository : RepositorySQLBase<Core.Domain.Candidato, Guid>, ICandidatoRepository
{
    public CandidatoRepository(BRQDBContext context) : base(context)
    {
    }
}
