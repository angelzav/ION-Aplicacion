using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ION_Aplicacion.Data;
using ION_Aplicacion.Models;

namespace ION_Aplicacion.Pages.Productos
{
    public class IndexModel : PageModel
    {
        private readonly ION_Aplicacion.Data.ION_AplicacionContext _context;

        public IndexModel(ION_Aplicacion.Data.ION_AplicacionContext context)
        {
            _context = context;
        }

        public IList<Producto> Producto { get;set; }

        public async Task OnGetAsync()
        {
            Producto = await _context.Producto
                .Include(p => p.Proveedor).ToListAsync();
        }
    }
}
