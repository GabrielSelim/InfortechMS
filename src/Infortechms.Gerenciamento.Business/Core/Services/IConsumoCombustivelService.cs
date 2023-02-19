using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IConsumoCombustivelService : IDisposable
    {
        Task Adicionar(ConsumoCombustivel consumoCombustivel);
        Task Atualizar(ConsumoCombustivel consumoCombustivel);
        Task Remover(Guid id);
    }
}
