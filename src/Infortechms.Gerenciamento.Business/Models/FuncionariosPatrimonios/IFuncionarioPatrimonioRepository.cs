using Infortechms.Gerenciamento.Business.Core.Data;
using Infortechms.Gerenciamento.Business.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios
{
    public interface IFuncionarioPatrimonioRepository : IRepository<FuncionarioPatrimonio>
    {
        Task<IEnumerable<FuncionarioPatrimonio>> ObterPatrimoniosPorFuncionario(Guid fk_funcionario);
        Task<FuncionarioPatrimonio> ObterFuncionarioPorPatrimonio(Guid fk_patrimonio);
        Task<FuncionarioPatrimonio> ObterFuncionariosPatrimoniosPorLocal(local local);
    }
}
