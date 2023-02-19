using Infortechms.Gerenciamento.Business.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel
{
    public class ConsumoCombustivel : Entity
    {
        public Guid id { get; set; }
        public string NumeroSerie { get; set; }
        public string Nome { get; set; }
        public decimal CapacidadeCombustivel { get; set; }
        public decimal CombustivelAtual { get; set; }
    }
}
