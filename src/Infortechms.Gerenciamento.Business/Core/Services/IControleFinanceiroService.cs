using Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IControleFinanceiroService : IDisposable
    {
        Task Adicionar(ControleFinanceiro controleFinanceiro);
        Task Atualizar(ControleFinanceiro controleFinanceiro);
    }
}
