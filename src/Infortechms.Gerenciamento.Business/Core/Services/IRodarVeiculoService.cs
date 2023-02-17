using Infortechms.Gerenciamento.Business.Models.RodarVeiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IRodarVeiculoService : IDisposable
    {
        Task Adicionar(RodarVeiculo rodarVeiculo);
        Task Remover(Guid id);
    }
}
