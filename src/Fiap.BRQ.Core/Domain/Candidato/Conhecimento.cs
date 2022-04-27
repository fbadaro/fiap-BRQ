using Fiap.BRQ.Core.Entities;

namespace Fiap.BRQ.Core.Domain;

public class Conhecimento : Entity
{
    public Conhecimento()
    {
    }

    public Conhecimento(string tipo)
    {
        Tipo = tipo;
    }

    public string Tipo { get; private set; } = default!;
}
