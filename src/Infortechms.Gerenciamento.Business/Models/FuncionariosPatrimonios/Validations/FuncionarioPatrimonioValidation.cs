using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios.Validations
{
    public class FuncionarioPatrimonioValidation : AbstractValidator<FuncionarioPatrimonio>
    {
        public FuncionarioPatrimonioValidation()
        {
            RuleFor(f => f.DataDestinação)
                .NotEmpty()
                .WithMessage("O campo {PropertyName} precisa ser fornecido");
        }
    }
}
