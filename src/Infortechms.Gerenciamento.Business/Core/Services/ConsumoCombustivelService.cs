using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel;
using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class ConsumoCombustivelService : BaseService, IConsumoCombustivelService
    {
        private readonly IConsumoCombustivelRepository _consumoCombustivelRepository;

        public ConsumoCombustivelService(IConsumoCombustivelRepository consumoCombustivelRepository)
        {
            _consumoCombustivelRepository = consumoCombustivelRepository;
        }

        public async Task Adicionar(ConsumoCombustivel consumoCombustivel)
        {
            if (!ExecutarValidacao(new ConsumoCombustivelValidation(), consumoCombustivel)) return;

            await _consumoCombustivelRepository.Adicionar(consumoCombustivel);
        }

        public async Task Atualizar(ConsumoCombustivel consumoCombustivel)
        {
            if (!ExecutarValidacao(new ConsumoCombustivelValidation(), consumoCombustivel)) return;

            await _consumoCombustivelRepository.Atualizar(consumoCombustivel);
        }

        public void Dispose()
        {
            _consumoCombustivelRepository?.Dispose();
        }

        public async Task Remover(Guid id)
        {
            _consumoCombustivelRepository.Remover(id);
        }
    }
}
