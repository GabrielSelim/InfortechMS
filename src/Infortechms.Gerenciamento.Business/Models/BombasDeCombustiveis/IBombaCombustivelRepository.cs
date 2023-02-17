using System;
using System.Threading.Tasks;
using Infortechms.Gerenciamento.Business.Core.Data;
using Infortechms.Gerenciamento.Business.Models.Fornecedores;

namespace Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis
{
    public interface IBombaCombustivelRepository : IRepository<BombaCombustivel>
    {
        Task<BombaCombustivel> ObterBombaPorIdCombustivel(Guid Fk_Combustivel);
        Task<BombaCombustivel> ObterBombaLitrosPorID(Guid id);
    }
}