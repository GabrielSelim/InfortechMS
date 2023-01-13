using System.Data.Entity.ModelConfiguration;
using Infortechms.Gerenciamento.Business.Models.Patrimonios;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class PatrimonioConfig : EntityTypeConfiguration<Patrimonio>
    {
        public PatrimonioConfig()
        {
            HasKey(f => f.Id);

            HasRequired(f => f.Fk_Aquisicao)
                .WithRequiredPrincipal(c => c.Patrimonio);

            Property(f => f.NumeroPatrimonio)
                .IsRequired();

            Property(f => f.Marca)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.Descricao)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.DataCompra)
                .IsRequired();

            Property(f => f.NumeroSerie)
                .IsRequired()
                .HasMaxLength(50);


            ToTable("Patrimonio");
        }
    }
}