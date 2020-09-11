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
    public class DetailsModel : PageModel
    {
        private readonly ION_Aplicacion.Data.ION_AplicacionContext _context;

        public DetailsModel(ION_Aplicacion.Data.ION_AplicacionContext context)
        {
            _context = context;
        }

        public Producto Producto { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Producto = await _context.Producto
                .Include(p => p.Proveedor).FirstOrDefaultAsync(m => m.ID == id);

            if (Producto == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
