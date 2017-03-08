using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCRUD_Simple.Models
{
    public class Car:Base
    {
        public int CarID { get; set; }
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string CarAge { get; set; }
    }
}