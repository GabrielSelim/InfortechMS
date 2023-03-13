using Infortechms.Gerenciamento.Business.Models.Patrimonios;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class PatrimonioMapping : EntityTypeConfiguration<Patrimonio>
    {
        public PatrimonioMapping()
        {
            HasKey(f => f.Id);


            ToTable("Enderecos");
        }
    }
}
