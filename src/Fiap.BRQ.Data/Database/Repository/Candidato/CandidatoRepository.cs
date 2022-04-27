namespace Fiap.BRQ.Data.Database.Repository.Candidato;

internal class CandidatoRepository : RepositorySQLBase<Core.Domain.Candidato, Guid>, ICandidatoRepository
{
    public CandidatoRepository(BRQDBContext context) : base(context)
    {
    }
}
