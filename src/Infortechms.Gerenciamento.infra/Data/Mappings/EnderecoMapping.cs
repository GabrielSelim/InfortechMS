﻿using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class EnderecoMapping : EntityTypeConfiguration<Endereco>
    {
        public EnderecoMapping()
        {
            HasKey(f => f.Id);

            Property(c => c.Logradouro)
                .IsRequired()
                .HasMaxLength(200);

            Property(c => c.Numero)
                .IsRequired()
                .HasMaxLength(50);

            Property(c => c.Cep)
                .IsRequired()
                .HasMaxLength(8)
                .IsFixedLength();

            Property(c => c.Complemento)
                .HasMaxLength(250);

            Property(c => c.Bairro)
                .IsRequired();

            Property(c => c.Cidade)
                .IsRequired();

            Property(c => c.Estado)
                .IsRequired();

            ToTable("Enderecos");
        }
    }
}
