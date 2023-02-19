using Infortechms.Gerenciamento.infra.Data.Context;
using System.Data.Entity.Migrations;

namespace Infortechms.Gerenciamento.AppMvc.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ProjetoSalarioSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}

