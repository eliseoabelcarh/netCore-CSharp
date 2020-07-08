﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PanelNewTienda.Models;
using PanelNewTienda.Services;

namespace PanelNewTienda.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NewTiendaService _app;
        const string SessionName = "Carrito";

        public HomeController(ILogger<HomeController> logger, NewTiendaService app)
        {
            _logger = logger;
            _app = app;
        }


        public void GuardarLaListaEnLaSesion(List<CarritoItem> items)
        {

            HttpContext.Session.SetString(SessionName, JsonConvert.SerializeObject(items));
        }

        public List<CarritoItem> ObtenerListaConItemsDeSesion()
        {
            try
            {
                var listaEnString = HttpContext.Session.GetString(SessionName);

                if (listaEnString == null)
                {
                    var listaNueva = new List<CarritoItem>();
                    GuardarLaListaEnLaSesion(listaNueva);
                    var lista = HttpContext.Session.GetString(SessionName);
                    var listaDeItemsDeCarrito1 = JsonConvert.DeserializeObject<List<CarritoItem>>(lista);

                    return listaDeItemsDeCarrito1;
                }

                var listaDeItemsDeCarrito = JsonConvert.DeserializeObject<List<CarritoItem>>(listaEnString);
                return listaDeItemsDeCarrito;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public bool GuardarUnItemEnSesionCarrito(CarritoItem item)
        {
            bool resultado = false;
            if (item != null)
            {
                var listaDeItemsDeCarrito = ObtenerListaConItemsDeSesion();
                if (listaDeItemsDeCarrito != null)
                {
                    listaDeItemsDeCarrito.Add(item);
                    GuardarLaListaEnLaSesion(listaDeItemsDeCarrito);
                    resultado = true;
                }
            }
            return resultado;
        }

        public IActionResult Index()
        {

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
        public IActionResult AgregarACarrito(CarritoItemAux carritoItemAux)
        {
            var modelo = carritoItemAux;
            return View(modelo);
        }

        [HttpPost]
        public async Task<IActionResult> AgregarACarritoAsync(CarritoItemAux carritoItemAux)
        {
            var producto = await _app.ObtenerProductoPorId(carritoItemAux.IdProducto);
            var cantidad = carritoItemAux.Cantidad;

            var listaDeSesion = ObtenerListaConItemsDeSesion();

            var i = 0;
            bool encontrado = false;
            while (!encontrado && i < listaDeSesion.Count())
            {
                if (listaDeSesion[i].Producto.IdProducto == producto.IdProducto)
                {
                    encontrado = true;
                    listaDeSesion[i].Cantidad += carritoItemAux.Cantidad;
                }
                i++;
            }

            if (encontrado == false)
            {
                var itemDeCarrito = new CarritoItem { IdTienda = producto.IdTienda, Producto = producto, Cantidad = cantidad, PrecioCarritoItem = cantidad * producto.PrecioProducto };
                var agregadoExitosamente = GuardarUnItemEnSesionCarrito(itemDeCarrito);
                if (agregadoExitosamente)
                {
                    return RedirectToAction("CarritoDeCompras", "Home");
                }
            }
            var listaActualizada = await _app.ActualizarPreciosAsync(listaDeSesion);
            GuardarLaListaEnLaSesion(listaActualizada);
            return RedirectToAction("CarritoDeCompras", "Home");
            //return RedirectToAction("VerProductosDeTienda", "Home", new { @id = producto.IdTienda });
        }

        [HttpGet]
        public IActionResult CarritoDeCompras()
        {

            var listaDeProductosEnElCarrito = ObtenerListaConItemsDeSesion();
            ViewBag.listaNrosTiendas = _app.ObtenerListaConLosNrosTiendaExistentesEnCarrito(listaDeProductosEnElCarrito);
            return View(listaDeProductosEnElCarrito);
        }


        [HttpPost]
        public async Task<IActionResult> ActualizarCarritoDeComprasAsync(List<CarritoItem> listaDeItemsDeCarrito)
        {
            var listaActualizada = await _app.ActualizarPreciosAsync(listaDeItemsDeCarrito);
            GuardarLaListaEnLaSesion(listaActualizada);
            return RedirectToAction("CarritoDeCompras", "Home");
        }


        public IActionResult EliminarProductoDeMiCarrito(int? id)
        {
            var i = 0;
            bool encontrado = false;
            var listaDeSesion = ObtenerListaConItemsDeSesion();
            while (!encontrado && i < listaDeSesion.Count())
            {
                if (listaDeSesion[i].Producto.IdProducto == id)
                {
                    listaDeSesion.RemoveAt(i);
                    encontrado = true;
                }
                i++;
            }
            GuardarLaListaEnLaSesion(listaDeSesion);
            return RedirectToAction("CarritoDeCompras", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Checkout(List<CarritoItem> listaDeItemsDeCarrito)
        {

            var listaActualizada = await _app.ActualizarPreciosAsync(listaDeItemsDeCarrito);
            GuardarLaListaEnLaSesion(listaActualizada);
            var listaDeProductosEnElCarrito = ObtenerListaConItemsDeSesion();
            ViewBag.listaNrosTiendas = _app.ObtenerListaConLosNrosTiendaExistentesEnCarrito(listaDeProductosEnElCarrito);
            return View(listaDeProductosEnElCarrito);
        }



        public async Task<IActionResult> PedirPorWhatsappAsync(int id)
        {
            var urlConPedido = await ObtenerUrlConPedidoDeTiendaAsync(id);

            return Redirect(urlConPedido);
        }

        private async Task<string> ObtenerUrlConPedidoDeTiendaAsync(int id)
        {
            var urlFinal = "https://api.whatsapp.com/send?phone=54";
            var miweb = "abel.com";
            var saltoLinea = "%0A";
            var espacio = "%20";
            var lineas = "-----------";
            var listaConItemsTotal = ObtenerListaConItemsDeSesion();
            var listaDeTiendaEspecifica = _app.ObtenerlistaDeTiendaEspecifica(listaConItemsTotal,id);
            var tienda = await _app.ObtenerTiendaPorIdAsync(id);

            var nroWhatsapp = tienda.RedSocial.Whatsapp;
            urlFinal += (nroWhatsapp + "&text=%20");
            urlFinal += ("*PEDIDO DESDE " + miweb + "*" + espacio + saltoLinea);
            double total = 0;
            foreach(var item in listaDeTiendaEspecifica)
            {
                var nombreProducto = item.Producto.NombreProducto;
                var cantidad = item.Cantidad;
                var subtotal = item.PrecioCarritoItem;
                total += subtotal;

                urlFinal += "*Producto:*" + espacio + nombreProducto + saltoLinea + "*Cantidad:*" + espacio + cantidad + saltoLinea + "*Subtotal:*" + espacio + subtotal + saltoLinea + lineas + saltoLinea;
            }
            var precioTotal = "*Total a Pagar:*"+espacio + "*" +total+ "*";
            urlFinal += precioTotal;

            return urlFinal;
        }

        public IActionResult Privacy()
        {

                return View();
       
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        [HttpGet]
        public async Task<ActionResult<string>> GetKitty()
        {
            
            string url = "https://api.cryptokitties.co/kitties/2"; 
            using (HttpClient client = new HttpClient())
            {
               var respuesta =  await client.GetStringAsync(url) ;
               dynamic json = JObject.Parse(respuesta);
               ViewBag.image = json.image_url;
            }

            return View();
        }
            

        
        public IActionResult ProductosAPI() 
        {
            var listaProductos = _app.ObtenerTodosLosProductosPublicados();
            return Json(listaProductos);
            
        }

        public async Task<IActionResult> GetProductosAPI()
        {
        
            string url = "http://le-charlotte.com/home/productosAPI";
            using (HttpClient client = new HttpClient())
            {
                var respuesta = await client.GetStringAsync(url);
                var listaProductos = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
                return View(listaProductos);
            }

            
        }




    }
}
