using Infortechms.Gerenciamento.Business.Models.Veiculos;
using Infortechms.Gerenciamento.Business.Models.Veiculos.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class VeiculoService : BaseService, IVeiculoService
    {
        private readonly IVeiculoRepository _veiculoRepository;

        public VeiculoService(IVeiculoRepository veiculoRepository)
        {
            _veiculoRepository = veiculoRepository;
        }

        public async Task Adicionar(Veiculo veiculo)
        {
            if (!ExecutarValidacao(new VeiculoValidations(), veiculo)) return;

            if (await VeiculoExistente(veiculo)) return;

            await _veiculoRepository.Adicionar(veiculo);
        }

        public async Task Atualizar(Veiculo veiculo)
        {
            if (!ExecutarValidacao(new VeiculoValidations(), veiculo)) return;

            if (await VeiculoExistente(veiculo)) return;

            await _veiculoRepository.Adicionar(veiculo);
        }

        private async Task<bool> VeiculoExistente(Veiculo veiculo)
        {
            var abastecimentoAtual = await _veiculoRepository.Buscar(f => f.Id == veiculo.Id);
            return abastecimentoAtual.Any();
        }
        public void Dispose()
        {
            _veiculoRepository?.Dispose();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task Remover(Veiculo veiculo)
        {
            var removerId = _veiculoRepository.Remover(veiculo.Id);
        }

    }
}
