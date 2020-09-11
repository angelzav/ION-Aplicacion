using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ION_Aplicacion.Models.ViewModels
{
    public class VentaIndexData
    {
        public IEnumerable<Venta> Ventas { get; set; }
        public IEnumerable<VentaDetalle> VentaDetalles { get; set; }
    }
}
