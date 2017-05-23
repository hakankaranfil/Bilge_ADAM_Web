using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yemek.Entity.Model;

namespace Yemek.Web
{
    public class ViewProduct
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public bool IsSelected { get; set; }
        public Product Product { get; set; }
    }
}