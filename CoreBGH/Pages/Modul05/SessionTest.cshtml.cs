using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace CoreBGH.Pages.Modul05
{
    public class SessionTestModel : PageModel
    {
        public void OnGet()
        {
            HttpContext.Session.SetString("Hannes", DateTime.Now.ToLongDateString());
            HttpContext.Response.Redirect("~/hannes.html");
          var q= HttpContext.Request.Query["hannes"]; //?hannes=hallo
        }
    }
}