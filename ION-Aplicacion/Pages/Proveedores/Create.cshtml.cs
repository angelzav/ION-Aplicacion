using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ION_Aplicacion.Data;
using ION_Aplicacion.Models;

namespace ION_Aplicacion.Pages.Proveedores
{
    public class CreateModel : PageModel
    {
        private readonly ION_Aplicacion.Data.ION_AplicacionContext _context;

        public CreateModel(ION_Aplicacion.Data.ION_AplicacionContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Proveedor Proveedor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Proveedor.Add(Proveedor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
