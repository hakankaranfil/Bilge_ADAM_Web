using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;
using Yemek.Entity.ViewModel;

namespace Yemek.DAL
{
    public class ProductRepo
    {
        public static List<Product> GetAllForHome()
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                return db.Products.ToList();
            }
        }
        public static List<Product> ProductId(int id)
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                return db.Products.Where(p => p.ProductID == id).ToList();
            }
        }
    }
}

