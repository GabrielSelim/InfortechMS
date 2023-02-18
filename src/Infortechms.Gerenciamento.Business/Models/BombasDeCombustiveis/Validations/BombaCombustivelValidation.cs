using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis.Validations
{
    public class BombaCombustivelValidation : AbstractValidator<BombaCombustivel>
    {
        public BombaCombustivelValidation()
        {
            RuleFor(f => f.LitrosNoTanqueJaquetado)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");
        }
    }
}
