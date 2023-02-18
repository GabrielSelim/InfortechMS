using Infortechms.Gerenciamento.Business.Models.Pagamentos;
using System.Data.Entity.ModelConfiguration;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class PagamentoMapping : EntityTypeConfiguration<Pagamento>
    {
        public PagamentoMapping()
        {
            HasKey(x => x.Id);

            HasRequired(f => f.Abastecer)
                 .WithMany(e => e.Pagamento)
                 .HasForeignKey(f=>f.Fk_Abastecimento);

            Property(x => x.ValorTotal)
                 .IsRequired();
        }
    }
}
