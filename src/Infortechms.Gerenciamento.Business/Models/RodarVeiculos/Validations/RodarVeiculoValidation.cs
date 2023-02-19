using FluentValidation;

namespace Infortechms.Gerenciamento.Business.Models.RodarVeiculos.Validations
{
    public class RodarVeiculoValidation : AbstractValidator<RodarVeiculo>
    {
      public RodarVeiculoValidation()
        {
            RuleFor(f => f.KmRodados)
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("O Campo {PropertyValue} precisa ser fornecido");
        }
    }
}
