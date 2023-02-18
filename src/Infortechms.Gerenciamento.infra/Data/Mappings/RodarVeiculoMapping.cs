using Infortechms.Gerenciamento.Business.Models.RodarVeiculos;
using System.Data.Entity.ModelConfiguration;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class RodarVeiculoMapping : EntityTypeConfiguration<RodarVeiculo>
    {
        public RodarVeiculoMapping() 
        {
            HasKey(x => x.Id);

            HasRequired(f => f.Veiculo)
                .WithMany(e => e.RodarVeiculo)
                .HasForeignKey(p=>p.Fk_Veiculo);

            HasRequired(f => f.Abastecer)
                .WithMany(e => e.RodarVeiculo)
                .HasForeignKey(p=>p.Fk_Abastecer);

            Property(x => x.ValorDaGasolina)
                .IsOptional();

            Property(x => x.KmRodados)
                .IsRequired();

            Property(x => x.ValorConsumido)
                .IsRequired();

            Property(x => x.LitrosConsumidos)
                .IsRequired();


            ToTable("RodarVeiculos");
        }
    }
}
