using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
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

            Property(p => p.DataAdmissao)
                .IsRequired();

            Property(p => p.DataNascimento)
                .IsRequired();

            Property(p => p.local)
                .IsRequired();

            Property(p => p.status)
                .IsRequired();

            Property(p => p.TipoContrato)
                .IsRequired();

            Property(p => p.CPF)
                .IsRequired()
                .HasMaxLength(11)
                .HasColumnAnnotation("IX_CPF",
                    new IndexAnnotation(new IndexAttribute { IsUnique = true }));

            HasRequired(f => f.FK_Endereco)
                .WithRequiredPrincipal(e => e.Funcionario);

            ToTable("Funcionario");
        }
    }
}
