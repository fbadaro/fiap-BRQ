using Fiap.BRQ.Core.Aggregate;
using Fiap.BRQ.Core.Entities;

namespace Fiap.BRQ.Core.Domain;

public class Candidato : Entity
{
    public Candidato()
    {
    }

    public Candidato(string nome, CPF cpf, Email email, Endereco endereco, RG rg)
    {
        Nome = nome;
        CPF = cpf;
        Email = email;
        Endereco = endereco;
        RG = rg;
    }    

    public string Nome { get; private set; } = default!;

    public CPF CPF { get; private set; } = default!;

    public Email Email { get; private set; } = default!;

    public Endereco Endereco { get; private set; } = default!;

    public RG RG { get; private set; } = default!;

    public string Telefone { get; private set; } = default!;
}
