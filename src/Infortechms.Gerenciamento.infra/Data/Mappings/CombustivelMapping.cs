using Infortechms.Gerenciamento.Business.Models.Combustiveis;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class CombustivelMapping : EntityTypeConfiguration<Combustivel>
    {
        public CombustivelMapping()
        {
            HasKey(x => x.Id);

            Property(f => f.TipoCombustivel)
                .HasMaxLength(100)
                .IsRequired();

            Property(f => f.Valor)
                .IsRequired();

            Property(f => f.Pureza)
                .IsOptional();


            ToTable("Combustivel");
        }
    }
}
