using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yemek.Entity.Model
{
    public enum ProductType
    {
        Soup,
        MainCourse,
        Dessert
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public bool IsSelected { get; set; }
        public ProductType ProductType { get; set; }
    }
}
