using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;

namespace Yemek.DAL
{
  public  class CustomerRepo
    {
        public static void Add(Customer model)
        {
            using (YemekDBContext db=new YemekDBContext())
            {
                db.Customers.Add(model);
                db.SaveChanges();
            }
        }
   
    }
}
