using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PanelNewTienda.Models
{
    public class Carrito
    {
        public int IdCarrito { get; set; }
        public virtual List<CarritoItem> Items { get; set; }

        public double TotalCarrito { get; set; }

    }
}
