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
            if (sala == Escape.estadoJuego)
            {
                bool correcto = Escape.resolverSala(sala, incognita);
                if (correcto)
                {
                    if (sala == 4)
                    {
                        return View("Victoria");
                    }
                }
                else
                {
                    ViewBag.Error = "La clave es incorrecta. Intente nuevamente";
                }
            }
            return View("Habitacion" + Escape.estadoJuego);
        }

        [HttpPost]
        public IActionResult hab4(int pregunta, string incognita)
        {
            string[] vecEstadoH4 = Escape.resolverPregunta(pregunta, incognita);
            ViewBag.Estado0 = vecEstadoH4[0];
            ViewBag.Estado1 = vecEstadoH4[1];
            ViewBag.Estado2 = vecEstadoH4[2];
            ViewBag.Estado3 = vecEstadoH4[3];
            ViewBag.Estado4 = vecEstadoH4[4];
            ViewBag.Estado5 = vecEstadoH4[5];
            return View("Habitacion" + Escape.estadoJuego);
        }

        [HttpPost]
        public IActionResult hab3(int pregunta, string incognita)
        {
            string[] vecEstadoH3 = Escape.resolver4Fotos(pregunta, incognita);
            ViewBag.Estado0 = vecEstadoH3[0];
            ViewBag.Estado1 = vecEstadoH3[1];
            ViewBag.Estado2 = vecEstadoH3[2];
            return View("Habitacion" + Escape.estadoJuego);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
