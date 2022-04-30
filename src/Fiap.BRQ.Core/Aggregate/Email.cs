namespace Fiap.BRQ.Core.Aggregate;

public class Email
{    
    public Email(string endereco)
    {
        Endereco = endereco;
    }

    public Email() { }

    public string Endereco { get; set; } = default!;    
}
