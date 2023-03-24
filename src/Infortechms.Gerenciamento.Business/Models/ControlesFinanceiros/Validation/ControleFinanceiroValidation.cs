using FluentValidation;
using Infortechms.Gerenciamento.Business.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros.Validation
{
    public class ControleFinanceiroValidation : AbstractValidator<ControleFinanceiro>
    {
        public ControleFinanceiroValidation()
        {
            RuleFor(f => f.DataPagamento)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            RuleFor(f => f.DataInicialVt)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            RuleFor(f => f.DataFinalVt)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            When(f => f.Funcionario.TipoContrato == TipoContrato.clt, () =>
            {
                RuleFor(f => f.ValeTransporte)
                    .NotEmpty()
                    .WithMessage("O campo {PropertyValue} precisa ser fornecido quando o Tipo contrato é CLT");

                RuleFor(f => f.AjudaCusto)
                    .NotEmpty()
                    .WithMessage("O campo {PropertyValue} precisa ser fornecido quando o Tipo contrato é CLT");
            });
        }
    }
}
