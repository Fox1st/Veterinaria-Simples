using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Veterinaria.Models;

namespace Veterinaria.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Servicos()
        {
            return View();
        }

        public IActionResult Agendamento()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult Agendamento (Agendamento agendamentoAtual)
        {
            ViewBag.Nome = agendamentoAtual.Nome;
            ViewBag.Telefone = agendamentoAtual.Telefone;
            ViewBag.Data = agendamentoAtual.Data;
            ViewBag.Animal = agendamentoAtual.Animal;
            ViewBag.Necessidade = agendamentoAtual.Necessidade;
            return View("Concluido");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
