using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.Modul07
{
    public class CalcModel : PageModel
    {
        [BindProperty]
        public int Eins { get; set; }
        [BindProperty]
        public int Zwei { get; set; }
        public int Ergebnis { get; set; }
       
        public void OnPostPlus()
        {
            Ergebnis = Eins + Zwei;
        }
        public void OnPostMinus()
        {
            Ergebnis = Eins - Zwei;
        }
    }
}