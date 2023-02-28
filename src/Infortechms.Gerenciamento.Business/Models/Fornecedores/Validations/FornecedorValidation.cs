using DevIO.Business.Core.Validations.Documentos;
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
            RuleFor(f => f.CNPJ.Length).Equal(CnpjValidacao.TamanhoCnpj)
                .WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");

            RuleFor(f => CpfValidacao.Validar(f.CNPJ)).Equal(true)
                .WithMessage("O documento fornecido é invalido");

            RuleFor(f => f.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O Campo {PropertyName} necessita ter entre {MinLenght} e {MaxLength} caracteres");
        }
    }
}
