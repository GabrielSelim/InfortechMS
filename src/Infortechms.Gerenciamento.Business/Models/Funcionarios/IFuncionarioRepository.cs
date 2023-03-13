using Infortechms.Gerenciamento.Business.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Funcionarios
{
    public interface IFuncionarioRepository : IRepository<Funcionario>
    {
        Task<Funcionario> ObterFuncionarioEndereco(Guid id);
        Task<Funcionario> ObterFuncionarioPatrimonioEndereco(Guid id);
        Task<Funcionario> ObterFuncionarioPorCargo(Guid fk_cargo);
        Task<Funcionario> ObterFuncionarioPorTipoContrato(int tipoContrato);
        Task<Funcionario> ObterFuncionarioPorLocal(int local);
        Task<Funcionario> ObterFuncionarioPorStatus(bool status);
    }
}
