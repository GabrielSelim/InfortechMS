using Infortechms.Gerenciamento.Business.Core.Services;
using Infortechms.Gerenciamento.Business.Models.Consumidores;
using Infortechms.Gerenciamento.infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public async Task<ActionResult> Index()
        {
            var consumidor = new Consumidor()
            {
                Nome = "Gabriel Sanz Selim de Sales",
                CPF = "12345678910",
                DataNascimento = new DateTime(1990, 07, 12),
                Telefone = 998231019
            };
            var consumidor2 = new Consumidor()
            {
                Nome = "Joao",
                CPF = "12345678910",
                DataNascimento = new DateTime(1999, 07, 12),
                Telefone = 998231019
            };
            var consumidor3 = new Consumidor()
            {
                Nome = "Carlos Moura",
                CPF = "32165498701",
                DataNascimento = new DateTime(1994, 01, 01),
                Telefone = 993331011
            };
            var consumidor4 = new Consumidor()
            {
                Nome = "Jean Macedo",
                CPF = "01987654321",
                DataNascimento = new DateTime(1990, 01, 01),
                Telefone = 997777546
            };
            var consumidor5 = new Consumidor()
            {
                Nome = "Anna",
                CPF = "26897545610",
                DataNascimento = new DateTime(1999, 01, 01),
                Telefone = 997775123
            };
           // await _consumidorService.Adicionar(consumidor); 
            await _consumidorService.Adicionar(consumidor2);
            await _consumidorService.Adicionar(consumidor3);
            await _consumidorService.Adicionar(consumidor4);
            await _consumidorService.Adicionar(consumidor5);

            return new EmptyResult();
        }
        // GET: Consumidor

    }
}