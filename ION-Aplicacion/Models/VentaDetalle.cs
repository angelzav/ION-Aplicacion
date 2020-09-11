using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ION_Aplicacion.Models
{
    public class VentaDetalle
    {
        public int ID { get; set; }

        [Required]
        public int CantidadProducto { get; set; }

        [Required]
        public float Precio { get; set; }


        [Required]
        public int ProductoID { get; set; }

        [Required]
        public int VentaID { get; set; }


        public virtual Producto Producto { get; set; }
        public virtual Venta Venta { get; set; }
    }
}
