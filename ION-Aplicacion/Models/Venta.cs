using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ION_Aplicacion.Models
{
    public class Venta
    {
        
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required]
        public int Descuento { get; set; }
        public float Total { get; set; }

        [Required]
        public int ClienteID { get; set; }

        
        public virtual Cliente Cliente { get; set; }
        public virtual ICollection<VentaDetalle> VentaDetalles { get; set; }
    }
}
