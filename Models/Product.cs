using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSessionAssign01.Models
{
    public class Product
    {
        public string Pid { get; set; }
        public string Pname { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
    }
}
