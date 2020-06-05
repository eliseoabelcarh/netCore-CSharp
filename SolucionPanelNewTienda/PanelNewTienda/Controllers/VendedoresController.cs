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

            var tienda = await _app.ObtenerTiendaVendedorActual();
            ViewBag.CantProdPublicados = await _app.ObtenerCantidadProductosPublicadosAsync();
            var prods = await _app.ObtenerProductosDeTiendaActualAsync();
            ViewBag.CantProdPublicadosTotal = prods.Count();

            return View(tienda);
        }

        public async Task<IActionResult> EditarNombreTienda(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tienda = await _app.ObtenerTiendaVendedorActual();
            if (tienda == null)
            {
                return NotFound();
            }
            ViewBag.CantProdPublicados = await _app.ObtenerCantidadProductosPublicadosAsync();
            var prods = await _app.ObtenerProductosDeTiendaActualAsync();
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
                    if (!(_app.TiendaExiste(tienda.IdTienda)))
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
            if (await _app.PuedeEditarRedSocialAsync(id) == false)
            {
                return NotFound();
            }
            var redSocial = await _app.ObtenerRedSocialPorId(id);
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
                    if (!(_app.TiendaExiste(redSocial.IdRedSocial)))
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
            
            var productos = await _app.ObtenerProductosDeTiendaActualAsync();
            
           
           
            return View(productos);
        }

        


    }
}