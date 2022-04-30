using Fiap.BRQ.Core.Entities;

namespace Fiap.BRQ.Core.Domain;

public class Especialidade : Entity
{
    public Especialidade() { }

    public Especialidade(string nome, Candidato candidato, List<Certificado?> certificado)
    {
        Nome = nome;
        Candidato = candidato;
        Certificados = certificado!;
    }

    public string Nome { get; private set; } = default!;

    public Candidato Candidato { get; private set; } = default!;
    
    public List<Certificado> Certificados { get; private set; } = new List<Certificado>();
}
