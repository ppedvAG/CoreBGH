using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBGH.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.Modul08
{
    public class EditToDoModel : PageModel
    {
        [BindProperty]
        public Todos MyToDo { get; set; }
        public void OnGet()
        {
  //          MyToDo = new Todos();
  //var rnd = new Random();
  //          MyToDo.id = rnd.Next(10000); //Fake um DB identity zu simulieren

        }
        public IActionResult OnPost()
        {
            ModelState.Remove("id"); //akademisch -Fehler aus Modelstate entfernen
            ModelState.Clear();
            var rnd = new Random();
            MyToDo.id = rnd.Next(10000); //Fake um DB identity zu simulieren

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("hannes", "lern mal asp.net core");
                return Page();
            }

          
            return Page();
        }
    }
}