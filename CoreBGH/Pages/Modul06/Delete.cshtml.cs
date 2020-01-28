using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CoreBGH.data;

namespace CoreBGH.Pages.Modul06
{
    public class DeleteModel : PageModel
    {
        private readonly CoreBGH.data.AufgabenContext _context;

        public DeleteModel(CoreBGH.data.AufgabenContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Aufgaben Aufgaben { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aufgaben = await _context.Aufgaben.FirstOrDefaultAsync(m => m.ID == id);

            if (Aufgaben == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Aufgaben = await _context.Aufgaben.FindAsync(id);

            if (Aufgaben != null)
            {
                _context.Aufgaben.Remove(Aufgaben);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
