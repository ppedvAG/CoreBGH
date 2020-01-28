using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBGH.data
{
    public class Aufgaben
    {
        [Display(Description ="ID")]
        public int ID { get; set; }
        [Display(Description = "Aufgabe",Name ="AufgabeName")]
        [MaxLength(20,ErrorMessage ="maximal 20 Zeichen")]
        [MinLength(2, ErrorMessage = "minaml 2 Zeichen")]
        public string Text { get; set; }
        public DateTime Datum { get; set; }
        public bool Getan { get; set; }
    }
}
