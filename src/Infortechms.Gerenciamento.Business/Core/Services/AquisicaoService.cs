using Infortechms.Gerenciamento.Business.Core.Notificacoes;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes;
using Infortechms.Gerenciamento.Business.Models.Aquisicoes.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class AquisicaoService : BaseService, IAquisicaoService
    {
        private readonly IAquisicaoRepository _aquisicaoRepository;

        public AquisicaoService(IAquisicaoRepository aquisicaoRepository,
                                         INotificador notificador) : base(notificador)
        {
            _aquisicaoRepository = aquisicaoRepository;
        }
        public async Task Adicionar(Aquisicao aquisicao)
        {
            if (!ExecutarValidacao(new AquisicaoValidation(), aquisicao)) return;

            await _aquisicaoRepository.Adicionar(aquisicao);
        }

        public async Task Atualizar(Aquisicao aquisicao)
        {
            if (!ExecutarValidacao(new AquisicaoValidation(), aquisicao)) return;

            await _aquisicaoRepository.Adicionar(aquisicao);
        }

        public void Dispose()
        {
            _aquisicaoRepository?.Dispose();
        }
    }
}
