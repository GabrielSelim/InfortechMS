using FluentValidation;

namespace Infortechms.Gerenciamento.Business.Models.Abastecimentos.Validations
{
    public class AbastecerValidation : AbstractValidator<Abastecer>
    {
        public AbastecerValidation()
        {
            RuleFor(f => f.QuantidadeLitros)                
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");
        }
    }
}
