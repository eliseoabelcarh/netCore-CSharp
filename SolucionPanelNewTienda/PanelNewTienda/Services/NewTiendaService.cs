
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using PanelNewTienda.Data;
using PanelNewTienda.Models;
using System;
using System.Collections.Generic;
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

        public async Task<Tienda> obtenerTiendaVendedorActual()
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

    }
}
