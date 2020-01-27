using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.Modul03
{
    public class Seite2Model : PageModel
    {
        public void OnGet([FromServices] DI1 di)
        {
            di.BenutzerCounter++;
        }
    }
}