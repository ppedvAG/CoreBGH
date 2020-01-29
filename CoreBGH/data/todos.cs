﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreBGH.data
{

   
    public class Todos
    {
     
        public int userId { get; set; }
        [Key]
        public int id { get; set; }
        public string title { get; set; }
        public bool completed { get; set; }
    }

}
