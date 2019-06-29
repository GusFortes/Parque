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
        FachadaParque fachada = new FachadaParque();
        List<Passaporte> passa = new List<Passaporte>();
        PromocoesAtivas[] descontos = new PromocoesAtivas[4];
        PromocoesAtivas descontoUni = PromocoesAtivas.UNIVERSITARIO;
        PromocoesAtivas descontoIdoso = PromocoesAtivas.IDOSO;
        PromocoesAtivas descontoPague = PromocoesAtivas.PAGUEBEM;
        PromocoesAtivas descontoSeguro = PromocoesAtivas.SEGUROGARANTIDO;


        public IActionResult Index()
        {
            Passaporte novo = new Passaporte() { DataInicial = DateTime.Now };

            List <Descontos> descontos = fachada.ConsultaDescontosHabilitados();
            var checkBoxListItems = new List<CheckBoxListItem>();

            foreach (Descontos d in descontos)
                checkBoxListItems.Add(new CheckBoxListItem()
                {
                    Display = d.NomeDesconto,
                    IsChecked = false 
                });

            novo.Promocoes = checkBoxListItems;
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

            for(int i = 0; i <= pass.Promocoes.Count; i++)
            {

            }

            IPassaporte ipassaporte = fachada.CriarPassaporte(0, pass.NomeCliente, pass.NroDias, 100, pass.DataInicial.Day, pass.DataInicial.Month, pass.DataInicial.Year, descontos);
            Passaporte passaporte = new Passaporte();

            passaporte.NomeCliente = ipassaporte.NomeCliente;
            passaporte.NroDias = ipassaporte.NroDias;
            passaporte.DataInicial = ipassaporte.DataInicial;
            passaporte.ValorTotal = ipassaporte.valorTotal();
            passa.Add(passaporte);
            return View("Orcar", passa);

        }

        [HttpPost]
        public IActionResult ConfirmaCompra()
        {

            passa.Add(fachada.ComprarPassaporte());
            return View("ConfirmaCompra", passa);
        }

        [HttpPost]
        public IActionResult Voltar()
        {
            return View("Index");
        }
    }
}