using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Infortechms.Gerenciamento.AppMvc.Models;
using Infortechms.Gerenciamento.AppMvc.ViewModels;
using Infortechms.Gerenciamento.Business.Models.ConsumoCombustivel;
using Infortechms.Gerenciamento.Business.Core.Services;
using Infortechms.Gerenciamento.infra.Data.Repository;
using Infortechms.Gerenciamento.Business.Core.Notificacoes;
using AutoMapper;

namespace Infortechms.Gerenciamento.AppMvc.Controllers
{
    public class ConsumoCombustivelController : Controller
    {
        private readonly IConsumoCombustivelRepository _consumoCombustivelRepository;
        private readonly IConsumoCombustivelService _consumoCombustivelService;
        private readonly IMapper _mapper;

        public ConsumoCombustivelController(IConsumoCombustivelRepository consumoCombustivelRepository, 
                                            IConsumoCombustivelService consumoCombustivelService, IMapper mapper)
        {
            _consumoCombustivelRepository = consumoCombustivelRepository;
            _consumoCombustivelService = consumoCombustivelService;
            _mapper = mapper;
        }

        [Route("consumo-combustivel")]
        public async Task<ActionResult> Index()
        {           
            return View(_mapper.Map<IEnumerable<ConsumoCombustivelViewModel>>(await _consumoCombustivelRepository.ObterTodos()));
        }

        [Route("dados-consumo-combustivel/{id:guid}")]
        public async Task<ActionResult> Details(Guid id)
        {
            var ConsumoCombustivelViewModel  = await ObterConsumoCombustivel(id);

            if (ConsumoCombustivelViewModel == null)
            {
                return HttpNotFound();
            }
            return View(ConsumoCombustivelViewModel);
        }

        [Route("novo-consumo-combustivel")]
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [Route("novo-consumo-combustivel")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ConsumoCombustivelViewModel consumoCombustivelViewModel)
        {
            if (ModelState.IsValid)
            {
                await _consumoCombustivelService.Adicionar(_mapper.Map<ConsumoCombustivel>(consumoCombustivelViewModel));

                return RedirectToAction("Index");
            }

            return View(consumoCombustivelViewModel);
        }

        [Route("editar-consumo-combustivel/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Edit(Guid id)
        {
            var consumoCombustivelViewModel = await ObterConsumoCombustivel(id);

            if (consumoCombustivelViewModel == null)
            {
                return HttpNotFound();
            }

            return View(consumoCombustivelViewModel);
        }

        [Route("editar-consumo-combustivel/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ConsumoCombustivelViewModel consumoCombustivelViewModel)
        {
            if (ModelState.IsValid)
            {
                await _consumoCombustivelService.Atualizar(_mapper.Map<ConsumoCombustivel>(consumoCombustivelViewModel));
                return RedirectToAction("Index");
            }
            return View(consumoCombustivelViewModel);
        }

        [Route("correr-consumo-combustivel/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Correr(Guid id)
        {
            var consumoCombustivelViewModel = await ObterConsumoCombustivel(id);
            if (consumoCombustivelViewModel == null)
            {
                return HttpNotFound();
            }

            return View(consumoCombustivelViewModel);
        }

        [Route("correr-consumo-combustivel/{id:guid}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Correr(ConsumoCombustivelViewModel consumoCombustivelViewModel)
        {
            if (ModelState.IsValid)
            {
                consumoCombustivelViewModel.CapacidadeCombustivel = consumoCombustivelViewModel.CapacidadeCombustivel;
                consumoCombustivelViewModel.CombustivelAtual = 0;
                await _consumoCombustivelService.Atualizar(_mapper.Map<ConsumoCombustivel>(consumoCombustivelViewModel));
                return RedirectToAction("Index");
            }
            return View(consumoCombustivelViewModel);
        }

        [Route("excluir-consumo-combustivel/{id:guid}")]
        [HttpGet]
        public async Task<ActionResult> Delete(Guid id)
        {
            var consumoCombustivelViewModel = await ObterConsumoCombustivel(id);

            if (consumoCombustivelViewModel == null)
            {
                return HttpNotFound();
            }

            return View(consumoCombustivelViewModel);
        }

        [Route("excluir-consumo-combustivel/{id:guid}")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(Guid id)
        {
            var consumoCombustivelViewModel = await ObterConsumoCombustivel(id);

            if (consumoCombustivelViewModel == null)
            {
                return HttpNotFound();
            }

            await _consumoCombustivelService.Remover(id);

            return RedirectToAction("Index");
        }

        private async Task<ConsumoCombustivelViewModel> ObterConsumoCombustivel(Guid id)
        {
            var consumoCombustivel = _mapper.Map<ConsumoCombustivelViewModel>(await _consumoCombustivelRepository.ObterPorId(id));
            return consumoCombustivel;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _consumoCombustivelRepository.Dispose();
                _consumoCombustivelService.Dispose();
            }


            base.Dispose(disposing);
        }
    }
}
