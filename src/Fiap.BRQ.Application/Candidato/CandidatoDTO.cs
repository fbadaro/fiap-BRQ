using Fiap.BRQ.Application.Especialidade;
using System.ComponentModel.DataAnnotations;

namespace Fiap.BRQ.Application.Candidato;

public class CandidatoDTO : EntityDTO
{
    public string Nome { get; set; } = default!;

    [Required(ErrorMessage = "É necessário informar o documento (CPF) para criação da conta", AllowEmptyStrings = false)]
    public string CPFNumero { get; set; } = default!;

    [Required(ErrorMessage = "É necessário o informar o Emissor do CPF", AllowEmptyStrings = false)]
    public string CPFEmissor { get; set; } = default!;

    [Required(ErrorMessage = "É necessário o informar o UF do CPF", AllowEmptyStrings = false)]
    public string CPFUF { get; set; } = default!;

    [Required(ErrorMessage = "Email obrigatório", AllowEmptyStrings = false)]
    public string EmailEndereco { get; set; } = default!;

    [Required(ErrorMessage = "Endereço obrigatório", AllowEmptyStrings = false)]
    public string EnderecoLogradouro { get; set; } = default!;
    
    public string EnderecoComplemento { get; set; } = default!;

    [Required(ErrorMessage = "Bairro obrigatório", AllowEmptyStrings = false)]
    public string EnderecoBairro { get; set; } = default!;

    [Required(ErrorMessage = "CEP obrigatório", AllowEmptyStrings = false)]
    public string EnderecoCEP { get; set; } = default!;

    [Required(ErrorMessage = "É necessário informar o documento (RG) para criação da conta", AllowEmptyStrings = false)]
    public string RGNumero { get; set; } = default!;

    public string Telefone { get; set; } = default!;

    [Required(ErrorMessage = "É necessário informar suas especialidades para criação da conta", AllowEmptyStrings = false)]
    public List<EspecialidadeDTO> Especialidades { get;  set; } = new List<EspecialidadeDTO>();
}
