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


            ToTable("Aquisicao");
        }
    }
}
