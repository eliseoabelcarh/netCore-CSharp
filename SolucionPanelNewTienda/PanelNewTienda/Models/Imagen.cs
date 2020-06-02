using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PanelNewTienda.Models
{
    public class Imagen
    {

        [Key]
        public int IdImagen { get; set; }
        public string TituloImagen { get; set; }
        public byte[] ImageData { get; set; }

        public int IdProducto { get; set; }



    }
}
