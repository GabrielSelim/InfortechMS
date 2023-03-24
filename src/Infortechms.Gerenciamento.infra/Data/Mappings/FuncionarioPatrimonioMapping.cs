using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class FuncionarioPatrimonioMapping : EntityTypeConfiguration<FuncionarioPatrimonio>
    {
        public FuncionarioPatrimonioMapping()
        {
            HasKey(f => f.Id);

            HasRequired(f => f.Funcionarios)
                .WithMany(p => p.FuncionariosPatrimonios)
                .HasForeignKey(f => f.Fk_Funcionario);

            HasRequired(f => f.Patrimonios)
                .WithMany(p => p.FuncionariosPatrimonios)
                .HasForeignKey(f => f.Fk_Patrimonio);

            Property(p => p.DataDestinação)
                .IsRequired();

            Property(p => p.LocalPatrimonio)
                .IsRequired();


            ToTable("Enderecos");
        }
    }
}
