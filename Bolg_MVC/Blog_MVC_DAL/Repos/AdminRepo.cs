using Blog_MVC_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC_DAL.Repos
{
   public class AdminRepo
    {
        public static void Add(Admin adm)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                db.Admin.Add(adm);
                db.SaveChanges();
            }
        }
    }
}
