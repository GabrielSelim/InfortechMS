using System;
using System.Linq;
using System.Threading.Tasks;
using Infortechms.Gerenciamento.Business.Core.Data;

namespace Infortechms.Gerenciamento.Business.Models.Aquisicoes
{
    public interface IAquisicaoRepository : IRepository<Aquisicao>
    {
        Task<Aquisicao> ObterAquisicaoPorFornecedor(Guid fornecedorId);
        Task<Aquisicao> ObterAquisicaoPorFuncionario(Guid funcionarioId);
    }
}