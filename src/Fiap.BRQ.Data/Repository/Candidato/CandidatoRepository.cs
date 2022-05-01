using LinqKit;
using System.Linq.Expressions;

namespace Fiap.BRQ.Data.Repository.Candidato;

public class CandidatoRepository : RepositorySQLBase<Core.Domain.Candidato, Guid>, ICandidatoRepository
{
    public CandidatoRepository(BRQDBContext context) : base(context)
    {
    }

    public IQueryable<Core.Domain.Candidato> FindAllByEspecialidadeAsync(int page, int pageSize, string query)
    {
        page = page <= 1 ? 1 : page;

        var skip = (page - 1) * pageSize;

        var segments = query?.Split(',',StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        Expression<Func<Core.Domain.Especialidade, bool>> purchaseCriteria = x => x.Nome.Contains("");

        for (int i = 0; i < segments!.Length; i++)
        {
            var currrentKeyword = segments[i];
            purchaseCriteria.Or(x => x.Nome.Contains(currrentKeyword));
        }

        // TODO: OPTIMIZE GENERATE QUERY
        var result = from candidatos in _context.Candidatos.AsExpandable()
                     from especialides in candidatos.Especialidades
                     from certificados in especialides.Certificados.DefaultIfEmpty()
                     where candidatos.Especialidades.Any(purchaseCriteria.Compile())
                     group candidatos by new { candidatos.Id } into candidatosGroup
                     orderby candidatosGroup.Count() descending
                     select candidatosGroup.Skip(skip).Take(pageSize).FirstOrDefault();

        return result;
    }
}
