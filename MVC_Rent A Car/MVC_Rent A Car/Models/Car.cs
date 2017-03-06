using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Rent_A_Car.Models
{
    public class Car
    {
        public int CarID { get; set; }
        public string Brend { get; set; }
        public string Model { get; set; }
        public byte Page { get; set; }

    }
}