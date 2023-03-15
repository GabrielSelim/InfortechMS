using Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class ControleFinanceiroMapping : EntityTypeConfiguration<ControleFinanceiro>
    {
        public ControleFinanceiroMapping()
        {
            HasKey(f => f.Id);

            Property(p => p.SalarioBase)
                .IsRequired();

            Property(p => p.TotalLiquido)
                .IsRequired();

            Property(p => p.tipoProjeto)
                .IsRequired();

            Property(p => p.DataPagamento)
                .IsRequired();

            HasRequired(f => f.Funcionario)
                .WithMany(p => p.ControleFinanceiros)
                .HasForeignKey(f => f.Fk_Funcionario);

            ToTable("Controle Financeiro");
        }
    }
}
