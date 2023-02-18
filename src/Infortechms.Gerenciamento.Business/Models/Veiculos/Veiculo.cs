using System;
using System.Collections.Generic;
using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Consumidores;
using Infortechms.Gerenciamento.Business.Models.RodarVeiculos;

namespace Infortechms.Gerenciamento.Business.Models.Veiculos
{
    public class Veiculo : Entity
    {
        public Guid Fk_Consumidor { get; set; }
        public string Chassi { get; set; }
        public string Placa { get; set; }
        public decimal LitrosNoTanque { get; set; }
        public decimal VolumeTanque { get; set; }
        public decimal MediaConsumo { get; set; }

        /*EF Relations Envia*/
        public ICollection<RodarVeiculo> RodarVeiculo { get; set; }

        /*EF Relations Pega*/
        public Consumidor Consumidor { get; set; }
    }
}
