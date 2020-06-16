using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PanelNewTienda.Models
{
    public class CarritoItem
    {

        [DisplayName("Nro de Tienda")]
        public int IdTienda { get; set; }


        [DisplayName("Nombre de Producto")]
        public virtual Producto Producto {get;set;}

        public int Cantidad { get; set; }


        [DisplayName("SubTotal")]
        public double PrecioCarritoItem { get; set; }

        
    }
}
