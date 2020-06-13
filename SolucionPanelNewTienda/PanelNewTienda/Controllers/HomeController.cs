﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
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

        public async Task<IActionResult> IndexAsync()
        {

            var product = await _app.ObtenerProductoPorId(2);

            HttpContext.Session.SetString(SessionName, JsonConvert.SerializeObject(product));
            
            var listaTiendas = _app.ObtenerListaTiendasPublicadas();
            var listaRedesSociales = _app.ObtenerTodasLasRedesSociales();

            return View(listaTiendas);
        }

        public IActionResult VerProductosDeTienda(int id)
        {
           
            var listaProductosDeTienda = _app.ObtenerProductoPorIdDeTienda(id);
            ViewBag.NombreTienda = _app.ObtenerNombreDeTienda(id);
            return View(listaProductosDeTienda);

        }


        [HttpGet]
        public IActionResult AgregarACarrito(CarritoItem carritoItem)
        {
            var modelo = carritoItem;
            return View(modelo);
        }

        [HttpPost]
        public async Task<IActionResult> AgregarACarritoAsync( CarritoItem carritoItem)
        {
            var producto = await _app.ObtenerProductoPorId(carritoItem.IdProducto);
            var cantidad = carritoItem.Cantidad;
            var l = 1+1;
            return null;
            //return RedirectToAction("EditarProducto", "Productos", new { @id = prodAux.IdProducto });
        }

        public IActionResult Privacy()
        {
            try
            {
                var getSessionString = HttpContext.Session.GetString(SessionName);
                var producto = JsonConvert.DeserializeObject<Producto>(getSessionString);
                return View(producto);
            }
            catch (Exception)
            {

                return View();
            }
           
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
