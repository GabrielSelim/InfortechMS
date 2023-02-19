using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IBombaCombustivelService : IDisposable
    {
        Task Adicionar(BombaCombustivel bombaCombustivel);
        Task Atualizar(BombaCombustivel bombaCombustivel);
    }
}
