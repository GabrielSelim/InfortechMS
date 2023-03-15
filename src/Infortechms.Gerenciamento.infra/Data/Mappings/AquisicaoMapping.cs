using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class AquisicaoMapping : EntityTypeConfiguration<Aquisicao>
    {
        public AquisicaoMapping()
        {
            HasKey(f => f.Id);

            Property(p => p.NotaFiscal)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.ValorNF)
                .IsRequired();

            HasRequired(f => f.Funcionarios)
                .WithMany(p => p.Aquisicoes)
                .HasForeignKey(f => f.Fk_Funcionario);

            HasRequired(f => f.Fornecedores)
                .WithMany(p => p.Aquisicao)
                .HasForeignKey(f => f.Fk_Fornecedor);

            Property(p => p.DataAquisicao)
                .IsRequired();


            ToTable("Aquisicoes");
        }
    }
}
