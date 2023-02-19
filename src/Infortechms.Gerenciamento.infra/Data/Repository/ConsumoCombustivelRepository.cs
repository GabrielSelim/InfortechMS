using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public abstract class ConsumoCombustivelRepository : Repository<ConsumoCombustivel>, IConsumoCombustivelRepository
    {
        public async Task<ConsumoCombustivel> ObterCombustivelPorId(Guid id)
        {
            return await Db.ConsumoCombustivel
                .AsNoTracking().FirstOrDefaultAsync(f => f.id);
        }
    }
}
