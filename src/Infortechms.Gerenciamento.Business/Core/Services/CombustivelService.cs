using Infortechms.Gerenciamento.Business.Models.Combustiveis;
using Infortechms.Gerenciamento.Business.Models.Combustiveis.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class CombustivelService : BaseService, ICombustivelService
    {
        private readonly ICombustivelRepository _combustivelRepository;
        public CombustivelService(ICombustivelRepository combustivelRepository)
        {
            _combustivelRepository = combustivelRepository;
        }

        public async Task Adicionar(Combustivel combustivel)
        {
            if (!ExecutarValidacao(new CombustivelValidation(), combustivel)) return;

            await _combustivelRepository.Adicionar(combustivel);
        }

        public async Task Atualizar(Combustivel combustivel)
        {
            if (!ExecutarValidacao(new CombustivelValidation(), combustivel)) return;

            await _combustivelRepository.Atualizar(combustivel);
        }

        public void Dispose()
        {
            _combustivelRepository?.Dispose();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task RemoverCerto(Combustivel combustivel)
        {
            var removerId = _combustivelRepository.Remover(combustivel.Id);
        }
    }
}
