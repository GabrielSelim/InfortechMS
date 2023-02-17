using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using Infortechms.Gerenciamento.Business.Models.Consumidores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Veiculos
{
    public class Veiculo
    {
        public Consumidor Fk_Consumidor { get; set; }
        public string Chassi { get; set; }
        public string Placa { get; set; }
        public int LitrosNoTanque { get; set; }
        public int VolumeTanque { get; set; }
    }
}
