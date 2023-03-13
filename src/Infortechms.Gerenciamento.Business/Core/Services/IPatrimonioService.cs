using Infortechms.Gerenciamento.Business.Models.Patrimonios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IPatrimonioService : IDisposable
    {
        Task Adicionar(Patrimonio patrimonio);
        Task Atualizar(Patrimonio patrimonio);
        Task Remover(Guid id);
    }
}
