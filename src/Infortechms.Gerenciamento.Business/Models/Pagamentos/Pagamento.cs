using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Pagamentos
{
    public class Pagamento : Entity
    {
        public Guid Fk_Abastecimento { get; set; }
        public decimal ValorTotal { get; set; }


        /*EF Relations Envia*/

        /*EF Relations Pega*/
        public Abastecer Abastecer { get; set; }

    }
}
