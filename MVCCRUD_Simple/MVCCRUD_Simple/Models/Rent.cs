using System;
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
        public double PriceDay { get; set; }
        public double TotalPrice
        {
            get
            {
                return RentDay * PriceDay;
            }

}
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}