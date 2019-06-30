using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ParqueBLL;

namespace ParqueWeb.Controllers
{
    [Authorize]
    public class AdministradorController : Controller
    {
        FachadaParque fachada = new FachadaParque();
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Descontos()
        {
            return View("Descontos", fachada.ConsultaDescontos());
        }

        public IActionResult HabilitarDesabilitar(int id)
        {
            fachada.AlterarDesconto(id);

            return View("Descontos", fachada.ConsultaDescontos());
        }

        public IActionResult Relatorios()
        {
            return View();
        }


        public IActionResult DiarioMensal()
        {
            return View();

        }

        public IActionResult ConsultaDia(int dia)
        {
            return View("RelatorioVendas", fachada.ConsultaDia(dia));
        }

        public IActionResult ConsultaMes(int mes)
        {
            return View("RelatorioVendas", fachada.Consultames(mes));
        }

        public IActionResult Relatorio()
        {
            return View();
        }

        public IActionResult ConsultaVendasPeriodo()
        {
            return View();
        }

        public IActionResult ConsultarPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            return View("RelatorioVendas", fachada.ConsultaVendasPeriodo(dataInicial, dataFinal));
        }

        public IActionResult ConsultaEntradaPeriodo()
        {
            return View();
        }
        public IActionResult ConsultarEntrada(DateTime dataInicial, DateTime dataFinal)
        {
            return View("RelatorioEntrada", fachada.ConsultaEntradaPeriodo(dataInicial, dataFinal));
        }
    }

}