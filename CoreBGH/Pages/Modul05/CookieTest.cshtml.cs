using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.Modul05
{
    public class CookieTestModel : PageModel
    {
        public void OnGet()
        {
            var options = new CookieOptions() { Domain = ".ppedv.de", Expires = DateTime.Now.AddDays(30),SameSite=SameSiteMode.Lax };
            Response.Cookies.Append("Hannes", "wert", options); //wird nicht gesetzt!
            options.Domain = null;
            Response.Cookies.Append("HannesohneDomain", "wert", options);
            var o = Request.Cookies["Hannes"];

        }
    }
}