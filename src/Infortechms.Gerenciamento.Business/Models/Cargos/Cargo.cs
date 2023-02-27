using Infortechms.Gerenciamento.Business.Core.Models;
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
        public Funcionario Fk_Funcionario { get; set; }
        public string NomeCargo { get; set; }
    }
}
