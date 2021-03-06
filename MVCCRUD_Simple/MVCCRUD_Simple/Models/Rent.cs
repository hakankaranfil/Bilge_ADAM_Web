﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCRUD_Simple.Models
{
    public class Rent
    {
        public int ID { get; set; }
        public string Customer { get; set; }
        public DateTime RentDate { get; set; }
        public int RentDay { get; set; }
        public double DayPrice { get; set; }
        public int VehicleID { get; set; }
        public double TotalPrice
        {
            get
            {
                return RentDay * DayPrice;
            }
        }

        public Vehicle Vehicle { get; set; }
    }
}