using Fiap.BRQ.Application.Certificado;
using System.ComponentModel.DataAnnotations;

namespace Fiap.BRQ.Application.Especialidade;

public class EspecialidadeDTO : EntityDTO
{
    [Required(ErrorMessage = "É necessário informar o nome da Especialidade", AllowEmptyStrings = false)]
    public string Nome { get; set; } = default!;

    //public CandidatoDTO Candidato { get; set; } = default!;

    public CertificadoDTO Certificado { get; set; } = default!;
}
