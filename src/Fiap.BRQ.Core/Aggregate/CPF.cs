namespace Fiap.BRQ.Core.Aggregate;

public class CPF
{
    public CPF(string numero, string emissor, string uF)
    {
        Numero = numero;
        Emissor = emissor;
        UF = uF;
    }

    public CPF() { }

    public string Numero { get; set; } = default!;

    public string Emissor { get; set; } = default!;

    public string UF { get; set; } = default!;

    private bool IsValid() => true;
}
