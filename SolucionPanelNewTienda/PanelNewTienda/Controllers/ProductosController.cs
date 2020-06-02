using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;
using Microsoft.EntityFrameworkCore;
using PanelNewTienda.Data;
using PanelNewTienda.Data.Migrations;
using PanelNewTienda.Models;

namespace PanelNewTienda.Controllers
{

    [Authorize]
    public class ProductosController : Controller
    {



        private readonly IHttpContextAccessor _httpContextAccessor;
       
        private readonly ApplicationDbContext _context;

        public ProductosController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            
        }

        [HttpGet]
        public async Task<IActionResult> CrearProductoAsync()
        {
            var tiendaActual = await ObtenerTiendaVendedorActual();
            if(tiendaActual != null)
            {
                var producto = new Producto() { IdTienda = tiendaActual.IdTienda };

                return View(producto);
            }
            return RedirectToAction("Index", "Vendedores");

        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CrearProducto([Bind("IdProducto,NombreProducto,DescripcionProducto,PrecioProducto,IdTienda,Imagen1")] Producto producto)
        {
            if (ModelState.IsValid)
            {

                foreach (var file in Request.Form.Files)
                {
                    //CHEKAR SI file is IMAGE 

                    MemoryStream ms = new MemoryStream();
                    file.CopyTo(ms);
                    producto.Imagen1 = ms.ToArray();

                    ms.Close();
                    ms.Dispose();

                }



                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction("Productos", "Vendedores");
            }
            return View(producto);
        }

    
        // GET: Productos/Edit/5
        public async Task<IActionResult> EditarProducto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (await puedeEditarProductoAsync(id) == false) 
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            //var imagenesDeProducto = _context.Imagenes.Where(i => i.IdProducto == producto.IdProducto);
            //producto.Imagenes = imagenesDeProducto.ToList();
            //ViewBag.Images = imagenesDeProducto;


            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }




        // POST: Productos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditarProducto(int id, [Bind("IdProducto,NombreProducto,DescripcionProducto,Publicado,PrecioProducto,IdTienda")] Producto producto)
        {
            if (id != producto.IdProducto)
            {
                return NotFound();
            }

           

            if (ModelState.IsValid)
            {
                try
                {
                    

                    _context.Update(producto);
                    _context.Entry(producto).Property(x => x.Imagen1).IsModified = false;
                    await _context.SaveChangesAsync();

                    return RedirectToAction("Productos","Vendedores");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExists(producto.IdProducto))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            return View(producto);
        }
        [HttpGet]
        public IActionResult CargarImagen(ProdAux prod)
        {
            var prodAux = prod;
            return View(prodAux);
        }

        [HttpPost]
        public async Task<IActionResult> CargarImagen(Producto prodAux) 
        {
            if (Request.Form.Files.Count() != 0)
            {
                foreach (var file in Request.Form.Files)
                {

                    //CHEKAR SI file is IMAGE 

                    MemoryStream ms = new MemoryStream();
                    file.CopyTo(ms);
                    var producto = _context.Productos.Find(prodAux.IdProducto);
                    producto.Imagen1 = ms.ToArray();
                    await _context.SaveChangesAsync();
                    ms.Close();
                    ms.Dispose();
                    return RedirectToAction("EditarProducto", "Productos", new { @id = prodAux.IdProducto });
                }
            }
            
            return RedirectToAction("EditarProducto", "Productos", new { @id = prodAux.IdProducto });
        }






        public async Task<IActionResult> EliminarProducto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (await puedeEditarProductoAsync(id) == false)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: Productoes/Delete/5
        [HttpPost, ActionName("EliminarProducto")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //HABRI QUE BORRAR IMAGENES TMB
            var producto = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction("Productos","Vendedores");
        }




        private async Task<bool> puedeEditarProductoAsync(int? idProductoAEditar)
        {
            var resultado = false;
            if(idProductoAEditar != null)
            {
                var tiendaDeUsuario = await ObtenerTiendaVendedorActual();
                if (tiendaDeUsuario == null) 
                {
                    resultado = false;
                }
                var productoAEditar = await _context.Productos.FindAsync(idProductoAEditar);

                if (productoAEditar.IdTienda == tiendaDeUsuario.IdTienda)
                {
                    resultado = true;
                }
            }
            return resultado;
        }
      


        private bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.IdProducto == id);
        }
        private async Task<Tienda> ObtenerTiendaVendedorActual()
        {

            try
            {
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var vendedor = await _context.Vendedores.Include("Tienda").FirstOrDefaultAsync(v => v.Id == userId);
                var tienda = await _context.Tiendas.Include("RedSocial").Include("Productos").FirstOrDefaultAsync(t => t.IdTienda == vendedor.IdTienda);
                return tienda;
            }
            catch(DbUpdateConcurrencyException)
            {
                return null;
            }

            
        }




    }
}