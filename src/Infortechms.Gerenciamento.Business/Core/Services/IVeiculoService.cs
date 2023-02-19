using Infortechms.Gerenciamento.Business.Models.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IVeiculoService : IDisposable
    {
        Task Adicionar(Veiculo veiculo);
        Task Atualizar(Veiculo veiculo);
        Task Remover(Guid id);
    }
}
