using System.Data.Entity;
using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using Infortechms.Gerenciamento.Business.Models.Combustiveis;
using Infortechms.Gerenciamento.Business.Models.Consumidores;
using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.Business.Models.FuncionariosPatrimonios;
using Infortechms.Gerenciamento.Business.Models.Funcoes;
using Infortechms.Gerenciamento.Business.Models.HistoricoCargos;
using Infortechms.Gerenciamento.Business.Models.Pagamentos;
using Infortechms.Gerenciamento.Business.Models.Patrimonios;
using Infortechms.Gerenciamento.Business.Models.RodarVeiculos;
using Infortechms.Gerenciamento.Business.Models.Veiculos;
using Infortechms.Gerenciamento.infra.Data.Mappings;

namespace Infortechms.Gerenciamento.infra.Data.Context
{
    public class InfortechMSContext : DbContext
    {
        public InfortechMSContext() : base("DefaultConnection")
        { }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Aquisicao> Aquisicoes { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioPatrimonio> FuncionariosPatrimonios { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<HistoricosCargo> HistoricosCargos { get; set; }
        public DbSet<Patrimonio> Patrimonios { get; set; }

        //Teste para Jean com finalidade de  Subir Cargo
        public DbSet<Abastecer> Abastecimentos { get; set; }
        public DbSet<BombaCombustivel> BombasDeCombustiveis { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumidor> Consumidores { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Combustivel> Combustiveis { get; set; }
        public DbSet<RodarVeiculo> RodarVeiculos { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AbastecerMapping());
            modelBuilder.Configurations.Add(new AquisicaoConfig());
            modelBuilder.Configurations.Add(new BombaDeCombustivelMapping());
            modelBuilder.Configurations.Add(new CombustivelMapping());
            modelBuilder.Configurations.Add(new ConsumidorMapping());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new FornecedorConfig());
            modelBuilder.Configurations.Add(new FuncaoConfig());
            modelBuilder.Configurations.Add(new FuncionarioConfig());
            modelBuilder.Configurations.Add(new FuncionarioPatrimonioConfig());
            modelBuilder.Configurations.Add(new HistoricoCargoConfig());
            modelBuilder.Configurations.Add(new PagamentoMapping());
            modelBuilder.Configurations.Add(new PatrimonioConfig());
            modelBuilder.Configurations.Add(new RodarVeiculoMapping());
            modelBuilder.Configurations.Add(new VeiculoMapping());
        }
    }
}