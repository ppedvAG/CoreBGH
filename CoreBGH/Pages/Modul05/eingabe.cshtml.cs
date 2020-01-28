using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.Modul05
{
    public class eingabeModel : PageModel
    {
        public void OnGet()
        {

        }
        public void OnPostTuwas([FromForm] string eins)
        {
            TempData.Add("hannes", eins);
            Response.Redirect("ergebnis");
        }
    }
}