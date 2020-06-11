using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PanelNewTienda.Models;
using PanelNewTienda.Services;

namespace PanelNewTienda.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NewTiendaService _app;
        const string SessionName = "_Name";

        public HomeController(ILogger<HomeController> logger , NewTiendaService app)
        {
            _logger = logger;
            _app = app;
        }

        public IActionResult Index()
        {
        
            HttpContext.Session.SetString(SessionName, "Jarvik");
            
            var listaProductos = _app.ObtenerTodosLosProductosPublicados();
            return View(listaProductos);
        }

        public IActionResult Privacy()
        {
            ViewBag.Name = HttpContext.Session.GetString(SessionName);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
