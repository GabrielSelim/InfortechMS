using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using Infortechms.Gerenciamento.Business.Models.Combustiveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Consumidores
{
    public class Consumidor
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Telefone { get; set; }
        public BombaCombustivel Fk_BombaCombustivel { get; set; }
        public decimal QuantidadeLitros { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
