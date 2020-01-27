using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.Modul03
{
    public class calc1Model : PageModel
    {
        public int Ergebnis { get; set; }
        public void OnGet()
        {

        }
        public void OnPost()
        {
            int eins =int.Parse(Request.Form["eins"].FirstOrDefault());
            int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());
            Ergebnis = eins + zwei;


        }
    }
}