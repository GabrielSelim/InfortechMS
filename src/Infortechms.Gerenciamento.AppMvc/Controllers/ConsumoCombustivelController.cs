using Infortechms.Gerenciamento.Business.Core.Services;
using Infortechms.Gerenciamento.infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infortechms.Gerenciamento.AppMvc.Controllers
{
    public class ConsumoCombustivelController : Controller
    {
        private readonly IConsumoCombustivelService _consumoCombustivelService;

        public ConsumoCombustivelController()
        {
            _consumoCombustivelService = new ConsumoCombustivelService(new ConsumoCombustivelRepository());
        }







        // GET: ConsumoCombustivelController
        public ActionResult Index()
        {
            return View();
        }
    }
}