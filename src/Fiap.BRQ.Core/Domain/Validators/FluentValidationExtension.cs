namespace Fiap.BRQ.Core.Domain.Validators;

using FluentValidation;

public static class MyValidatorExtensions
{    
    public static IRuleBuilderOptions<T, string> IsValidCNPJ<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder.SetValidator(new CNPJValidator<T, string>());
    }
    
    public static IRuleBuilderOptions<T, string> IsValidCPF<T>(this IRuleBuilder<T, string> ruleBuilder)
    {
        return ruleBuilder.SetValidator(new CPFValidator<T, string>());
    }
}
