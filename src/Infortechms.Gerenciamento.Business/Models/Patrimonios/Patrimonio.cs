using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Patrimonios
{
    public class Patrimonio : Entity
    {
        public Aquisicao Fk_Aquisicao { get; set; }
        public int NumeroPatrimonio { get; set; }
        public string Descricao { get; set; }
        public string Marca { get; set; }
        public DateTime DataCompra { get; set; }
        public DateTime DataGarantia { get; set; }
        public decimal Valor { get; set; }
        public bool Status { get; set; }


        /* EF Relations */
        public FuncionarioPatrimonio FuncionarioPatrimonio { get; set; }
    }
}
