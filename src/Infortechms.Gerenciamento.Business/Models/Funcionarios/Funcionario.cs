using FluentValidation;
using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using Infortechms.Gerenciamento.Business.Models.Cargos;
using Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros;
using Infortechms.Gerenciamento.Business.Models.Enum;
using Infortechms.Gerenciamento.Business.Models.Fornecedores.Validations;
using Infortechms.Gerenciamento.Business.Models.Funcionarios.Validations;
using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;
using System;
using System.Collections.Generic;

namespace Infortechms.Gerenciamento.Business.Models.Funcionarios
{
    public class Funcionario : Entity
    {
        public string Nome { get; set; }
        public Endereco FK_Endereco { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public int Telefone { get; set; }
        public int NitPis { get; set; }
        public string CNPJ { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }
        public TipoContrato TipoContrato { get; set; } 
        public local local { get; set; } 
        public bool status { get; set; }


        /* EF Relations */
        public ICollection<Aquisicao> Aquisicoes { get; set; }
        public Cargo Cargo { get; set; }
        public ICollection<FuncionarioPatrimonio> FuncionariosPatrimonios { get; set; }
        public ICollection<ControleFinanceiro> ControleFinanceiros { get; set; }

        /* EF Relations fk*/


        public bool Validacao()
        {
            var validacao = new FuncionarioValidation();
            var resultado = validacao.Validate(this);
            return resultado.IsValid;
        }
    }
}
