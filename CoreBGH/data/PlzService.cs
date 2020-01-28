using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace CoreBGH.data
{
    public class PlzService
    {
        public List<Plz> PlzListe { get; set; }
        public PlzService()
        {

            var pfad = AppDomain.CurrentDomain.GetData("DatenVerzeichnis") + "plzat.json";
            var daten = File.ReadAllText(pfad); //möge der Dev ewig in der Hölle schmoren
            var json = JsonSerializer.Deserialize<List<Plz>>(daten);
        }
    }
}
