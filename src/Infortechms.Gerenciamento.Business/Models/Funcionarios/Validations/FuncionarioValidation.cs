using DevIO.Business.Core.Validations.Documentos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Funcionarios.Validations
{
    public class FuncionarioValidation : AbstractValidator<Funcionario>
    {
        public FuncionarioValidation()
        {

            RuleFor(f => f.CPF.Length).Equal(CpfValidacao.TamanhoCpf)
                 .WithMessage("O campo CPF precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");

            RuleFor(f => CpfValidacao.Validar(f.CPF)).Equal(true)
                .WithMessage("O CPF fornecido é invalido");

            RuleFor(f => f.CNPJ.Length).Equal(CnpjValidacao.TamanhoCnpj)
                .WithMessage("O CNPJ Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}.");

            RuleFor(f => CpfValidacao.Validar(f.CNPJ)).Equal(true)
                .WithMessage("O CNPJ fornecido é invalido");

            RuleFor(f => f.Nome)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 200)
                .WithMessage("O Campo {PropertyName} necessita ter entre {MinLenght} e {MaxLength} caracteres");

            RuleFor(f => f.Telefone)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");
        }
    }
}
