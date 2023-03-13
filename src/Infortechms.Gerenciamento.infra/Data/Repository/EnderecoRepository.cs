using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ProjetoSalarioSContext context) : base(context) { }

        public Task<Endereco> ObterEnderecoPorFuncionario(Guid fk_Funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
