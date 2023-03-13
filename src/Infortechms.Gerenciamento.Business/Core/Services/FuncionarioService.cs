using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.Business.Core.Notificacoes;
using Infortechms.Gerenciamento.Business.Models.Funcionarios.Validations;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class FuncionarioService : BaseService, IFuncionarioService
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IEnderecoRepository _enderecoRepository ;

        public FuncionarioService(IFuncionarioRepository funcionarioRepository,
                                 IEnderecoRepository enderecoRepository,
                                 INotificador notificador) : base(notificador)
        {
            _funcionarioRepository = funcionarioRepository;
            _enderecoRepository = enderecoRepository;
        }

        public async Task Adicionar(Funcionario funcionario)
        {
            if (!ExecutarValidacao(new FuncionarioValidation(), funcionario)
            || !ExecutarValidacao(new EnderecoValidation(), funcionario.FK_Endereco)) return;

            if (await FuncionarioExistente(funcionario)) return;

            await _funcionarioRepository.Adicionar(funcionario);
        }

        public async Task Atualizar(Funcionario funcionario)
        {
            if (!ExecutarValidacao(new FuncionarioValidation(), funcionario)
            || !ExecutarValidacao(new EnderecoValidation(), funcionario.FK_Endereco)) return;

            if (await FuncionarioExistente(funcionario)) return;

            await _funcionarioRepository.Atualizar(funcionario);
        }


        public Task AtualizarEndereco(Endereco endereco)
        {
            throw new NotImplementedException();
        }

        private async Task<bool> FuncionarioExistente(Funcionario funcionario)
        {
            var funcionarioAtual = await _funcionarioRepository.Buscar(f => f.CPF == funcionario.CPF && f.Id != funcionario.Id);
            return funcionarioAtual.Any();
        }

        public void Dispose()
        {
            _funcionarioRepository?.Dispose();
            _enderecoRepository?.Dispose();
        }
    }
}
