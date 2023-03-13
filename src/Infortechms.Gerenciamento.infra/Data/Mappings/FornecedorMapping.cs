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


            ToTable("Fonecedor");
        }
    }
}
