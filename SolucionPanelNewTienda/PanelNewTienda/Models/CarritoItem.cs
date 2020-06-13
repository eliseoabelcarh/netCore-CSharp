using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PanelNewTienda.Models
{
    public class CarritoItem
    {
        [Key]
        public int IdCarritoItem { get; set; }

        public int IdProducto { get; set; }
        public virtual Producto ProductoCarritoItem { get; set; }
        public int Cantidad { get; set; }
        public double TotalCarritoItem { get; set; }

    }
}
