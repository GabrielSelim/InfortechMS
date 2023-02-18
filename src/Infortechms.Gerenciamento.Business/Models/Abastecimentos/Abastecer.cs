using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Abastecimentos.Validations;
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
        public Guid Id { get; set; }
        public Guid Fk_BombaCombustivel { get; set; }
        public Guid Fk_Consumidor { get; set; }
        public decimal QuantidadeLitros { get; set; }


        /*EF Relations Envia*/
        public ICollection<Pagamento> Pagamento { get; set; }
        public ICollection<RodarVeiculo> RodarVeiculo { get; set; }

        /*EF Relations Pega*/
        public Consumidor Consumidor { get; set; }
        public BombaCombustivel BombaCombustivel { get; set; }    


        public bool Validacao()
        {
            var validacao = new AbastecerValidation();
            var resultado = validacao.Validate(this);
            return resultado.IsValid;
        }

    }
}
