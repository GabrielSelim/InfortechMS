using System;
using Infortechms.Gerenciamento.Business.Core.Data;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Abastecimentos
{
    public interface IAbastecerRepository : IRepository<Abastecer>
    {
        Task<Abastecer> ObterAquisicaoPorBombaCombustivel(Guid Fk_BombaCombustivel);
        Task<Abastecer> ObterAquisicaoPorConsumidor(Guid Fk_Consumidor);
        Task<Abastecer> ObterAquisicaoPorId(Guid id);
    }
}