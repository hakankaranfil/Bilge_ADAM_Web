using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.Entity.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductContent { get; set; }
        public int Price { get; set; }
        public int ProductCount { get; set; }
        public string ProductPhoto { get; set; }
        public int CategoryID { get; set; }
        public int BrandID { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
   
}
