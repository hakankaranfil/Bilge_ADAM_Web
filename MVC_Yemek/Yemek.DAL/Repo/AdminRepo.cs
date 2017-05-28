using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;

namespace Yemek.DAL
{
  public  class AdminRepo
    {
        public static Admin AdminLogin(Admin model)
        {
            using (YemekDBContext db=new YemekDBContext())
            {
            return  db.Admin.FirstOrDefault(a => a.Email == model.Email && a.Password == a.Password);
            }
        }
    }
}
