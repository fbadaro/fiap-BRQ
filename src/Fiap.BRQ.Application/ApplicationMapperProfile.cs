using AutoMapper;
using Fiap.BRQ.Application.Candidato;
using Fiap.BRQ.Application.Certificado;
using Fiap.BRQ.Application.Especialidade;
using Fiap.BRQ.Core.Aggregate;

namespace Fiap.BRQ.Application;

public class AutoMapperConfig
{
    protected AutoMapperConfig() { }

    public static MapperConfiguration RegisterMappings() =>
        new MapperConfiguration(config =>
        {
            config.AllowNullCollections = true;
            config.AddProfile(new ApplicationMapperProfile());
        });
}

public class ApplicationMapperProfile : Profile
{
    public ApplicationMapperProfile()
    {
        // Candidato Map
        CreateMap<Core.Domain.Candidato, CandidatoDTO>()
            .ForMember(dto => dto.EnderecoLogradouro, opt => opt.MapFrom(candidato => candidato.Endereco.Logradouro))
            .ForMember(dto => dto.EnderecoComplemento, opt => opt.MapFrom(candidato => candidato.Endereco.Complemento))
            .ForMember(dto => dto.EnderecoBairro, opt => opt.MapFrom(candidato => candidato.Endereco.Bairro))
            .ForMember(dto => dto.EnderecoCEP, opt => opt.MapFrom(candidato => candidato.Endereco.CEP))
            .ForMember(dto => dto.CPFNumero, opt => opt.MapFrom(candidato => candidato.CPF.Numero))
            .ForMember(dto => dto.CPFEmissor, opt => opt.MapFrom(candidato => candidato.CPF.Emissor))
            .ForMember(dto => dto.CPFUF, opt => opt.MapFrom(candidato => candidato.CPF.UF))
            .ForMember(dto => dto.EmailEndereco, opt => opt.MapFrom(candidato => candidato.Email.Endereco))
            .ForMember(dto => dto.RGNumero, opt => opt.MapFrom(candidato => candidato.RG.Numero)).ReverseMap();

        // Default
        CreateMap<EspecialidadeDTO, Core.Domain.Especialidade>().ReverseMap();
        CreateMap<CertificadoDTO, Core.Domain.Certificado>().ReverseMap();
    }
}
