using Infortechms.Gerenciamento.Business.Models.Veiculos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class VeiculoMapping : EntityTypeConfiguration<Veiculo>
    {
        public VeiculoMapping() 
        {
            HasKey(f => f.Id);

            HasRequired(f => f.Fk_Consumidor)
                  .WithRequiredPrincipal(e => e.Veiculo);

            Property(x => x.Chassi)
                .IsOptional();

            Property(x => x.Placa)
                .IsRequired();

            Property(x => x.VolumeTanque)
                .IsRequired();

            Property(x => x.LitrosNoTanque)
                .IsRequired();

            Property(x => x.MediaConsumo)
                .IsRequired();


            ToTable("VeiculosConsumidor");
        }
    }
}
