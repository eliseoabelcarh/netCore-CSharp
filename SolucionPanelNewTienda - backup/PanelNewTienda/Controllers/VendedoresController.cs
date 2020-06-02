using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PanelNewTienda.Data;
using PanelNewTienda.Models;
using PanelNewTienda.Services;

namespace PanelNewTienda.Controllers
{

    [Authorize]
    public class VendedoresController : Controller
    {


        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ApplicationDbContext _context;
        private readonly NewTiendaService _app;


        public VendedoresController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor, NewTiendaService app)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _app = app;

        }

        public async Task<IActionResult> Index()
        {

            //PROBANDO SERVICIO PROPIO CREADO
            var tiendaDesdeServicio = await _app.obtenerTiendaVendedorActual();
            ViewBag.NroTienda = tiendaDesdeServicio.IdTienda;
            //fin de prueba


            var tienda = await obtenerTiendaVendedorActual();
            ViewBag.CantProdPublicados = await ObtenerCantidadProductosPublicadosAsync();
            var prods = await ObtenerProductosDeTiendaActualAsync();
            ViewBag.CantProdPublicadosTotal = prods.Count();

            return View(tienda);
        }

        public async Task<IActionResult> EditarNombreTienda(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tienda = await obtenerTiendaVendedorActual();
            if (tienda == null)
            {
                return NotFound();
            }
            ViewBag.CantProdPublicados = await ObtenerCantidadProductosPublicadosAsync();
            var prods = await ObtenerProductosDeTiendaActualAsync();
            ViewBag.CantProdPublicadosTotal = prods.Count();
            return View(tienda);
        }
        [HttpPost]
        public async Task<IActionResult> EditarNombreTienda(int id, [Bind("IdTienda,NombreTienda,Publicada")] Tienda tienda)
        {
            if (id != tienda.IdTienda)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tienda);
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Vendedores");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TiendaExiste(tienda.IdTienda))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(tienda);
        }


        public async Task<IActionResult> EditarRedesSociales(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (await puedeEditarRedSocialAsync(id) == false)
            {
                return NotFound();
            }
            var redSocial = await _context.RedesSociales.FindAsync(id);
            if (redSocial == null)
            {
                return NotFound();
            }
          
            return View(redSocial);
        }
        [HttpPost]
        public async Task<IActionResult> EditarRedesSociales(int id, [Bind("IdRedSocial,Email,Whatsapp,Twitter,Facebook,Instagram")] RedSocial redSocial)
        {
            if (id != redSocial.IdRedSocial)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(redSocial);
                    
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Index", "Vendedores");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TiendaExiste(redSocial.IdRedSocial))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(redSocial);
        }

        public async Task<IActionResult> Productos()
        {
            var tienda = await obtenerTiendaVendedorActual();
            var productos = _context.Productos.Where(p => p.IdTienda == tienda.IdTienda);
            
           
           
            return View(productos);
        }

        private async Task<Tienda> obtenerTiendaVendedorActual()
        {
            try
            {
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var vendedor = await _context.Vendedores.Include("Tienda").FirstOrDefaultAsync(v => v.Id == userId);
                var tienda = await _context.Tiendas.Include("RedSocial").Include("Productos").FirstOrDefaultAsync(t => t.IdTienda == vendedor.IdTienda);
                return tienda;
            }
            catch (DbUpdateConcurrencyException)
            {
                return null;
            }

        }


        private bool TiendaExiste(int id)
        {
            return _context.Tiendas.Any(e => e.IdTienda == id);
        }

        private async Task<int> ObtenerCantidadProductosPublicadosAsync() 
        {
            int cant = 0;
            var productos = await ObtenerProductosDeTiendaActualAsync();
            if (productos != null) 
            {
                foreach (var prod in productos) 
                {
                    if(prod.Publicado == true)
                    {
                        cant += 1;
                    }
                }
            }

            return cant;
        }
        private async Task<List<Producto>> ObtenerProductosDeTiendaActualAsync()
        {

            var tienda = await obtenerTiendaVendedorActual();
            var productos = _context.Productos.Where(p => p.IdTienda == tienda.IdTienda);

            return productos.ToList();
        }

        private async Task<bool> puedeEditarRedSocialAsync(int? idRedSocialAEditar)
        {
            var resultado = false;
            if (idRedSocialAEditar != null)
            {
                var tiendaDeUsuario = await obtenerTiendaVendedorActual();
                var redSocialAEditar = await _context.RedesSociales.FindAsync(idRedSocialAEditar);

                if (redSocialAEditar.IdRedSocial == tiendaDeUsuario.RedSocial.IdRedSocial)
                {
                    resultado = true;
                }
            }
            return resultado;
        }


    }
}