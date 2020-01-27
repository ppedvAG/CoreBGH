using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.modul04
{
    public class UsePartialModel : PageModel
    {
        public int MyProperty { get; set; } = 42;
        public void OnGet()
        {

        }
    }
}