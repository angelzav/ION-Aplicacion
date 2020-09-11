using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ION_Aplicacion.Models
{
    public class Producto
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Required]
        public float Precio { get; set; }

        [Required]
        public int Stock { get; set; }

     
        public int ProveedorID { get; set; }
        public virtual Proveedor Proveedor { get; set; }


    }
}
