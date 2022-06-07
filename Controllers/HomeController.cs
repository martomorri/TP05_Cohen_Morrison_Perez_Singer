using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TP5.Models;

namespace TP5.Controllers
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

        public IActionResult Tutorial()
        {
            return View();
        }

        public IActionResult Comenzar()
        {
            Escape.reiniciarJuego();
            return View("Habitacion1");
        }

        [HttpPost]
        public IActionResult Habitacion(int sala, string incognita)
        {
            if(sala == Escape.estadoJuego) {
                bool correcto = Escape.resolverSala(sala, incognita);
                if(correcto) {
                    if(sala == 4) {
                        return View("Victoria");
                    }
                }
                else {
                    ViewBag.Error = "La clave es incorrecta. Intente nuevamente";
                }
            }
            return View("Habitacion" + Escape.estadoJuego);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
