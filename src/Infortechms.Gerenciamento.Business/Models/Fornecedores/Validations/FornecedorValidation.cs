using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Fornecedores.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.CNPJ)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            RuleFor(f => f.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O Campo {PropertyName} necessita ter entre {MinLenght} e {MaxLength} caracteres");
        }
    }
}
