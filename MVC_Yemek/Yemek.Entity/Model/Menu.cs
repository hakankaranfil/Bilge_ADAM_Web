using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek.Entity.Model
{
   public class Menu
    {
        public int MenuID { get; set; }
        public int ProductID { get; set; }
        public DateTime Datetime { get; set; }
        public Product Product { get; set; }

    }
}
