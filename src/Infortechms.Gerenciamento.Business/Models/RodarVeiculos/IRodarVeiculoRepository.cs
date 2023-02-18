using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infortechms.Gerenciamento.Business.Core.Data;

namespace Infortechms.Gerenciamento.Business.Models.RodarVeiculos
{
    public interface IRodarVeiculoRepository : IRepository<RodarVeiculo>
    {
        Task<RodarVeiculo> ObterValor(Guid id);
        Task<IEnumerable<RodarVeiculo>> ObterTodosCalculos();
    }
}