using Fiap.BRQ.Core.Entities;

namespace Fiap.BRQ.Core.Domain;

public class Certificado : Entity
{
    public Certificado()
    {
    }

    public Certificado(string nome, string organizacaoEmissora, bool expiracao, DateTime dataEmissao, DateTime dataExpiracao, string codigoCredencial, string urlCredencial, Especialidade especialidade)
    {
        Nome = nome;
        OrganizacaoEmissora = organizacaoEmissora;
        Expiracao = expiracao;
        DataEmissao = dataEmissao;
        DataExpiracao = dataExpiracao;
        CodigoCredencial = codigoCredencial;
        UrlCredencial = urlCredencial;
        Especialidade = especialidade;
    }    

    public string Nome { get; private set; } = default!;

    public string OrganizacaoEmissora { get; private set; } = default!;

    public bool Expiracao { get; private set; }

    public DateTime DataEmissao { get; private set; }

    public DateTime DataExpiracao { get; private set; }

    public string CodigoCredencial { get; private set; } = default!;

    public string UrlCredencial { get; private set; } = default!;

    public Especialidade Especialidade { get; private set; } = default!;
}
