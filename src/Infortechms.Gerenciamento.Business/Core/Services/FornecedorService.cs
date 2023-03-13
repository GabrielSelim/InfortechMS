using Infortechms.Gerenciamento.Business.Core.Notificacoes;
using Infortechms.Gerenciamento.Business.Models.Fornecedores;
using Infortechms.Gerenciamento.Business.Models.Fornecedores.Validations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class FornecedorService : BaseService, IFornecedorService
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedorService(IFornecedorRepository fornecedorRepository,                                 
                                 INotificador notificador) : base(notificador)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task Adicionar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;

            if (await FornecedorExistente(fornecedor)) return;

            await _fornecedorRepository.Adicionar(fornecedor);
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;

            if (await FornecedorExistente(fornecedor)) return;

            await _fornecedorRepository.Atualizar(fornecedor);
        }

        public async Task Remover(Guid id)
        {
            _fornecedorRepository.Remover(id);
        }

        private async Task<bool> FornecedorExistente(Fornecedor fornecedor)
        {
            var funcionarioAtual = await _fornecedorRepository.Buscar(f => f.CNPJ == f.CNPJ && f.Id != fornecedor.Id);
            return funcionarioAtual.Any();
        }

        public void Dispose()
        {
            _fornecedorRepository?.Dispose();
        }
    }
}
