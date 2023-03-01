using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Cargos.Validations
{
    public class CargoValidation : AbstractValidator<Cargo>
    {
        public CargoValidation()
        {
            RuleFor(f => f.NomeCargo)
                    .NotEmpty()
                    .WithMessage("O campo {PropertyName} precisa ser fornecido")
                    .Length(2, 200)
                    .WithMessage("O Campo {PropertyName} necessita ter entre {MinLenght} e {MaxLength} caracteres");
        }
    }
}
