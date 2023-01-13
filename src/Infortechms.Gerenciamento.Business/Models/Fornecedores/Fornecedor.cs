using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Patrimonios;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;

namespace Infortechms.Gerenciamento.Business.Models.Fornecedores
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }
        public int Telefone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string site { get; set; }

        /* EF Relations */
        public ICollection<Patrimonio> Patrimonios { get; set; }
        public Aquisicao Aquisicao { get; set; }
    }
}