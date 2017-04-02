using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.Entity.Model
{
  public  class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public List<Product> ShopList { get; set; }
        public decimal Total { get; set; }
    }
}
