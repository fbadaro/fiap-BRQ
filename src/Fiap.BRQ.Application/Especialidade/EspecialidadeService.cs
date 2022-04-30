using AutoMapper;
using Fiap.BRQ.Data.Repository.Especialidade;

namespace Fiap.BRQ.Application.Especialidade;

public class EspecialidadeService : IEspecialidadeService
{
    private readonly IEspecialidadeRepository _especialidadeRepository;
    private readonly IMapper _mapper;

    public EspecialidadeService(IEspecialidadeRepository especialidadeRepository, IMapper mapper)
    {
        _especialidadeRepository = especialidadeRepository;
        _mapper = mapper;
    }

    public async Task<EspecialidadeDTO> CreateAsync(EspecialidadeDTO entityDTO)
    {
        var especialidade = await _especialidadeRepository.CreateAsync(_mapper.Map<Core.Domain.Especialidade>(entityDTO));
        return _mapper.Map<EspecialidadeDTO>(especialidade);
    }

    public async Task DeleteAsync(Guid id) => await _especialidadeRepository.DeleteAsync(id);

    public async Task<List<EspecialidadeDTO>> GetAllAsync() => _mapper.Map<List<EspecialidadeDTO>>(await _especialidadeRepository.GetAllAsync());

    public async Task<EspecialidadeDTO> GetById(Guid id) => _mapper.Map<EspecialidadeDTO>(await _especialidadeRepository.GetById(id));    

    public async Task<EspecialidadeDTO> UpdateAsync(EspecialidadeDTO entityDTO)
    {
        var especialidade = await _especialidadeRepository.UpdateAsync(_mapper.Map<Core.Domain.Especialidade>(entityDTO));
        return _mapper.Map<EspecialidadeDTO>(especialidade);
    }

    public void Dispose() => _especialidadeRepository?.Dispose();    
}
