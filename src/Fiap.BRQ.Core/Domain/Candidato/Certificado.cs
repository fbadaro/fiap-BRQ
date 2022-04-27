using Fiap.BRQ.Core.Entities;

namespace Fiap.BRQ.Core.Domain;

public class Certificado : Entity
{
    public Certificado()
    {
    }

    public Certificado(string nome, string organizacaoEmissora, bool expiracao, DateOnly dataEmissao, DateOnly dataExpiracao, string codigoCredencial, string urlCredencial)
    {
        Nome = nome;
        OrganizacaoEmissora = organizacaoEmissora;
        Expiracao = expiracao;
        DataEmissao = dataEmissao;
        DataExpiracao = dataExpiracao;
        CodigoCredencial = codigoCredencial;
        UrlCredencial = urlCredencial;
    }    

    public string Nome { get; private set; } = default!;

    public string OrganizacaoEmissora { get; private set; } = default!;

    public bool Expiracao { get; private set; }

    public DateOnly DataEmissao { get; private set; }

    public DateOnly DataExpiracao { get; private set; }

    public string CodigoCredencial { get; private set; } = default!;

    public string UrlCredencial { get; private set; } = default!;
}
