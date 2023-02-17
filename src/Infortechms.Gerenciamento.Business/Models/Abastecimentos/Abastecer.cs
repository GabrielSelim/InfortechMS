using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using Infortechms.Gerenciamento.Business.Models.Consumidores;
using Infortechms.Gerenciamento.Business.Models.Pagamentos;
using Infortechms.Gerenciamento.Business.Models.RodarVeiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Abastecimentos
{
    public class Abastecer : Entity
    {
        public decimal QuantidadeLitros { get; set; }
        public BombaCombustivel Fk_BombaCombustivel { get; set; }
        public Consumidor Fk_Consumidor { get; set; }

        /* EF Relations */
        public Pagamento Pagamento { get; set; }
        public RodarVeiculo RodarVeiculo { get;set; }
    }
}
