using Blog_MVC_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC_DAL.Repos
{
   public class CatagoryRepo
    {
        public static List<Category> GetAll()
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Category.ToList();

            }
        }
        public static void Add(Category cat)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                db.Category.Add(cat);
                db.SaveChanges();
            }
        }
        public static Category Get(string categoryname)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Category.FirstOrDefault(c => c.Name == categoryname);
            }

        }
    }
}
