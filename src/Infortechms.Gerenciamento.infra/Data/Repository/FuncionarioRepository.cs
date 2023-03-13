using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class FuncionarioRepository : Repository<Funcionario>, IFuncionarioRepository
    {
        public FuncionarioRepository(ProjetoSalarioSContext context) : base(context) { }

        public Task<Funcionario> ObterFuncionarioEndereco(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> ObterFuncionarioPatrimonioEndereco(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> ObterFuncionarioPorCargo(Guid fk_cargo)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> ObterFuncionarioPorLocal(int local)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> ObterFuncionarioPorStatus(bool status)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> ObterFuncionarioPorTipoContrato(int tipoContrato)
        {
            throw new NotImplementedException();
        }
    }
}
