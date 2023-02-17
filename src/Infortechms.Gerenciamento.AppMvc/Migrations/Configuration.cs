using System.Data.Entity.Migrations;

namespace Infortechms.Gerenciamento.AppMvc.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<infra.Data.Context.InfortechMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}

