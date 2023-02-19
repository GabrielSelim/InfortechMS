using Infortechms.Gerenciamento.Business.Models.Pagamentos;
using Infortechms.Gerenciamento.Business.Models.Pagamentos.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class PagamentoService : BaseService, IPagamentoService
    {

        private readonly IPagamentoRepository _pagamentoRepository;

        public PagamentoService(IPagamentoRepository pagamentoRepository)
        {
            _pagamentoRepository = pagamentoRepository;
        }

        public async Task Adicionar(Pagamento pagamento)
        {
            if (!ExecutarValidacao(new PagamentoValidations(), pagamento)) return;

            if (await PagamentoExistente(pagamento)) return;

            await _pagamentoRepository.Atualizar(pagamento);
        }

        public async Task Atualizar(Pagamento pagamento)
        {
            if (!ExecutarValidacao(new PagamentoValidations(), pagamento)) return;

            if (await PagamentoExistente(pagamento)) return;

            await _pagamentoRepository.Atualizar(pagamento);
        }

        private async Task<bool> PagamentoExistente(Pagamento pagamento)
        {
            var abastecimentoAtual = await _pagamentoRepository.Buscar(f => f.Id == pagamento.Id);
            return abastecimentoAtual.Any();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }


        public async Task Remover(Pagamento pagamento)
        {
            var removerId = _pagamentoRepository.Remover(pagamento.Id);
        }
    }
}
