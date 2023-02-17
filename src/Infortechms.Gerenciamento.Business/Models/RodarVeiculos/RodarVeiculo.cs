﻿using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using Infortechms.Gerenciamento.Business.Models.Consumidores;
using Infortechms.Gerenciamento.Business.Models.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.RodarVeiculos
{
    public class RodarVeiculo :  Entity
    {
        public Veiculo Fk_Veiculo { get; set; }
        public Abastecer Fk_Abastecer { get; set; }
        public decimal ValorDaGasolina { get; set; }
        public decimal KmRodados { get; set; }
        public decimal ValorConsumido { get; set; }
        public decimal LitrosConsumidos { get; set; }
    }
}
