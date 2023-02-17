using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using Infortechms.Gerenciamento.Business.Models.Combustiveis;
using Infortechms.Gerenciamento.Business.Models.Consumidores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis
{
    public class BombaCombustivel : Entity
    {
        public Combustivel Fk_Combustivel { get; set; }
        public decimal LitrosNoTanqueJaquetado { get; set; }


        /*EF Relations*/
        public Abastecer Abastecer { get; set; }
    }
}
