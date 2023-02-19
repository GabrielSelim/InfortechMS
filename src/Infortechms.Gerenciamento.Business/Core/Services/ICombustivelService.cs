using Infortechms.Gerenciamento.Business.Models.Combustiveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface ICombustivelService : IDisposable
    {
        Task Adicionar(Combustivel combustivel);
        Task Atualizar(Combustivel combustivel);
        Task Remover(Guid id);
    }
}
