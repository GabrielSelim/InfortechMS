using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class AbastecerMapping : EntityTypeConfiguration<Abastecer>
    {
        public AbastecerMapping() 
        {
            HasKey(f => f.Id);

        //    HasRequired(f => f.Fk_BombaCombustivel)
          //       .WithRequiredPrincipal(e => e.Abastecer);

            HasRequired(p => p.Fk_Consumidor)
                 .WithMany(f => f.Abastecer)
                 .HasForeignKey(c =>c.Fk_Consumidor);

            Property(x => x.QuantidadeLitros)
                .IsRequired();
            

            ToTable("Abastecer");
        }
    }
}
