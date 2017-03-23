using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entity.Model
{
   public class Sale
    {
        public int SaleID { get; set; }
        public int BookID { get; set; }
        public decimal BookPrice { get; set; }
        public  int CustomerID { get; set; }
        public int BookCount { get; set; }
        public decimal TotalPrice
        {
            get
            {
                return BookPrice * BookCount;
            }
           }
        public Book Book { get; set; }
        public Customer Customer { get; set; }

    }
}
