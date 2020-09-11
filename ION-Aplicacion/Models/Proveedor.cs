using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ION_Aplicacion.Models
{
    public class Proveedor
    {
        public int ID { get; set; }

        [Required]
        [StringLength(13)]
        public string RFC { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(250)]
        public string Direccion { get; set; }

        [Required]
        [StringLength(10)]
        [MinLengthAttribute(10)]
        public string Telefono { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }
    }
}
