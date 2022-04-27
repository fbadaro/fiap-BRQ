namespace Fiap.BRQ.Core.Entities;

internal class EntityValidationResult
{
    public bool IsValid { get; set; }

    public List<string> Messages { get; set; } = new List<string>();
}
