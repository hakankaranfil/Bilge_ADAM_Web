using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;
using Yemek.Entity.ViewModel;

namespace Yemek.DAL.Repo
{
    public class MailRepo
    {
        public static List<ViewMail> Menu()
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                return db.Menu.Where(m => m.Datetime == DateTime.Today && m.IsDelete == false)
                    .Select(m => new ViewMail
                    {
                        Sifre = "Hakan123.",
                        GondericiMail="hakan.karanfil@outlook.com",
                        GonderilecekMail=m.Product.ProductName,
                        Konu="Yemek Listesi"
                    }).ToList();
            }
        }
        public static void Add(Concent model)
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                db.Concents.Add(model);
                db.SaveChanges();
            }
        }
    }
}
