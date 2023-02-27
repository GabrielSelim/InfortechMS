using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using System.Collections.Generic;

namespace Infortechms.Gerenciamento.Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public int CNPJ { get; set; }
        public string Nome { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }

        /* EF Relations */
        public ICollection<Aquisicao> Aquisicao { get; set; }
    }
}
