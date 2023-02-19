using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel;
using Infortechms.Gerenciamento.infra.Data.Mappings;

namespace Infortechms.Gerenciamento.infra.Data.Context
{
    public class ProjetoSalarioSContext : DbContext
    {
        public ProjetoSalarioSContext() : base("DefaultConnection")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        //Teste para Jean com finalidade de  Subir Cargo

        public DbSet<ConsumoCombustivel> ConsumoCombustivels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p =>  p
                    .HasColumnType("varchar")
                    .HasMaxLength(100));

            modelBuilder.Configurations.Add(new ConsumoCombustivelMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}