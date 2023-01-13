using System.Data.Entity.ModelConfiguration;
using Infortechms.Gerenciamento.Business.Models.HistoricoCargos;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class HistoricoCargoConfig : EntityTypeConfiguration<HistoricosCargo>
    {
        public HistoricoCargoConfig()
        {
            HasKey(f => f.Id);

            HasRequired(f => f.FK_Funcionario)
                .WithRequiredPrincipal(c => c.HistoricosCargo);

            HasRequired(f => f.FK_Funcao)
                .WithRequiredPrincipal(c => c.HistoricosCargo);

            Property(f => f.Salario)
                .IsRequired();

            Property(f => f.DataInicial)
                .IsRequired();

            Property(f => f.Status)
                .IsRequired();

            
            ToTable("HistoricoCargo");
        }
    }
}