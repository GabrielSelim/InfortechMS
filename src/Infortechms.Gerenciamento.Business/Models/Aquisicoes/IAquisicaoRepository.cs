using Infortechms.Gerenciamento.Business.Core.Data;
using System;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Aquisicoes
{
    public interface IAquisicaoRepository : IRepository<Aquisicao>
    {
        Task<Aquisicao> ObterAquisicaoPorFornecedor(Guid fk_Fornecedor);
        Task<Aquisicao> ObterAquisicaoPorFuncionario(Guid fk_Funcionario);
        Task<Aquisicao> ObterValorNFPorFuncionario(Guid fk_Funcionario);
        Task<Aquisicao> ObterAquisicaoPorData(DateTime dataAquisicao);   
    }
}
