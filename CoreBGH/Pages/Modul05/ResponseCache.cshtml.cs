using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.Modul05
{

    [ResponseCache(Duration = 30,VaryByHeader ="User-Agent")]
    public class ResponseCacheModel : PageModel
    {
       
        public void OnGet()
        {

        }
    }
}