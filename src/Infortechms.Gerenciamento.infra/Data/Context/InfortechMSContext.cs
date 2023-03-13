using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using Infortechms.Gerenciamento.Business.Models.Cargos;
using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel;
using Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros;
using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;
using Infortechms.Gerenciamento.Business.Models.Patrimonios;
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
        public DbSet<Aquisicao> Aquisicoes { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<ControleFinanceiro> ControleFinanceiros { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<FuncionarioPatrimonio> FuncionarioPatrimonios { get; set; }
        public DbSet<Patrimonio> Patrimonios { get; set; }

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
            modelBuilder.Configurations.Add(new AquisicaoMapping());
            modelBuilder.Configurations.Add(new CargoMapping());
            modelBuilder.Configurations.Add(new ControleFinanceiroMapping());
            modelBuilder.Configurations.Add(new FornecedorMapping());
            modelBuilder.Configurations.Add(new FuncionarioMapping());
            modelBuilder.Configurations.Add(new EnderecoMapping());
            modelBuilder.Configurations.Add(new FuncionarioPatrimonioMapping());
            modelBuilder.Configurations.Add(new PatrimonioMapping());



            base.OnModelCreating(modelBuilder);
        }
    }
}