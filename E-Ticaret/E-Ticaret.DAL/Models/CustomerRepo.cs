using E_Ticaret.Entity.DBConnection;
using E_Ticaret.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DAL.Models
{
   public class CustomerRepo
    {
        public static void AddCustomer(Customer customer)
        {
            using (ETicaretContext db = new ETicaretContext())
            {
                db.Customer.Add(customer);
                db.SaveChanges();
            }
        }
    }
}
