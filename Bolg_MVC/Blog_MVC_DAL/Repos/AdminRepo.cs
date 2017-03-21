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
        public static Admin Get(Admin admin)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Admin.FirstOrDefault(a => a.UserName == admin.UserName&& a.Password == admin.Password);

            }
        }
    }
}
