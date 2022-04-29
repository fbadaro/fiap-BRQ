using Fiap.BRQ.Core.Entities;

namespace Fiap.BRQ.Core.Domain;

public class Especialidade : Entity
{
    public Especialidade() { }

    public Especialidade(string nome, Candidato candidato, Certificado certificado)
    {
        Nome = nome;
        Candidato = candidato;
        Certificado = certificado;
    }

    public string Nome { get; private set; } = default!;

    public Candidato Candidato { get; private set; }

    public Certificado? Certificado { get; private set; }
}
