using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PanelNewTienda.Models
{
    public class Vendedor : IdentityUser
    {
        public int IdTienda { get; set; }
        public virtual Tienda Tienda { get; set; }
    }
}
