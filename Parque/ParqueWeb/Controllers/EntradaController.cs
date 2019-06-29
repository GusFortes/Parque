using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParqueBLL;

namespace ParqueWeb.Controllers
{
    public class EntradaController : Controller
    {
        FachadaParque fachada = new FachadaParque();
        public IActionResult Index()
        {
            Entrada novo = new Entrada() { DataEntrada = DateTime.Now };
            //  ViewData["universitario"] = false;
            return View(novo);
        }

        [HttpPost]

        public IActionResult ConfirmaEntrada(Entrada entrada)
        {
            if (fachada.ConfirmarEntrada(entrada.DataEntrada, entrada.PassaporteID)) {
                List<Entrada> entradas = new List<Entrada>();
                entradas.Add(entrada);
                return View("ConfirmaEntrada", entradas);
            }
            return View("Erro");
        }

    }
}