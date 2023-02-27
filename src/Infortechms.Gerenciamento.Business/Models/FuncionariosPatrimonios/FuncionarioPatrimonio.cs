using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Enum;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.Business.Models.Patrimonios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios
{
    public class FuncionarioPatrimonio : Entity
    {
        public Funcionario Fk_Funcionario { get; set; }
        public Patrimonio Fk_Patrimonio { get; set; }
        public int DataDestinação { get; set; }
        public local LocalPatrimonio { get; set; }


        /* EF Relations */


    }
}
