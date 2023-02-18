using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using Infortechms.Gerenciamento.Business.Models.Veiculos;
using System;

namespace Infortechms.Gerenciamento.Business.Models.RodarVeiculos
{
    public class RodarVeiculo :  Entity
    {
        public Guid Id { get; set; }
        public Guid Fk_Veiculo { get; set; }
        public Guid Fk_Abastecer { get; set; }
        public decimal ValorDaGasolina { get; set; }
        public decimal KmRodados { get; set; }
        public decimal ValorConsumido { get; set; }
        public decimal LitrosConsumidos { get; set; }


        /*EF Relations Envia*/

        /*EF Relations Pega*/
        public Abastecer Abastecer { get; set; }
        public Veiculo Veiculo { get; set; }

    }
}
