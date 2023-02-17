using System.Data.Entity.Migrations;

namespace Infortechms.Gerenciamento.infra.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Data.Context.InfortechMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }
    }
}