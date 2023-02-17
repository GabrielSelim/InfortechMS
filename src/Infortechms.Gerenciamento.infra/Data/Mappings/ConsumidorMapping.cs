using Infortechms.Gerenciamento.Business.Models.Consumidores;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class ConsumidorMapping : EntityTypeConfiguration<Consumidor>
    {
        public ConsumidorMapping() 
        {
            HasKey(f => f.Id);

            Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(200);

            Property(f => f.CPF)
                .IsRequired()
                .HasMaxLength(11);

            Property(f => f.Telefone)
                .IsRequired();

            Property(f => f.DataNascimento)
                  .IsRequired();

            ToTable("Consumidor");
        }
    }
}
