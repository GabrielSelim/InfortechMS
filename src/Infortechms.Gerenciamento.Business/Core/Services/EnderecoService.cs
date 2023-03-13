using Infortechms.Gerenciamento.Business.Core.Notificacoes;
using Infortechms.Gerenciamento.Business.Models.Funcionarios;
using Infortechms.Gerenciamento.Business.Models.Funcionarios.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infortechms.Gerenciamento.Business.Core.Services
{
    public class EnderecoService : BaseService, IEnderecoService
    {
        private readonly IEnderecoRepository _enderecoRepository;

        public EnderecoService(IEnderecoRepository enderecoRepository,
                                         INotificador notificador) : base(notificador)
        {
            _enderecoRepository = enderecoRepository;
        }
        public async Task Adicionar(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;

            await _enderecoRepository.Adicionar(endereco);
        }

        public async Task Atualizar(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;

            await _enderecoRepository.Atualizar(endereco);
        }

        public void Dispose()
        {
            _enderecoRepository?.Dispose();
        }
    }
}
