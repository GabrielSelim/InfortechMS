using Infortechms.Gerenciamento.Business.Models.RodarVeiculos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public abstract class RodarVeiculoRepository : Repository<RodarVeiculo>, IRodarVeiculoRepository
    {
        public virtual async Task<RodarVeiculo> DeletarLinhaPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RodarVeiculo>> ObterTodosCalculos()
        {
            return await ObterTodos();
        }

        public Task<RodarVeiculo> ObterValor(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RodarVeiculo>> ObterValorPorVeiculo(Guid fk_Veiculo)
        {
            return await Buscar(p => p.Fk_Abastecer == fk_Veiculo);
        }

        Task<RodarVeiculo> IRodarVeiculoRepository.ObterValorPorVeiculo(Guid fk_Veiculo)
        {
            throw new NotImplementedException();
        }
    }
}
