using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class AquisicaoConfig : EntityTypeConfiguration<Aquisicao>
    {
        public AquisicaoConfig()
        {
            HasKey(f => f.Id);

            Property(f => f.NumeroNotaFiscal)
                .IsRequired()
                .HasColumnAnnotation("IX_NumeroNF", new IndexAnnotation(new IndexAttribute{IsUnique = true}));

            Property(f => f.ValorNF)
                .IsRequired();

            HasRequired(f => f.Fk_Fornecedor)
                .WithRequiredPrincipal(e => e.Aquisicao);

            HasRequired(f=>f.Fk_Funcionario)
                .WithRequiredPrincipal(e => e.Aquisicao);
            

            ToTable("Aquisicoes");
        }
    }
}