using Infortechms.Gerenciamento.Business.Models.Veiculos;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class VeiculoRepository : Repository<Veiculo>, IVeiculoRepository
    {
        public Veiculo ObterVeiculoPelaPlacaCerto(string placa)
        {
            return Buscar(f=>f.Placa == placa).Result.FirstOrDefault();
        }

        public Task<Veiculo> ObterVeiculoPelaPlaca(Veiculo placa)
        {
            throw new NotImplementedException();
        }

        public async Task<Veiculo> ObterVeiculoPorConsumidor(Guid fk_Consumidor)
        {
            return await Db.Veiculos
                .AsNoTracking()
                .Include(x => x.Id)
                .FirstOrDefaultAsync(f => f.Id == fk_Consumidor);
        }
    }
}
