using Infortechms.Gerenciamento.infra.Data.Context;
using System.Data.Entity.Migrations;

namespace Infortechms.Gerenciamento.AppMvc.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<InfortechMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}

