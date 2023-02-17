﻿using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using Infortechms.Gerenciamento.Business.Models.Consumidores;
using Infortechms.Gerenciamento.Business.Models.RodarVeiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Veiculos
{
    public class Veiculo : Entity
    {
        public Consumidor Fk_Consumidor { get; set; }
        public string Chassi { get; set; }
        public string Placa { get; set; }
        public decimal LitrosNoTanque { get; set; }
        public decimal VolumeTanque { get; set; }
        public decimal MediaConsumo { get; set; }

        /* EF Relations */
        public RodarVeiculo RodarVeiculo { get; set; }
    }
}
