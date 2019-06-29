using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ParqueWeb.Controllers
{
    public class EntradaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}