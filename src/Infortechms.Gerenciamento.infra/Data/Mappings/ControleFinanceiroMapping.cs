using Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class ControleFinanceiroMapping : EntityTypeConfiguration<ControleFinanceiro>
    {
        public ControleFinanceiroMapping()
        {
            HasKey(f => f.Id);


            ToTable("Controle Financeiro");
        }
    }
}
