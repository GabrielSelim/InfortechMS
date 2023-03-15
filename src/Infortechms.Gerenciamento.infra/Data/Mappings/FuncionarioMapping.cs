using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class FuncionarioMapping : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMapping()
        {
            HasKey(f => f.Id);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            //Property(p => p.Descricao)
            //    .IsRequired()
            //    .HasMaxLength(1000);

            //Property(p => p.Imagem)
            //    .IsRequired()
            //    .HasMaxLength(100);

            //HasRequired(p => p.Fornecedor)
            //    .WithMany(f => f.Produtos)
            //    .HasForeignKey(p => p.FornecedorId);

            ToTable("Funcionario");
        }
    }
}
