using KutuphaneOtomasyon.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.DAL
{
  public  class UsersRespositery
    {
        public static List<User> GetAllUser()
        {
            using (KutuphaneDBContext db=new KutuphaneDBContext())
            {
                return db.User.ToList();
            }
           
        }
        public static void UserAdd(User user)
        {
            using (KutuphaneDBContext db=new KutuphaneDBContext())
            {
                db.User.Add(user);
                db.SaveChanges();
            }
        }
    }
}
