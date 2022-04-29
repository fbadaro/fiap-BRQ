using Fiap.BRQ.Core.Entities;

namespace Fiap.BRQ.Core.Domain;

public class Especialidade : Entity
{
    public Especialidade() { }

    public Especialidade(string nome, Certificado certificado)
    {
        Nome = nome;
        Certificado = certificado;        
    }

    public string Nome { get; private set; } = default!;

    public Certificado? Certificado { get; private set; }
}
