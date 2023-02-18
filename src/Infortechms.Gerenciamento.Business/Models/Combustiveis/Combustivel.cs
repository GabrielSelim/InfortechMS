using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Combustiveis
{
    public class Combustivel : Entity
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public string TipoCombustivel { get; set; }
        public int Pureza { get; set; }


        /*EF Relations Envia*/
        public ICollection<BombaCombustivel> BombaCombustivel { get; set; }

        /*EF Relations Pega*/

    }
}
