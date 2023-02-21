using Infortechms.Gerenciamento.AppMvc.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Infortechms.Gerenciamento.AppMvc.ViewModels
{
    public class ConsumoCombustivelViewModel
    {
        public ConsumoCombustivelViewModel()
        {
            id = Guid.NewGuid();
        }

        [Key]
        public Guid id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [DisplayName("Numero Serie")]
        public string NumeroSerie { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Nome")]
        public string Nome { get; set; }

        [litros]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Capacidade do Tanque")]
        public decimal CapacidadeCombustivel { get; set; }

        [litros]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayName("Combustivel Atual")]
        public decimal CombustivelAtual { get; set; }

    }
}