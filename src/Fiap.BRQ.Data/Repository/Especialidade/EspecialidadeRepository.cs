namespace Fiap.BRQ.Data.Repository.Especialidade;

public class EspecialidadeRepository : RepositorySQLBase<Core.Domain.Especialidade, Guid>, IEspecialidadeRepository
{
    public EspecialidadeRepository(BRQDBContext context) : base(context)
    {
    }
}
