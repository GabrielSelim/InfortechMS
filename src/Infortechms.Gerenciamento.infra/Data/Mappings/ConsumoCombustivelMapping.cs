using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class ConsumoCombustivelMapping : EntityTypeConfiguration<ConsumoCombustivel>
    {
        public ConsumoCombustivelMapping()
        {
            HasKey(f => f.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.NumeroSerie)
                .IsRequired();

            Property(p => p.CapacidadeCombustivel)
                .IsRequired();


            ToTable("ConsumoCombustivel");
        }
    }
}
