using Infortechms.Gerenciamento.Business.Core.Notificacoes;
using Infortechms.Gerenciamento.Business.Models.Patrimonios;
using Infortechms.Gerenciamento.Business.Models.Patrimonios.Validations;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class PatrimonioService : BaseService, IPatrimonioService
    {
        private readonly IPatrimonioRepository _patrimonioRepository;

        public PatrimonioService(IPatrimonioRepository patrimonioRepository,
                                         INotificador notificador) : base(notificador)
        {
            _patrimonioRepository = patrimonioRepository;
        }
        public async Task Adicionar(Patrimonio patrimonio)
        {
            if (!ExecutarValidacao(new PatrimonioValidation(), patrimonio)) return;

            if (await PatrimonioExistente(patrimonio)) return;

            await _patrimonioRepository.Adicionar(patrimonio);
        }

        public async Task Atualizar(Patrimonio patrimonio)
        {
            if (!ExecutarValidacao(new PatrimonioValidation(), patrimonio)) return;

            if (await PatrimonioExistente(patrimonio)) return;

            await _patrimonioRepository.Atualizar(patrimonio);
        }

        private async Task<bool> PatrimonioExistente(Patrimonio patrimonio)
        {
            var funcionarioAtual = await _patrimonioRepository.Buscar(f => f.NumeroPatrimonio == f.NumeroPatrimonio && f.Id != patrimonio.Id);
            return funcionarioAtual.Any();
        }
        public async Task Remover(Guid id)
        {
            _patrimonioRepository.Remover(id);
        }
        public void Dispose()
        {
            _patrimonioRepository?.Dispose();
        }
    }
}
