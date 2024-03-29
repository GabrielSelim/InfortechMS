﻿using System;
using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;
using Infortechms.Gerenciamento.Business.Models.HistoricoCargos;

namespace Infortechms.Gerenciamento.Business.Models.Funcionarios
{
    public class Funcionario : Entity
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string site { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDesligamento { get; set; }


        public Aquisicao Aquisicao { get; set; }
        public FuncionarioPatrimonio FuncionarioPatrimonio { get; set; }
        public HistoricosCargo HistoricosCargo { get; set; }

    }
}