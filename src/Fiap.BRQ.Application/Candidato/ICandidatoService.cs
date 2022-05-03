namespace Fiap.BRQ.Application.Candidato;

public interface ICandidatoService : IApplicationService<CandidatoDTO>
{
    Task<List<CandidatoDTO>> FindAllByEspecialidadeAsync(int page, string especialidade, string candidato);
}
