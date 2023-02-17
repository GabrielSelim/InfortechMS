using FluentValidation;
using Infortechms.Gerenciamento.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public abstract class BaseService
    {
        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV: AbstractValidator<TE> where TE: Entity
        {
            var validator = validacao.Validate(entidade);
            return validator.IsValid;
        }
    }
}
