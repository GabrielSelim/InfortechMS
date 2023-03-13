using Infortechms.Gerenciamento.Business.Models.Cargos;
using Infortechms.Gerenciamento.infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public class CargoRepository : Repository<Cargo>, ICargoRepository
    {
        public CargoRepository(ProjetoSalarioSContext context) : base(context) { }
    }
}
