using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ION_Aplicacion.Data;
using ION_Aplicacion.Models;

namespace ION_Aplicacion.Pages.Ventas
{
    public class EditModel : PageModel
    {
        private readonly ION_Aplicacion.Data.ION_AplicacionContext _context;

        public EditModel(ION_Aplicacion.Data.ION_AplicacionContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Venta Venta { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Venta = await _context.Venta
                .Include(v => v.Cliente).FirstOrDefaultAsync(m => m.ID == id);

            if (Venta == null)
            {
                return NotFound();
            }
           ViewData["ClienteID"] = new SelectList(_context.Cliente, "ID", "nombre");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Venta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VentaExists(Venta.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VentaExists(int id)
        {
            return _context.Venta.Any(e => e.ID == id);
        }
    }
}
