using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros.Validation;
using Infortechms.Gerenciamento.Business.Models.Enum;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros
{
    public class ControleFinanceiro : Entity
    {
        public Guid Fk_Funcionario { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal HoraExtra { get; set; }
        public decimal INSS { get; set; }
        public decimal IRRF { get; set; }
        public decimal OutrosDecontos { get; set; }
        public decimal TotalLiquido { get; set; }
        public decimal AjudaCusto { get; set; }
        public decimal ValeTransporte { get; set; }
        public decimal Total_Vt_AC { get; set; }
        public decimal TotalGeral { get; set; }
        public DateTime DataInicialVt { get; set; }
        public DateTime DataFinalVt { get; set; }
        public DateTime DataPagamento { get; set; }
        public TipoProjeto tipoProjeto { get; set; }


        /* EF Relations */
        public Funcionario Funcionario { get; set; }


        public bool Validacao()
        {
            var validacao = new ControleFinanceiroValidation();
            var resultado = validacao.Validate(this);
            return resultado.IsValid;
        }
    }
}
