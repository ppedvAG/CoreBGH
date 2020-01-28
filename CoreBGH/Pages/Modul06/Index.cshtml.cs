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
    public class IndexModel : PageModel
    {
        private readonly CoreBGH.data.AufgabenContext _context;

        public IndexModel(CoreBGH.data.AufgabenContext context)
        {
            _context = context;
        }

        public IList<Aufgaben> Aufgaben { get;set; }

        public async Task OnGetAsync()
        {
            Aufgaben = await _context.Aufgaben.ToListAsync();
        }
    }
}
