namespace Fiap.BRQ.Core.Aggregate;

public class Endereco
{
    public Endereco(string logradouro, string complemento, string bairro, string cEP)
    {
        Logradouro = logradouro;
        Complemento = complemento;
        Bairro = bairro;
        CEP = cEP;
    }

    public Endereco() { }

    public string Logradouro { get; private set; } = default!;

    public string Complemento { get; private set; } = default!;

    public string Bairro { get; private set; } = default!;

    public string CEP { get; private set; } = default!;
}
