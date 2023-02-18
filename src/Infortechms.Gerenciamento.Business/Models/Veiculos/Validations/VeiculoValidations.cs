using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Veiculos.Validations
{
    public class VeiculoValidations : AbstractValidator<Veiculo>
    {
        public VeiculoValidations()
        {
            RuleFor(f => f.Chassi)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido"); 

            RuleFor(f => f.Placa)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.LitrosNoTanque)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            RuleFor(f => f.VolumeTanque)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            RuleFor(f => f.MediaConsumo)
                .NotEmpty()
                .WithMessage("O campo {PropertyValue} precisa ser fornecido");

            RuleFor(f => f.Fk_Consumidor)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
