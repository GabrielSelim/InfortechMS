using Infortechms.Gerenciamento.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel
{
    public interface IConsumoCombustivelRepository : IRepository<ConsumoCombustivel>
    {
        Task<ConsumoCombustivel> ObterCombustivelPorId(Guid id);
    }
}
