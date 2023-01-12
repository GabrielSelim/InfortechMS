using System.Data.Entity.ModelConfiguration;
using Infortechms.Gerenciamento.Business.Models.Funcoes;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class FuncaoConfig : EntityTypeConfiguration<Funcao>
    {
        public FuncaoConfig()
        {
            HasKey(f => f.Id);

            Property(f => f.NomeFuncao)
                .IsRequired()
                .HasMaxLength(200);

            ToTable("Funcoes");
        }
    }
}