using System.ComponentModel.DataAnnotations;

namespace Fiap.BRQ.Application.Certificado;

public class CertificadoDTO : EntityDTO
{
    [Required(ErrorMessage = "É necessário informar o nome da Certificação", AllowEmptyStrings = false)]
    public string Nome { get; set; } = default!;

    [Required(ErrorMessage = "É necessário informar a Organização Emissora", AllowEmptyStrings = false)]
    public string OrganizacaoEmissora { get; set; } = default!;

    public bool Expiracao { get; set; }

    public DateTime DataEmissao { get; set; }

    public DateTime DataExpiracao { get; set; }

    public string CodigoCredencial { get; set; } = default!;

    public string UrlCredencial { get; set; } = default!;
}
