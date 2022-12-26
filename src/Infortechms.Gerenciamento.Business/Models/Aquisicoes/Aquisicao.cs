using System.Collections.Generic;
using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;

namespace Infortechms.Gerenciamento.Business.Models.Aquisicoes
{
    public class Aquisicao : Entity
    {
        public int NumeroNotaFiscal { get; set; }
        public decimal ValorNF { get; set; }
        public int Fk_Fornecedor { get; set; }
        public int Fk_Funcionario { get; set; }

        /* EF Relations */
        public ICollection<FuncionarioPatrimonio> FuncionarioPatrimonios { get; set; }
    }
}