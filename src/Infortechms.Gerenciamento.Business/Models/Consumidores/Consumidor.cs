using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using Infortechms.Gerenciamento.Business.Models.Combustiveis;
using Infortechms.Gerenciamento.Business.Models.Veiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Models.Consumidores
{
    public class Consumidor : Entity
    {
        public Guid id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Telefone { get; set; }

        /* EF Relations */
        public Veiculo Veiculo { get; set; }
        public Abastecer Abastecer { get; set; }

    }
}
