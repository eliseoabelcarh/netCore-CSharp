﻿
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;
using PanelNewTienda.Data;
using PanelNewTienda.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PanelNewTienda.Services
{
    public class NewTiendaService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ApplicationDbContext _context;
        public NewTiendaService(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public List<Tienda> ObtenerListaTiendasPublicadas() 
        {
            try
            {
                var listaTiendas = _context.Tiendas.Where(t => t.Publicada == true);
                return listaTiendas.ToList();
            }
            catch (Exception)
            {
                return new List<Tienda>();
            }
        }

        public String ObtenerNombreDeTienda(int idTienda)
        {
            var tienda = _context.Tiendas.Find(idTienda);
            return tienda.NombreTienda;
        }
        public List<Producto> ObtenerTodosLosProductosPublicados()
        {
            var listaProductos = _context.Productos.Where(p => p.Publicado == true);
            return listaProductos.ToList();
        }

        public List<Producto> ObtenerProductoPorIdDeTienda(int id)
        {
            var productos = _context.Productos.Where(p => p.IdTienda == id && p.Publicado == true);
            return productos.ToList();
        }

        public async Task<Tienda> ObtenerTiendaPorIdAsync(int id)
        {
            var tienda = await _context.Tiendas.FirstOrDefaultAsync(t => t.IdTienda == id);
            var redes = ObtenerTodasLasRedesSociales();
            return tienda;
        }

        public List<RedSocial> ObtenerTodasLasRedesSociales()
        {
            var listaRedes = _context.RedesSociales;
            return listaRedes.ToList();
        }

        public async Task<Tienda> ObtenerTiendaVendedorActual()
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



        public bool TiendaExiste(int id)
        {
            return _context.Tiendas.Any(e => e.IdTienda == id);
        }

        public async Task<int> ObtenerCantidadProductosPublicadosAsync()
        {
            int cant = 0;
            var productos = await ObtenerProductosDeTiendaActualAsync();
            if (productos != null)
            {
                foreach (var prod in productos)
                {
                    if (prod.Publicado == true)
                    {
                        cant += 1;
                    }
                }
            }

            return cant;
        }
        public async Task<List<Producto>> ObtenerProductosDeTiendaActualAsync()
        {

            var tienda = await ObtenerTiendaVendedorActual();
            var productos = _context.Productos.Where(p => p.IdTienda == tienda.IdTienda);

            return productos.ToList();
        }

        internal bool ExisteIdProductoEnLista(List<CarritoItem> listaDeSesion, int idProducto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> AgregarProductoNuevoABD(Producto producto)
        {
          
            try
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
           
        }

        public async Task<bool> BorrarProductoEnDBAsync(int id) 
        {
            try
            {
                //HABRIa QUE BORRAR IMAGENES TMB
                var producto = await _context.Productos.FindAsync(id);
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {

                return false;
            }

         
           
        }

        internal async Task<List<CarritoItem>> ActualizarPreciosAsync(List<CarritoItem> lista)
        {
            
            foreach (var item in lista) 
            {
                var idProducto = item.Producto.IdProducto;
                var precioProducto = await ObtenerPrecioDeProductoPorIdAsync(idProducto);
                var cantidad = item.Cantidad;
                item.Producto.NombreProducto = await ObtenerNombreDeProductoPorIdAsync(idProducto);
                item.PrecioCarritoItem = cantidad*precioProducto;
            }
            return lista;

        }

        internal List<int> ObtenerListaConLosNrosTiendaExistentesEnCarrito(List<CarritoItem> listaItems)
        {
            var listaConNrosTienda = new List<int>();

            foreach(var item in listaItems)
            {
                var nroTienda = item.IdTienda;
                if(!listaConNrosTienda.Contains(nroTienda))
                {
                    listaConNrosTienda.Add(nroTienda);
                }
            }
            return listaConNrosTienda;
        }

        private async Task<string> ObtenerNombreDeProductoPorIdAsync(int idProducto)
        {
            var producto = await ObtenerProductoPorId(idProducto);
            return producto.NombreProducto;
        }

        internal async Task<double> ObtenerPrecioDeProductoPorIdAsync(int? id)
        {
            var producto = await ObtenerProductoPorId(id);
            var precioProducto = producto.PrecioProducto;
            return precioProducto;

        }
        internal async Task<Producto> ObtenerProductoPorId(int? id)
        {
            var producto = await _context.Productos.FindAsync(id);
            return producto;
        }
        internal async Task<RedSocial> ObtenerRedSocialPorId(int? id)
        {
            var redSocial = await _context.RedesSociales.FindAsync(id);
            return redSocial;
        }

        public async Task<Producto> ObtenerProductoPrimeroOrDefault(int? id) 
        {
            var producto = await _context.Productos.FirstOrDefaultAsync(p => p.IdProducto == id);
            return producto;
        }

        public async Task<bool> PuedeEditarRedSocialAsync(int? idRedSocialAEditar)
        {
            var resultado = false;
            if (idRedSocialAEditar != null)
            {
                var tiendaDeUsuario = await ObtenerTiendaVendedorActual();
                var redSocialAEditar = await _context.RedesSociales.FindAsync(idRedSocialAEditar);

                if (redSocialAEditar.IdRedSocial == tiendaDeUsuario.RedSocial.IdRedSocial)
                {
                    resultado = true;
                }
            }
            return resultado;
        }

        internal async Task<RedSocial> ObtenerRedSocialPorIdDeTiendaAsync(int idTienda)
        {
            var tienda = await ObtenerTiendaPorIdAsync(idTienda);
            var redSocial = _context.RedesSociales.Where(r => r.Whatsapp != "");
            var LaRedSocial = tienda.RedSocial;
            
            return LaRedSocial;
        }

        internal List<CarritoItem> ObtenerlistaDeTiendaEspecifica(List<CarritoItem> lista, int id)
        {
            List<CarritoItem> listaNueva = new List<CarritoItem>();
           foreach(var item in lista)
            {
                if(item.IdTienda == id)
                {
                    listaNueva.Add(item);
                }
            }
            return listaNueva;
        }

        public async Task<bool> PuedeEditarProductoAsync(int? idProductoAEditar)
        {
            var resultado = false;
            if (idProductoAEditar != null)
            {
                var tiendaDeUsuario = await ObtenerTiendaVendedorActual();
                if (tiendaDeUsuario == null)
                {
                    resultado = false;
                }
                var productoAEditar = await ObtenerProductoPorId(idProductoAEditar);

                if (productoAEditar.IdTienda == tiendaDeUsuario.IdTienda)
                {
                    resultado = true;
                }
            }
            return resultado;
        }



        public bool ProductoExists(int id)
        {
            return _context.Productos.Any(e => e.IdProducto == id);
        }
      



    }
}
