using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBGH.data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreBGH.Pages.Modul07
{
    public class plzPageModel : PageModel
    {
        PlzService _plzservice;
        public plzPageModel(PlzService plzservice)
        {
            _plzservice = plzservice;
        }
        public List<Plz> PLZListe { get; set; } 
        public void OnGet()
        {
            //    var q=from p in  _plzservice.PlzListe
            //          select p 
            PLZListe = _plzservice.PlzListe.Take(10).ToList();

        }
    }
}