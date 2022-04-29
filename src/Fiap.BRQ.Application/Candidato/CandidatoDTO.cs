using Fiap.BRQ.Application.Especialidade;

namespace Fiap.BRQ.Application.Candidato;

public class CandidatoDTO : EntityDTO
{
    public string Nome { get; set; } = default!;

    public string CPFNumero { get; set; } = default!;

    public string CPFEmissor { get; set; } = default!;

    public string CPFUF { get; set; } = default!;

    public string EmailEndereco { get; set; } = default!;

    public string EnderecoLogradouro { get; set; } = default!;

    public string EnderecoComplemento { get; set; } = default!;

    public string EnderecoBairro { get; set; } = default!;

    public string EnderecoCEP { get; set; } = default!;

    public string RGNumero { get; set; } = default!;

    public string Telefone { get; set; } = default!;

    public List<EspecialidadeDTO> Especialidades { get;  set; } = new List<EspecialidadeDTO>();
}
