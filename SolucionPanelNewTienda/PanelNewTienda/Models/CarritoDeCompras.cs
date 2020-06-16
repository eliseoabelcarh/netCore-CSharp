using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PanelNewTienda.Models
{
    public class CarritoDeCompras
    {

      

        public int IdCarritoDeCompras { get; set; }

        public virtual List<CarritoItem> Items { get; set; }


    }
}
