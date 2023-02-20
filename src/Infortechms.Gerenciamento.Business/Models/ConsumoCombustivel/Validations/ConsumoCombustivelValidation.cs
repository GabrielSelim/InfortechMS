using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel.Validations
{
    public class ConsumoCombustivelValidation : AbstractValidator<ConsumoCombustivel>
    {
        public ConsumoCombustivelValidation()
        {
            RuleFor(f => f.CapacidadeCombustivel)
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            RuleFor(f => f.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");
            RuleFor(f => f.NumeroSerie)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
