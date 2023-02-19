using Infortechms.Gerenciamento.Business.Models.Consumidores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IConsumidorService : IDisposable
    {
        Task Adicionar(Consumidor consumidor);
        Task Atualizar(Consumidor consumidor);
        Task Remover(Guid id);
    }
}
