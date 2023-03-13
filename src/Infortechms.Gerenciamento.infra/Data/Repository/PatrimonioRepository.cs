using Infortechms.Gerenciamento.Business.Models.Patrimonios;
using Infortechms.Gerenciamento.infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class PatrimonioRepository : Repository<Patrimonio>, IPatrimonioRepository
    {
        public PatrimonioRepository(ProjetoSalarioSContext context) : base(context) { }

        public Task<IEnumerable<Patrimonio>> ObterPatrimoniosPorAquisicao(Guid fk_aquisicao)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Patrimonio>> ObterPatrimoniosPorFuncionario(Guid fk_funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
