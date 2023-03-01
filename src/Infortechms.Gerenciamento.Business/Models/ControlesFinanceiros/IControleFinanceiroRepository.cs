using Infortechms.Gerenciamento.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros
{
    public interface IControleFinanceiroRepository : IRepository<ControleFinanceiro>
    {
        Task<IEnumerable<ControleFinanceiro>> ObterControleFinanceiroPorFuncionario(Guid fk_funcionario);
        Task<IEnumerable<ControleFinanceiro>> ObterControleFinanceiroPorFuncionarioMes(Guid fk_funcionario, DateTime date);

        //Obter a Soma total Geral do Mes Por Tipo Projeto
    }
}
