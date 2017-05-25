using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;

namespace Yemek.Entity.ViewModel
{
   public class ViewMenu
    {
        public int MenuID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public bool IsSelected { get; set; }
        public DateTime Datetime { get; set; }
        public ProductType ProductType { get; set; }
    }
}
