using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.Entity.Model
{
  public  class Custom
    {
        public int CustomID { get; set; }
        public List<ShoppingCart> ShoppingBag { get; set; }
        public double TotalBill { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShippingAddress { get; set; }
        public Customer Customer { get; set; }
    }
}
