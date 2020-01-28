using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.Modul07
{
    public class indexModel : PageModel
    {
        public void OnGet([FromQuery] int? id1)
        {

        }
    }
}