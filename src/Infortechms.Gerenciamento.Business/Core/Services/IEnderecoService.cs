using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IEnderecoService : IDisposable
    {
        Task Adicionar(Endereco endereco);
        Task Atualizar(Endereco endereco);
    }
}
