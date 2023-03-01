using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Aquisicoes.Validations
{
    public class AquisicaoValidation : AbstractValidator<Aquisicao>
    {
        public AquisicaoValidation()
        {
            RuleFor(f => f.NotaFiscal)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(9, 9)
                .WithMessage("O Campo {PropertyName} necessita ter {MaxLength} caracteres");

            RuleFor(f => f.ValorNF)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            RuleFor(f => f.DataAquisicao)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");
        }
    }
}
