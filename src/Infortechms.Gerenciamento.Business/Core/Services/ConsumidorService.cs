using Infortechms.Gerenciamento.Business.Models.Consumidores;
using Infortechms.Gerenciamento.Business.Models.Consumidores.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class ConsumidorService : BaseService, IConsumidorService
    {
        private readonly IConsumidorRepository _consumidorRepository;

        public ConsumidorService(IConsumidorRepository consumidorRepository)
        {
            _consumidorRepository = consumidorRepository;
        }

        public async Task Adicionar(Consumidor consumidor)
        {
            if (!ExecutarValidacao(new ConsumidorValidations(), consumidor)) return;

            if (await ConsumidorExistente(consumidor)) return;

            await _consumidorRepository.Adicionar(consumidor);
        }

        public async Task Atualizar(Consumidor consumidor)
        {
            if (!ExecutarValidacao(new ConsumidorValidations(), consumidor)) return;

            if (await ConsumidorExistente(consumidor)) return;

            await _consumidorRepository.Adicionar(consumidor);
        }

        public void Dispose()
        {
            _consumidorRepository?.Dispose();
        }
        private async Task<bool> ConsumidorExistente(Consumidor consumidor)
        {
            var abastecimentoAtual = await _consumidorRepository.Buscar(f => f.Id == consumidor.Id);
            return abastecimentoAtual.Any();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task RemoverCerto (Consumidor consumidor)
        {
            var removerId = _consumidorRepository.Remover(consumidor.Id);
        }
    }
}
