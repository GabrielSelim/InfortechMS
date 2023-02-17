using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using Infortechms.Gerenciamento.Business.Models.Combustiveis;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class BombaDeCombustivelMapping : EntityTypeConfiguration<BombaCombustivel>
    {
        public BombaDeCombustivelMapping() 
        {
            HasKey(x => x.Id);

            HasRequired(f => f.Fk_Combustivel)
                .WithRequiredPrincipal(e => e.BombaCombustivel);

            Property(x => x.LitrosNoTanqueJaquetado)
                .IsRequired();


            ToTable("BombaDeCombustivel");
        }
    }
}
