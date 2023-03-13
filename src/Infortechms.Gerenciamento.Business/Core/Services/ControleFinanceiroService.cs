using Infortechms.Gerenciamento.Business.Core.Notificacoes;
using Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros;
using Infortechms.Gerenciamento.Business.Models.ControlesFinanceiros.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    class ControleFinanceiroService : BaseService, IControleFinanceiroService
    {
        private readonly IControleFinanceiroRepository _controleFinanceiroRepository;

        public ControleFinanceiroService(IControleFinanceiroRepository controleFinanceiroRepository,
                                 INotificador notificador) : base(notificador)
        {
            _controleFinanceiroRepository = controleFinanceiroRepository;
        }

        public async Task Adicionar(ControleFinanceiro controleFinanceiro)
        {
            if (!ExecutarValidacao(new ControleFinanceiroValidation(), controleFinanceiro)) return;

            await _controleFinanceiroRepository.Adicionar(controleFinanceiro);
        }

        public async Task Atualizar(ControleFinanceiro controleFinanceiro)
        {
            if (!ExecutarValidacao(new ControleFinanceiroValidation(), controleFinanceiro)) return;

            await _controleFinanceiroRepository.Atualizar(controleFinanceiro);
        }

        public void Dispose()
        {
            _controleFinanceiroRepository?.Dispose();
        }
    }
}
