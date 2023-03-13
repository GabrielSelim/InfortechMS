using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IAquisicaoService : IDisposable
    {
        Task Adicionar(Aquisicao aquisicao);
        Task Atualizar(Aquisicao aquisicao);
    }
}
