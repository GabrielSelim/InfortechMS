using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.infra.Data.Mappings
{
    public class FuncionarioMapping : EntityTypeConfiguration<Funcionario>
    {
        public FuncionarioMapping()
        {
            HasKey(f => f.Id);


            ToTable("Funcionario");
        }
    }
}
