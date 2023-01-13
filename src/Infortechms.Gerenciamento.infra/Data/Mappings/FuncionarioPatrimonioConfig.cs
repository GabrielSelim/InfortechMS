using System.Data.Entity.ModelConfiguration;
using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class FuncionarioPatrimonioConfig : EntityTypeConfiguration<FuncionarioPatrimonio>
    {
        public FuncionarioPatrimonioConfig()
        {
            HasKey(f => f.Id);

            HasRequired(f => f.FK_Patrimonio)
                .WithRequiredPrincipal(c => c.FuncionarioPatrimonio);

            HasRequired(f => f.FK_Funcionario)
                .WithRequiredPrincipal(c => c.FuncionarioPatrimonio);

            Property(f => f.LocalDoPatrimonio)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.Data)
                .IsRequired();


            ToTable("FuncionarioPatrimonio");
        }
    }
}