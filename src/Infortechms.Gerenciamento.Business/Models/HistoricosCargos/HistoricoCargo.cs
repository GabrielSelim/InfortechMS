using System;
using System.Threading.Tasks;
using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.Business.Models.Funcoes;

namespace Infortechms.Gerenciamento.Business.Models.HistoricoCargos
{
    public class HistoricosCargo : Entity
    {
        public Funcao FK_Funcao { get; set; }
        public Funcionario FK_Funcionario { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public bool Status { get; set; }
    }
}