using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Combustiveis.Validations
{
    public class CombustivelValidation : AbstractValidator<Combustivel>
    {
        public CombustivelValidation()
        {
            RuleFor(f => f.TipoCombustivel)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.Valor)
                .NotEmpty()
                .GreaterThan(0)
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");
        }
    }
}
