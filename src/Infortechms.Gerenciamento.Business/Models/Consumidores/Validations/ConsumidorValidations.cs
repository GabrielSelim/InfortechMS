using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Consumidores.Validations
{
    public class ConsumidorValidations : AbstractValidator<Consumidor>
    {
        public ConsumidorValidations()
        {
            RuleFor(f => f.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyNome} precisa ser fornecido");

            RuleFor(f => f.CPF)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            RuleFor(f => f.DataNascimento)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            RuleFor(f => f.Telefone)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");
        }
    }
}
