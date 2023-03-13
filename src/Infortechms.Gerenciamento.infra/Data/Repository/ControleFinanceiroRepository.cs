using Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros;
using Infortechms.Gerenciamento.infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class ControleFinanceiroRepository : Repository<ControleFinanceiro>, IControleFinanceiroRepository
    {
        public ControleFinanceiroRepository(ProjetoSalarioSContext context) : base(context) { }

        public Task<IEnumerable<ControleFinanceiro>> ObterControleFinanceiroPorFuncionario(Guid fk_funcionario)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ControleFinanceiro>> ObterControleFinanceiroPorFuncionarioMes(Guid fk_funcionario, DateTime date)
        {
            throw new NotImplementedException();
        }
    }
}
