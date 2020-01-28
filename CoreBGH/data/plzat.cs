using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBGH.data
{

    public class Rootobject
    {
        public Plz[] Property1 { get; set; }
    }

    public class Plz
    {
        public string country_code { get; set; }
        public string zipcode { get; set; }
        public string place { get; set; }
        public string state { get; set; }
        public string state_code { get; set; }
        public string province { get; set; }
        public string province_code { get; set; }
        public string community { get; set; }
        public string community_code { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
    }

}
