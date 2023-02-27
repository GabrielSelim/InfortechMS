using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using Infortechms.Gerenciamento.Business.Models.Cargos;
using Infortechms.Gerenciamento.Business.Models.Enum;
using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;
using System;

namespace Infortechms.Gerenciamento.Business.Models.Funcionarios
{
    public class Funcionario : Entity
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int RG { get; set; }
        public int Telefone { get; set; }
        public int NitPis { get; set; }
        public Endereco FK_Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal QuantidadeLitros { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }
        public TipoContrato TipoContrato { get; set; } 
        public local local { get; set; } 
        public bool status { get; set; }


        /* EF Relations */
        public Aquisicao Aquisicao { get; set; }
        public Cargo Cargo { get; set; }
        public FuncionarioPatrimonio FuncionarioPatrimonio { get; set; }
    }
}
