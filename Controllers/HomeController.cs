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
            bool correcto = Escape.resolverPregunta(pregunta, incognita);
            switch (pregunta)
            {
                case 0:
                    if (correcto)
                    {
                        ViewBag.Correcto0 = "¡CORRECTO!";
                        ViewBag.Incorrecto0 = "";
                    }
                    else {
                        ViewBag.Correcto0 = "";
                        ViewBag.Incorrecto0 = "INCORRECTO :(";
                    } 
                    break;
                case 1:
                    if (correcto)
                    {
                        ViewBag.Correcto1 = "¡CORRECTO!";
                        ViewBag.Incorrecto1 = "";
                    }
                    else {
                        ViewBag.Correcto1 = "";
                        ViewBag.Incorrecto1 = "INCORRECTO :(";
                    }
                    break;
                case 2:
                    if (correcto)
                    {
                        ViewBag.Correcto2 = "¡CORRECTO!";
                        ViewBag.Incorrecto2 = "";
                    }
                    else {
                        ViewBag.Correcto2 = "";
                        ViewBag.Incorrecto2 = "INCORRECTO :(";
                    }
                    break;
                case 3:
                    if (correcto)
                    {
                        ViewBag.Correcto3 = "¡CORRECTO!";
                        ViewBag.Incorrecto3 = "";
                    }
                    else {
                        ViewBag.Correcto3 = "";
                        ViewBag.Incorrecto3 = "INCORRECTO :(";
                    }
                    break;
                case 4:
                    if (correcto)
                    {
                        ViewBag.Correcto4 = "¡CORRECTO!";
                        ViewBag.Incorrecto4 = "";
                    }
                    else {
                        ViewBag.Correcto4 = "";
                        ViewBag.Incorrecto4 = "INCORRECTO :(";
                    }
                    break;
                case 5:
                    if (correcto)
                    {
                        ViewBag.Correcto5 = "¡CORRECTO!";
                        ViewBag.Incorrecto5 = "";
                    }
                    else {
                        ViewBag.Correcto5 = "";
                        ViewBag.Incorrecto5 = "INCORRECTO :(";
                    }
                    break;
            }
            return View("Habitacion" + Escape.estadoJuego);
        }

        [HttpPost]
        public IActionResult hab3(int pregunta, string incognita)
        {
            bool correcto = Escape.resolver4Fotos(pregunta, incognita);
            switch (pregunta)
            {
                case 0:
                    if (correcto)
                    {
                        ViewBag.Correcto0 = "¡CORRECTO!";
                        ViewBag.Incorrecto0 = "";
                    }
                    else {
                        ViewBag.Correcto0 = "";
                        ViewBag.Incorrecto0 = "INCORRECTO :(";
                    } 
                    break;
                case 1:
                    if (correcto)
                    {
                        ViewBag.Correcto1 = "¡CORRECTO!";
                        ViewBag.Incorrecto1 = "";
                    }
                    else {
                        ViewBag.Correcto1 = "";
                        ViewBag.Incorrecto1 = "INCORRECTO :(";
                    }
                    break;
                case 2:
                    if (correcto)
                    {
                        ViewBag.Correcto2 = "¡CORRECTO!";
                        ViewBag.Incorrecto2 = "";
                    }
                    else {
                        ViewBag.Correcto2 = "";
                        ViewBag.Incorrecto2 = "INCORRECTO :(";
                    }
                    break;
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
