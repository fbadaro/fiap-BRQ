using Fiap.BRQ.Core.Domain.Validators;
using FluentValidation;

namespace Fiap.BRQ.Core.Domain;

public class CandidatoValidator : AbstractValidator<Candidato>
{
    public CandidatoValidator()
    {        
        RuleSet("Create", () =>
        {
            RuleFor(n => n.Nome).NotEmpty().WithMessage("{PropertyName} não pode ser nulo.");
            RuleFor(n => n.CPF.Numero).IsValidCPF();
        });

        RuleSet("Update", () =>
        {
            RuleFor(n => n.Nome).NotEmpty().WithMessage("{PropertyName} não pode ser nulo.");
            RuleFor(n => n.CPF.Numero).IsValidCPF();
        });
    }
}
