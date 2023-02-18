using Infortechms.Gerenciamento.Business.Models.Combustiveis;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Repository
{
    public abstract class CombustivelRepository : Repository<Combustivel>, ICombustivelRepository
    {
    }
}
