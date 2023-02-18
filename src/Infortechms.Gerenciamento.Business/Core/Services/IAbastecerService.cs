using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using System;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IAbastecerService : IDisposable
    {
        Task Adicionar(Abastecer abastecer);
        Task Atualizar(Abastecer abastecer);
        Task Remover(Guid id);
    }
}
