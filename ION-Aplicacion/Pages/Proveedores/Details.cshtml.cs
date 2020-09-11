using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ION_Aplicacion.Data;
using ION_Aplicacion.Models;

namespace ION_Aplicacion.Pages.Proveedores
{
    public class DetailsModel : PageModel
    {
        private readonly ION_Aplicacion.Data.ION_AplicacionContext _context;

        public DetailsModel(ION_Aplicacion.Data.ION_AplicacionContext context)
        {
            _context = context;
        }

        public Proveedor Proveedor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Proveedor = await _context.Proveedor.FirstOrDefaultAsync(m => m.ID == id);

            if (Proveedor == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
