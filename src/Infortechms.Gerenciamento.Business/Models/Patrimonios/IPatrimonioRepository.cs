using Infortechms.Gerenciamento.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Patrimonios
{
    public interface IPatrimonioRepository : IRepository<Patrimonio>
    {
        Task<IEnumerable<Patrimonio>> ObterPatrimoniosPorAquisicao(Guid fk_aquisicao);
        Task<IEnumerable<Patrimonio>> ObterPatrimoniosPorFuncionario(Guid fk_funcionario);
    }
}
