using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using Infortechms.Gerenciamento.Business.Models.Abastecimentos.Validations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class AbastecerService : BaseService, IAbastecerService
    {
        private readonly IAbastecerRepository _abastecerRepository;

        public AbastecerService(IAbastecerRepository abastecerRepository)
        {
            _abastecerRepository = abastecerRepository;
        }

        public async Task Adicionar(Abastecer abastecer)
        {
            if (!ExecutarValidacao(new AbastecerValidation(), abastecer)) return;

            if (await AbastecerExistente(abastecer)) return;

            await _abastecerRepository.Adicionar(abastecer);

        }

        public async Task Atualizar(Abastecer abastecer)
        {
            if (!ExecutarValidacao(new AbastecerValidation(), abastecer)) return;

            if (await AbastecerExistente(abastecer)) return;

            await _abastecerRepository.Atualizar(abastecer);
        }

        private async Task<bool> AbastecerExistente(Abastecer abastecer)
        {
            var abastecimentoAtual = await _abastecerRepository.Buscar(f => f.Id == abastecer.Id);
            return abastecimentoAtual.Any();
        }
        public void Dispose()
        {
            _abastecerRepository?.Dispose();
        }

        public async Task Remover(Abastecer abastecer)
        {
            var removerId = _abastecerRepository.Remover(abastecer.Id);
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
