using Infortechms.Gerenciamento.Business.Models.Pagamentos;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public abstract class PagamentoRepository : Repository<Pagamento>, IPagamentoRepository
    {
        public async Task<Pagamento> ObterPagamentoPorAbastecimento(Guid fk_abastecimento)
        {
            return await Db.Pagamentos
                .AsNoTracking()
                .Include(x => x.Id)
                .FirstOrDefaultAsync(f => f.Id == fk_abastecimento);
        }
    }
}
