namespace Fiap.BRQ.Data.Repository.Especialidade;

internal class EspecialidadeRepository : RepositorySQLBase<Core.Domain.Especialidade, Guid>
{
    public EspecialidadeRepository(BRQDBContext context) : base(context)
    {
    }
}
