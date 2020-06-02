using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PanelNewTienda.Models
{
    public class Producto
    {

        [Key]
        public int IdProducto { get; set; }

        [Required]
        [StringLength(150)]
        [DisplayName("Nombre de Producto")]
        public string NombreProducto { get; set; }

        [Required]
        [StringLength(2000)]
        [DisplayName("Descripción")]
        public string DescripcionProducto { get; set; }

        public Boolean Publicado { get; set; }
       
        public byte[] Imagen1 { get; set; }
       

        [Required]
        [DisplayName("Precio")]
        public double PrecioProducto { get; set; }


        public int IdTienda { get; set; }



    }
}
