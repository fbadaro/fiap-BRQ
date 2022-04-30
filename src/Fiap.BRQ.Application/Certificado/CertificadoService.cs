using AutoMapper;
using Fiap.BRQ.Data.Repository.Certificado;

namespace Fiap.BRQ.Application.Certificado;

public class CertificadoService : ICertificadoService
{
    private readonly ICertificadoRepository _certificadoRepository;
    private readonly IMapper _mapper;

    public CertificadoService(ICertificadoRepository certificadoRepository, IMapper mapper)
    {
        _certificadoRepository = certificadoRepository;
        _mapper = mapper;
    }

    public async Task<CertificadoDTO> CreateAsync(CertificadoDTO entityDTO)
    {
        var certificado = await _certificadoRepository.CreateAsync(_mapper.Map<Core.Domain.Certificado>(entityDTO));
        return _mapper.Map<CertificadoDTO>(certificado);
    }

    public async Task DeleteAsync(Guid id) => await _certificadoRepository.DeleteAsync(id);

    public async Task<List<CertificadoDTO>> GetAllAsync() => _mapper.Map<List<CertificadoDTO>>(await _certificadoRepository.GetAllAsync());

    public async Task<CertificadoDTO> GetById(Guid id) => _mapper.Map<CertificadoDTO>(await _certificadoRepository.GetById(id));   

    public async Task<CertificadoDTO> UpdateAsync(CertificadoDTO entityDTO)
    {
        var certificado = await _certificadoRepository.UpdateAsync(_mapper.Map<Core.Domain.Certificado>(entityDTO));
        return _mapper.Map<CertificadoDTO>(certificado);
    }

    public void Dispose() => _certificadoRepository?.Dispose();    
}
