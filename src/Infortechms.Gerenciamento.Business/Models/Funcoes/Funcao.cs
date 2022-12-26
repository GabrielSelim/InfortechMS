using Infortechms.Gerenciamento.Business.Core.Models;
using Infortechms.Gerenciamento.Business.Models.HistoricoCargos;

namespace Infortechms.Gerenciamento.Business.Models.Funcoes
{
    public class Funcao : Entity
    {
        public string NomeFuncao { get; set; }

        /* EF Relations */
        public HistoricosCargo HistoricosCargo { get; set; }
    }
}