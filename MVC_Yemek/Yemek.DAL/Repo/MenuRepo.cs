using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;
using Yemek.Entity.ViewModel;

namespace Yemek.DAL
{
    public class MenuRepo
    {
        public static void AddMenu(Product product)
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                Menu menu = new Menu()
                {

                    ProductID = product.ProductID,
                    Datetime = DateTime.Today

                };

                db.Menu.Add(menu);
                db.SaveChanges();
            }
        }
        public static List<ViewMenu> MenuList()
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                return db.Menu.Where(m=>m.Datetime==DateTime.Today && m.IsDelete==false)
                    .Select(m => new ViewMenu
                    {
                        ProductID = m.ProductID,
                        MenuID = m.MenuID,
                        Datetime = m.Datetime,
                        ProductName = m.Product.ProductName,
                        ProductPrice = m.Product.ProductPrice,
                        ProductType = m.Product.ProductType
                    }).ToList();

            }
        }
        public static List<ViewMenu> AdminMenuList(DateTime datetime)
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                return db.Menu.Where(m => m.Datetime == datetime && m.IsDelete==false)
                    .Select(m => new ViewMenu
                    {
                        ProductID = m.ProductID,
                        MenuID = m.MenuID,
                        Datetime = m.Datetime,
                        ProductName = m.Product.ProductName,
                        ProductPrice = m.Product.ProductPrice,
                        ProductType = m.Product.ProductType
                    }).ToList();

            }
        }
        public static void DeleteMenu(int id)
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                var result = db.Menu.FirstOrDefault(m => m.MenuID == id);
                result.IsDelete= true;
                db.SaveChanges();

            }
        }
    }
}
