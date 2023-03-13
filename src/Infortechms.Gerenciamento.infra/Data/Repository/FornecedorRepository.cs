using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using Infortechms.Gerenciamento.infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(ProjetoSalarioSContext context) : base(context) { }

    }
}
