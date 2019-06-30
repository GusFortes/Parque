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

        public IActionResult Index()
        {
            Passaporte novo = new Passaporte() { DataInicial = DateTime.Now };

            List<Descontos> descontoshabilitados = fachada.ConsultaDescontosHabilitados();
            var checkBoxListItems = new List<CheckBoxListItem>();

            foreach (Descontos d in descontoshabilitados)
                checkBoxListItems.Add(new CheckBoxListItem()
                {
                    ID = d.ID,
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
            List<Descontos> checkeds = new List<Descontos>();
            PromocoesAtivas[] descontos = { PromocoesAtivas.SEMPROMOCAO, PromocoesAtivas.SEMPROMOCAO, PromocoesAtivas.SEMPROMOCAO, PromocoesAtivas.SEMPROMOCAO };

            foreach (CheckBoxListItem checkBox in pass.Promocoes)
            {
                if (checkBox.IsChecked)
                {
                    checkeds.Add(fachada.ConsultaDescontosPorID(checkBox.ID));
                }
            }

            foreach (Descontos d in checkeds)
            {

                if (d.ID == 1) { descontos[0] = PromocoesAtivas.UNIVERSITARIO; }
                if (d.ID == 2) { descontos[1] = PromocoesAtivas.PAGUEBEM; }
                if (d.ID == 3) { descontos[2] = PromocoesAtivas.IDOSO; }
                if (d.ID == 4) { descontos[3] = PromocoesAtivas.SEGUROGARANTIDO; }

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