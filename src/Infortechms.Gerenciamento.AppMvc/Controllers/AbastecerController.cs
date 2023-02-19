using Infortechms.Gerenciamento.Business.Core.Services;
using Infortechms.Gerenciamento.Business.Models.Abastecimentos;
using Infortechms.Gerenciamento.infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Infortechms.Gerenciamento.AppMvc.Controllers
{
    public class AbastecerController : Controller
    {
        private readonly IAbastecerService _abastecerService;

        public AbastecerController()
        {
            _abastecerService = new AbastecerService(new AbastecerRepository());
        }

        public async Task<ActionResult> Index()
        {
            var abastecer = new Abastecer()
            {
                QuantidadeLitros = 20
            };

            await _abastecerService.Adicionar(abastecer);

            return new EmptyResult();
        } 

        // GET: Abastecer

    }
}