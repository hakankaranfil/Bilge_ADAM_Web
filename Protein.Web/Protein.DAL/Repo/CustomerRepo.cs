using Protein.Entity;
using Protein.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.DAL.Repo
{
    public class CustomerRepo
    {
        public static void Add(Customer customer)
        {
            using (ProteinDBContext db = new ProteinDBContext())
            {
                db.Customer.Add(customer);
                db.SaveChanges();
            }
        }
        public static Customer Get(Customer customer)
        {
            using (ProteinDBContext db = new ProteinDBContext())
            {
                return db.Customer.FirstOrDefault(c => c.Email == customer.Email && c.Password ==customer.Password);
            }
        }
        public static Customer GetID(int id)
        {
            using (ProteinDBContext db = new ProteinDBContext())
            {
                return db.Customer.Find(id);

            }
        }
        public static Customer UpdateCustomerInfo(Customer customer)
        {
            using (ProteinDBContext db = new ProteinDBContext())
            {
                var uptated = db.Customer.Find(customer.CustomerID);
                uptated.Name = customer.Name;
                uptated.Surname = customer.Surname;
                uptated.Phone = customer.Phone;
                db.SaveChanges();
                return uptated;
            }
        }
    }
}
