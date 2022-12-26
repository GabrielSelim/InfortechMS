using System;
using System.Linq;
using System.Threading.Tasks;
using Infortechms.Gerenciamento.Business.Core.Data;

namespace Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios
{
    public interface IFuncionarioPatrimonioRepository : IRepository<FuncionarioPatrimonio>
    {
        Task<IQueryable<FuncionarioPatrimonio>> ObterFuncionarioPatrimonioPorPatrimonio(Guid patrimonioId);
        Task<IQueryable<FuncionarioPatrimonio>> ObterFuncionarioPatrimonioPorFuncionario(Guid patrimonioId);
    }
}