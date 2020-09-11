using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ION_Aplicacion.Data;
using ION_Aplicacion.Models;


namespace ION_Aplicacion.Pages.Ventas
{
    public class IndexModel : PageModel
    {
        private readonly ION_Aplicacion.Data.ION_AplicacionContext _context;

        public IndexModel(ION_Aplicacion.Data.ION_AplicacionContext context)
        {
            _context = context;
        }

        public IList<Venta> Venta { get;set; }

        public async Task OnGetAsync()
        {
            Venta = await _context.Venta
                .Include(v => v.Cliente)
                .Include(c => c.VentaDetalles)
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
