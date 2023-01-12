using System.Data.Entity.ModelConfiguration;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class FuncionarioConfig : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioConfig()
        {
            HasKey(f => f.Id);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.CPF)
                .IsRequired()
                .HasMaxLength(11);

            Property(f=>f.Telefone)
                .IsRequired();

            Property(f => f.DataAdmissao)
                .IsRequired();

            ToTable("Funcionarios");
        }
    }
}