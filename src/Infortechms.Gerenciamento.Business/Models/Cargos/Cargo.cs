using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Cargos.Validations;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Cargos
{
    public class Cargo : Entity
    {
        public string NomeCargo { get; set; }


        /* EF Relations */
        public Funcionario Funcionario { get; set; }

        public bool Validacao()
        {
            var validacao = new CargoValidation();
            var resultado = validacao.Validate(this);
            return resultado.IsValid;
        }
    }
}
