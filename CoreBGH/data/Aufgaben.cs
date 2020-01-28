using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBGH.data
{
    public class Aufgaben
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Datum { get; set; }
        public bool Getan { get; set; }
    }
}
