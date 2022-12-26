using System;
using System.Threading.Tasks;
using Infortechms.Gerenciamento.Business.Core.Data;

namespace Infortechms.Gerenciamento.Business.Models.HistoricoCargos
{
    public interface IHistoricoCargoRepository : IRepository<HistoricosCargo>
    {
        Task<HistoricosCargo> ObterHistoricoCargoPorFuncionario(Guid funcionarioId);
        Task<HistoricosCargo> ObterHistoricoCargoPorFuncao(Guid funcaoId);
        Task<HistoricosCargo> ObterHistoricoCargoStatusAtivo(Guid id);
    }
}