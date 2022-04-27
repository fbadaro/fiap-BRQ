namespace Fiap.BRQ.Core.Aggregate;

public class RG
{
    public RG(string numero)
    {
        Numero = numero;
    }

    public RG() { }

    public string Numero { get; private set; } = default!;

    private bool IsValid() => true;
}
