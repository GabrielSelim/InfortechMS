using System.Collections.Generic;
using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;

namespace Infortechms.Gerenciamento.Business.Models.Aquisicoes
{
    public class Aquisicao : Entity
    {
        public int NumeroNotaFiscal { get; set; }
        public decimal ValorNF { get; set; }
        public int Fk_Fornecedor { get; set; }
        public int Fk_Funcionario { get; set; }

        /* EF Relations */
        public ICollection<Fornecedor> Fornecedor { get; set; }
        public ICollection<Funcionario> Funcionario { get; set; }
    }
}