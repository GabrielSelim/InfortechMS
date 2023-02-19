using Infortechms.Gerenciamento.Business.Core.Services;
using Infortechms.Gerenciamento.infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Infortechms.Gerenciamento.AppMvc.Controllers
{
    public class ConsumidorController : Controller
    {
        private readonly IConsumidorService _consumidorService;

        public ConsumidorController()
        {
            _consumidorService = new ConsumidorService(new ConsumidorRepository());
        }

        // GET: Consumidor
        public ActionResult Index()
        {
            return View();
        }
    }
}