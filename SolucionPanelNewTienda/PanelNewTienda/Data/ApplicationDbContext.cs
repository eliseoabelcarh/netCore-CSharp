using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PanelNewTienda.Models;

namespace PanelNewTienda.Data
{
    public class ApplicationDbContext : IdentityDbContext<Vendedor>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public virtual DbSet<Vendedor> Vendedores { get; set; }
        public virtual DbSet<Tienda> Tiendas { get; set; }
        public virtual DbSet<RedSocial> RedesSociales { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Imagen> Imagenes { get; set; }
       

        






    }
}
