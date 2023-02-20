using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel;
using Infortechms.Gerenciamento.infra.Data.Context;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class ConsumoCombustivelRepository : Repository<ConsumoCombustivel>, IConsumoCombustivelRepository
    {
        public ConsumoCombustivelRepository(ProjetoSalarioSContext context): base(context) { }

        public async Task<ConsumoCombustivel> ObterCombustivelPorId(Guid id)
        {
            return await Db.ConsumoCombustivels
                .AsNoTracking()
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}
