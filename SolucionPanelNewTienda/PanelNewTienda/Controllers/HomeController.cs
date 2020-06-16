using System;
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
        const string SessionName = "Carrito";

        public HomeController(ILogger<HomeController> logger , NewTiendaService app)
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

                if(listaEnString == null)
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

            var itemDeCarrito = new CarritoItem { IdTienda=producto.IdTienda,Producto=producto,Cantidad=cantidad,PrecioCarritoItem=cantidad*producto.PrecioProducto };

            var agregadoExitosamente = GuardarUnItemEnSesionCarrito(itemDeCarrito);

            if(agregadoExitosamente)
            {
                return RedirectToAction("CarritoDeCompras", "Home");
            }
            
            return RedirectToAction("VerProductosDeTienda", "Home", new { @id = producto.IdTienda });
        }

        [HttpGet]
        public IActionResult CarritoDeCompras()
        {

            var listaDeProductosEnElCarrito = ObtenerListaConItemsDeSesion();
            return View(listaDeProductosEnElCarrito);
        }

        [HttpGet]
        public IActionResult MostrarPopup(CarritoItemAux carritoItemAux)
        {
            var resultadoDeAgregadoACarrito = AgregarACarritoAsync(carritoItemAux);

            var popupModel = new PopupModel { Mensaje = "agregadoExitoso" };
            
            return View(popupModel);
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
    }
}
