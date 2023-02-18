using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public abstract class BombaCombustivelRepository : Repository<BombaCombustivel>, IBombaCombustivelRepository
    {
        public async Task<BombaCombustivel> ObterBombaLitrosPorID(Guid id)
        {
            return await ObterPorId(id);
        }

        public async Task<BombaCombustivel> ObterBombaPorIdCombustivel(Guid Fk_Combustivel)
        {
            return await Db.BombasDeCombustiveis
                .AsNoTracking()
                .Include(x => x.Id)
                .FirstOrDefaultAsync(f => f.Id == Fk_Combustivel);
        }
    }
}
