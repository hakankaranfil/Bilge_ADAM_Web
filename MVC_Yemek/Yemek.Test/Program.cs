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
                Soup s = new Soup();
                Dessert d = new Dessert();
                MainCourse m = new MainCourse();
                Salad sa = new Salad();
                Staff st = new Staff();
                s.Name="Mercimek Çorbası";
                s.Price = 7;
                db.Soups.Add(s);
                d.Name = "Baklava";
                d.Price = 5;
                db.Desserts.Add(d);
                m.Name = "Tavuk Sote";
                m.Price = 6;
                db.MainCourses.Add(m);
                sa.Name = "Çoban Salatası";
                sa.Price = 3;
                db.Salads.Add(sa);  
                st.StaffEmail = "a@hotmail.com";
                st.StaffName = "Emre";
                st.StaffPassword = "1234";
                db.Staffs.Add(st);
                db.SaveChanges();
            }
        }
    }
}
