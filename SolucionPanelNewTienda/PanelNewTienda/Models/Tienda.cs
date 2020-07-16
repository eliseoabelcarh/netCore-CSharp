using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PanelNewTienda.Models
{
    public class Tienda
    {
        [Key]
        public int IdTienda { get; set; }



        
        [Required(ErrorMessage = "Debes Completar un nombre")]
        [StringLength(100)]
        [DisplayName("Nombre de Tienda")]
        public string NombreTienda { get; set; }



        [DisplayName("Publicar Tienda")]
        public Boolean Publicada { get; set; }


        public int IdRedSocial { get; set; }
        public virtual RedSocial RedSocial { get; set; }


        public virtual List<Producto> Productos { get; set; }

    }
}

