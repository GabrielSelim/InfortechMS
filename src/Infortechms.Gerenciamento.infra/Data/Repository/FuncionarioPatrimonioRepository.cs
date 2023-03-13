using Infortechms.Gerenciamento.Business.Models.Enum;
using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;
using Infortechms.Gerenciamento.infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class FuncionarioPatrimonioRepository : Repository<FuncionarioPatrimonio>, IFuncionarioPatrimonioRepository
    {
        public FuncionarioPatrimonioRepository(ProjetoSalarioSContext context) : base(context) { }

        public Task<FuncionarioPatrimonio> ObterFuncionarioPorPatrimonio(Guid fk_patrimonio)
        {
            throw new NotImplementedException();
        }

        public Task<FuncionarioPatrimonio> ObterFuncionariosPatrimoniosPorLocal(local local)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FuncionarioPatrimonio>> ObterPatrimoniosPorFuncionario(Guid fk_funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
