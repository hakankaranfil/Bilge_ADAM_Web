using Protein.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.Entity.View
{
  public  class ViewPayment
    {
        public int CustomerID { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public List<ShoppingCart> ShoppingList { get; set; }
    }
}
