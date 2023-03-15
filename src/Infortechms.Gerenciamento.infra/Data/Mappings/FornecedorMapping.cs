using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class FornecedorMapping : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMapping()
        {
            HasKey(f => f.Id);

            Property(p => p.CNPJ)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(p => p.Telefone)
                .IsRequired();

            Property(p => p.Email)
                .HasMaxLength(200);


            ToTable("Fonecedor");
        }
    }
}
