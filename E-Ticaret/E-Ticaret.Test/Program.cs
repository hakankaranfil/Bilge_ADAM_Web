using E_Ticaret.Entity.DBConnection;
using E_Ticaret.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ETicaretContext db = new ETicaretContext())
            {
                Admin a = new Admin();
                a.UserName = "bngs";
                a.Password = "1234";

                db.Admin.Add(a);

                Category c = new Category();
                c.CategoryName = "Tarih";
                db.Category.Add(c);



                Writer w = new Writer();
                w.WriterName = "Hakan";
                db.Writer.Add(w);


                Book b = new Book()
                {
                    BookName = "bookname",
                    BookSubject = "subject",
                    CategoryID = 1,
                    Price = 10,
                    WriterID = 1,
                    PageCount = 100,
                    BookPhotoURL = "http://placehold.it/800x300",
                };

                db.Book.Add(b);


                Customer cu = new Customer()
                {
                    NameSurname = "Hakan Karanfil",
                    Address = "izmir",
                    Total = 30,

                };

                db.Customer.Add(cu);

                Product s = new Product()
                {
                    BookID = 1,              
                    BookCount = 1,                 
                    BookPhotoURL = "http://placehold.it/800x300",
                    BookName="Bookname",
                    Price=20,
                 
                    
                   
                

               

                };

                db.Product.Add(s);

                db.SaveChanges();
            }
        }
    }
}

