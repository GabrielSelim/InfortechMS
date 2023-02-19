using Infortechms.Gerenciamento.Business.Models.Pagamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IPagamentoService : IDisposable
    {
        Task Adicionar(Pagamento pagamento);
        Task Atualizar(Pagamento pagamento);
        Task Remover(Guid id);
    }
}
