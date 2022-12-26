using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Infortechms.Gerenciamento.Business.Core.Data;

namespace Infortechms.Gerenciamento.Business.Models.Patrimonios
{
    public interface IPatrimonioRepository : IRepository<Patrimonio>
    {
        Task<IEnumerable<Patrimonio>> ObterPatrimonioPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Patrimonio>> ObterPatrimonioFornecedores();
        Task<Patrimonio> ObterProdutoPorAquisicao(Guid id);
    }
}