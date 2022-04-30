namespace Fiap.BRQ.Core.Aggregate;

public class RG
{
    public RG(string numero)
    {
        Numero = numero;
    }

    public RG() { }

    public string Numero { get; set; } = default!;    
}
