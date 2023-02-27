using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.Business.Models.Patrimonios;

namespace Infortechms.Gerenciamento.Business.Models.Aquisicoes
{
    public class Aquisicao : Entity
    {
        public Fornecedor Fk_Fornecedor { get; set; }
        public Funcionario Fk_Funcionario { get; set; }
        public string NotaFiscal { get; set; }
        public decimal ValorNF { get; set; }
        public string Email { get; set; }

        /* EF Relations */
        public Patrimonio Patrimonio { get; set; }
    }
}
