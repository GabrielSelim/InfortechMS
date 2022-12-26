using System;
using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.Business.Models.Patrimonios;

namespace Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios
{
    public class FuncionarioPatrimonio : Entity
    {
        public Patrimonio FK_Patrimonio { get; set; }
        public Funcionario FK_Funcionario { get; set; }
        public DateTime Data { get; set; }
        public string LocalDoPatrimonio { get; set; }
    }
}