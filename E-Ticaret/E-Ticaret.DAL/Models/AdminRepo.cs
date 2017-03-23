using E_Ticaret.Entity.DBConnection;
using E_Ticaret.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DAL.Models
{
     public class AdminRepo
    {
        public static Admin Get(Admin admin)
        {
            using (ETicaretContext db = new ETicaretContext())
            {
                return db.Admin.FirstOrDefault(a => a.UserName == admin.UserName && a.Password == admin.Password);

            }
        }
    }
}
