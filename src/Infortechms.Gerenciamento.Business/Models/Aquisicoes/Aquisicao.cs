using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes.Validations;
using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.Business.Models.Patrimonios;
using System;
using System.Collections.Generic;

namespace Infortechms.Gerenciamento.Business.Models.Aquisicoes
{
    public class Aquisicao : Entity
    {
        public Guid Fk_Fornecedor { get; set; }
        public Guid Fk_Funcionario { get; set; }
        public string NotaFiscal { get; set; }
        public decimal ValorNF { get; set; }
        public DateTime DataAquisicao { get; set; }

        /* EF Relations */
        public ICollection<Patrimonio> Patrimonio { get; set; }

        /* EF Relations fk*/
        public Funcionario Funcionarios { get; set; }
        public Fornecedor Fornecedores { get; set; }


        public bool Validacao()
        {
            var validacao = new AquisicaoValidation();
            var resultado = validacao.Validate(this);
            return resultado.IsValid;
        }
    }
}
