using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParqueBLL;

namespace ParqueWeb.Controllers
{
    public class CompraController : Controller
    {
        private readonly ParqueContext db;
        FachadaParque fachada;

        public IActionResult Index()
        {
            Passaporte novo = new Passaporte() { DataInicial = DateTime.Now };

            return View(novo);
        }

        [HttpGet]
        public IActionResult Orcar()
        {
            Passaporte novo = new Passaporte() { DataInicial = DateTime.Now };

            return View(novo);

        }

        [HttpPost]
        public IActionResult Orcar(Passaporte pass)
        {
            List<Passaporte> passa = new List<Passaporte>();


            passa.Add(new Passaporte { NomeCliente = "teste", ValorTotal = 100   });

            return View("Orcar", passa);

        }

        [HttpGet]
        public IActionResult ConfirmaCompra()
        {
            return View();

        }
    }
}