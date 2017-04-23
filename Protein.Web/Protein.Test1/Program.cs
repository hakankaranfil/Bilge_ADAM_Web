using Protein.Entity;
using Protein.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ProteinDBContext db = new ProteinDBContext())
            {
                Admin a = new Admin();
                a.UserName = "Hakan";
                a.Password = "1234";

                db.Admin.Add(a);

                Category c = new Category();
                c.CategoryName = "Protein Tozu";
                db.Category.Add(c);



                Brand w = new Brand();
               w.BrandName = "Optimum";
                
                db.Brand.Add(w);


                Product b = new Product()
                {
                   ProductName = "Optimum Whey",
                    ProductContent = "aaaaa",
                    CategoryID = 1,
                    Price = 230,
                   BrandID= 1,                        
                   ProductPhoto = "http://placehold.it/800x300",
                };

                db.Product.Add(b);
                Customer cu = new Customer()
                {
                    Name = "Hakan Karanfil",
                    Address = "izmir"

                };

                db.Customer.Add(cu);

                db.SaveChanges();
            }
        }
    }
    }

