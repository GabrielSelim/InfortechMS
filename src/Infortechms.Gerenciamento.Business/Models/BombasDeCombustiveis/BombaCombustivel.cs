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
    public class BombaCombustivel
    {
        public Combustivel Fk_Combustivel { get; set; }
        public int LitrosNoTanqueJaquetado { get; set; }


        /*EF Relations*/
        public Consumidor Consumidor { get; set; }
    }
}
