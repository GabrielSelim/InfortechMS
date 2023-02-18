using Infortechms.Gerenciamento.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Veiculos
{
    public interface IVeiculoRepository : IRepository<Veiculo>
    {
        Task<Veiculo> ObterVeiculoPorConsumidor(Guid fk_Consumidor);
        Task<Veiculo> ObterVeiculoPelaPlaca(Veiculo placa);
    }
}
