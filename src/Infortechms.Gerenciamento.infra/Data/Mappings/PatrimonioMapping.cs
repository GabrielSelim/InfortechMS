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

            HasRequired(f => f.Aquisicao)
                .WithMany(p => p.Patrimonio)
                .HasForeignKey(f => f.Fk_Aquisicao);

            Property(p => p.NumeroPatrimonio)
                .IsRequired();

            Property(p => p.Descricao)
                .IsRequired();

            Property(p => p.Marca)
                .IsRequired();

            Property(p => p.DataCompra)
                .IsRequired();

            Property(p => p.DataGarantia)
                .IsRequired();

            Property(p => p.Valor)
                .IsRequired();

            Property(p => p.Status)
                .IsRequired();


            ToTable("Patrimonios");
        }
    }
}
