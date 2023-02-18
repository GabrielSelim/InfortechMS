using Infortechms.Gerenciamento.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Pagamentos
{
    public interface IPagamentoRepository : IRepository<Pagamento>
    {
        Task<Pagamento> ObterPagamentoPorAbastecimento(Guid fk_abastecimento);
    }
}
