using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class AbastecerRepository : Repository<Abastecer>, IAbastecerRepository
    {
        public async Task<Abastecer> ObterAquisicaoPorBombaCombustivel(Guid Fk_BombaCombustivel)
        {
            return await Db.Abastecimentos
                .AsNoTracking()
                .Include(x => x.Id)
                .FirstOrDefaultAsync(f => f.Id == Fk_BombaCombustivel);
        }

        public async Task<Abastecer> ObterAquisicaoPorConsumidor(Guid Fk_Consumidor)
        {
            return await Db.Abastecimentos
                .AsNoTracking()
                .Include(x => x.Id)
                .FirstOrDefaultAsync(f => f.Id == Fk_Consumidor);
        }

        public Task<Abastecer> ObterAquisicaoPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}