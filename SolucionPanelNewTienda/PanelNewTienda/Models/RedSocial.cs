using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PanelNewTienda.Models
{
    public class RedSocial
    {
        [Key]
        public int IdRedSocial { get; set; }

        [StringLength(11, ErrorMessage = "Name length can't be more than 11.")]
        public string Whatsapp { get; set; }
        [StringLength(150)]
        public string Facebook { get; set; }
        [StringLength(150)]
        public string Instagram { get; set; }
        [StringLength(150)]
        public string Twitter { get; set; }
        [StringLength(150)]
        public string Email { get; set; }
    }
}
