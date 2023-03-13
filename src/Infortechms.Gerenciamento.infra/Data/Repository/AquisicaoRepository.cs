using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using Infortechms.Gerenciamento.infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class AquisicaoRepository : Repository<Aquisicao>, IAquisicaoRepository
    {
        public AquisicaoRepository(ProjetoSalarioSContext context) : base(context) { }

        public Task<Aquisicao> ObterAquisicaoPorData(DateTime dataAquisicao)
        {
            throw new NotImplementedException();
        }

        public Task<Aquisicao> ObterAquisicaoPorFornecedor(Guid fk_Fornecedor)
        {
            throw new NotImplementedException();
        }

        public Task<Aquisicao> ObterAquisicaoPorFuncionario(Guid fk_Funcionario)
        {
            throw new NotImplementedException();
        }

        public Task<Aquisicao> ObterValorNFPorFuncionario(Guid fk_Funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
