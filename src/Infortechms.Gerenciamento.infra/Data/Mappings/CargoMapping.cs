using Infortechms.Gerenciamento.Business.Models.Cargos;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class CargoMapping : EntityTypeConfiguration<Cargo>
    {
        public CargoMapping()
        {
            HasKey(f => f.Id);


            ToTable("Cargos");
        }
    }
}
