using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;

namespace Yemek.DAL
{
    public class MenuRepo
    {
        public static void AddMenu(Product product)
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                Menu menu = new Menu() {
                    
                    ProductID = product.ProductID,
                    Datetime = DateTime.Now
                   
                };

                db.Menu.Add(menu);
                db.SaveChanges();
            }
        }
    }
}
