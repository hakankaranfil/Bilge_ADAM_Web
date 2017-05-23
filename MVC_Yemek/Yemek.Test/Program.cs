using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;

namespace Yemek.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (YemekDBContext db=new YemekDBContext())
            {
                Product pr = new Product();
                pr.ProductName = "Baklava";
                pr.ProductPrice = 4;
                pr.ProductType = ProductType.Dessert;
                db.Products.Add(pr);
                db.SaveChanges();
            }
        }
    }
}
