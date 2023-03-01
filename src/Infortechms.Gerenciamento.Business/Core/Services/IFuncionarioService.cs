using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public interface IFuncionarioService : IDisposable
    {
        Task Adicionar(Funcionario funcionario);
        Task Atualizar(Funcionario funcionario);
        Task Remover(Guid id);

        Task AtualizarEndereco(Endereco endereco);
    }
}
