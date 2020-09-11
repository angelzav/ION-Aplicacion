using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ION_Aplicacion.Models;

namespace ION_Aplicacion.Data
{
    public class ION_AplicacionContext : DbContext
    {
        public ION_AplicacionContext (DbContextOptions<ION_AplicacionContext> options)
            : base(options)
        {
        }

        public DbSet<ION_Aplicacion.Models.Cliente> Cliente { get; set; }

        public DbSet<ION_Aplicacion.Models.Proveedor> Proveedor { get; set; }

        public DbSet<ION_Aplicacion.Models.Producto> Producto { get; set; }

        public DbSet<ION_Aplicacion.Models.Venta> Venta { get; set; }
    }
}
