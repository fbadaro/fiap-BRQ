using AutoMapper;
using Fiap.BRQ.Core.Domain;
using Fiap.BRQ.CrossCutting.Extensions;
using Fiap.BRQ.Data.Repository.Candidato;
using FluentValidation;

namespace Fiap.BRQ.Application.Candidato;

public class CandidatoService : ICandidatoService
{
    private int _pageSize = 25;
    private readonly ICandidatoRepository _candidatoRepository;
    private readonly IMapper _mapper;
    private readonly CandidatoValidator _validator;

    public CandidatoService(ICandidatoRepository candidatoRepository, IMapper mapper, CandidatoValidator candidatoValidator)
    {
        _candidatoRepository = candidatoRepository;
        _mapper = mapper;
        _validator = candidatoValidator;
    }

    public async Task<CandidatoDTO> CreateAsync(CandidatoDTO entityDTO)
    {
        var candidato = _mapper.Map<Core.Domain.Candidato>(entityDTO);
        candidato.CPF.Numero = candidato.CPF.Numero.OnlyNumbers();
        candidato.RG.Numero = candidato.RG.Numero.OnlyNumbers();

        var validated = await _validator.ValidateAsync(candidato, strategy => strategy.IncludeRuleSets("Create"));

        if (!validated.IsValid)
            throw new Exception(string.Join(",", validated.Errors));

        await _candidatoRepository.CreateAsync(candidato);

        return _mapper.Map<CandidatoDTO>(candidato);
    }

    public async Task DeleteAsync(Guid id) => await _candidatoRepository.DeleteAsync(id);

    public async Task<List<CandidatoDTO>> GetAllAsync() => _mapper.Map<List<CandidatoDTO>>(await _candidatoRepository.GetAllAsync());

    public async Task<CandidatoDTO> GetById(Guid id) => _mapper.Map<CandidatoDTO>(await _candidatoRepository.GetById(id));

    public async Task<CandidatoDTO> UpdateAsync(CandidatoDTO entityDTO)
    {
        var candidato = await _candidatoRepository.UpdateAsync(_mapper.Map<Core.Domain.Candidato>(entityDTO));
        return _mapper.Map<CandidatoDTO>(candidato);
    }

    public async Task<List<CandidatoDTO>> FindAllByEspecialidadeAsync(int page, string query)
    {        
        var candidatos = await Task.Run(() => _candidatoRepository.FindAllByEspecialidadeAsync(page, _pageSize, query));
        return _mapper.Map<List<CandidatoDTO>>(candidatos.ToList());
    }

    public void Dispose() => _candidatoRepository?.Dispose();    
}
