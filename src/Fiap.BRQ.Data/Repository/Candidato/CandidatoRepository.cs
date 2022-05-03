namespace Fiap.BRQ.Data.Repository.Candidato;

public class CandidatoRepository : RepositorySQLBase<Core.Domain.Candidato, Guid>, ICandidatoRepository
{
    public CandidatoRepository(BRQDBContext context) : base(context)
    {
    }

    public IQueryable<Core.Domain.Candidato> FindAllByEspecialidadeAsync(int page, int pageSize, string especialidade, string candidato)
    {
        page = page <= 1 ? 1 : page;

        var skip = (page - 1) * pageSize;

        var filterEspecialidades = especialidade?.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

        // TODO: OPTIMIZE GENERATE QUERY                       
        var result = from candidatos in _context.Candidatos
                     from especialides in candidatos.Especialidades
                     from certificados in especialides.Certificados.DefaultIfEmpty()
                     where (candidatos.Nome.Contains(candidato) || candidatos.CPF.Numero.Contains(candidato) || candidatos.Email.Endereco.Contains(candidato)) && filterEspecialidades!.Contains(especialides.Nome)
                     group candidatos by new { candidatos.Id } into candidatosGroup
                     orderby candidatosGroup.Count() descending
                     select candidatosGroup.Skip(skip).Take(pageSize).FirstOrDefault();

        return result;
    }
}
