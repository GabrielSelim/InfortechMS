using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis;
using Infortechms.Gerenciamento.Business.Models.BombasDeCombustiveis.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class BombaCombustivelService : BaseService, IBombaCombustivelService
    {
        private readonly IBombaCombustivelRepository _bombaCombustivelRepository;

        public BombaCombustivelService(IBombaCombustivelRepository bombaCombustivelRepository)
        {
            _bombaCombustivelRepository = bombaCombustivelRepository;
        }

        public async Task Adicionar(BombaCombustivel bombaCombustivel)
        {
            if (!ExecutarValidacao(new BombaCombustivelValidation(), bombaCombustivel)) return;
            if (await BombaExistenteExistente(bombaCombustivel)) return;

            await _bombaCombustivelRepository.Adicionar(bombaCombustivel);
        }

        public async Task Atualizar(BombaCombustivel bombaCombustivel)
        {
            if (!ExecutarValidacao(new BombaCombustivelValidation(), bombaCombustivel)) return;
            if (await BombaExistenteExistente(bombaCombustivel)) return;

            await _bombaCombustivelRepository.Adicionar(bombaCombustivel);
        }

        private async Task<bool> BombaExistenteExistente(BombaCombustivel bombaCombustivel)
        {
            var abastecimentoAtual = await _bombaCombustivelRepository.Buscar(f => f.Id == bombaCombustivel.Id);
            return abastecimentoAtual.Any();
        }

        public void Dispose()
        {
            _bombaCombustivelRepository?.Dispose();
        }
    }
}
