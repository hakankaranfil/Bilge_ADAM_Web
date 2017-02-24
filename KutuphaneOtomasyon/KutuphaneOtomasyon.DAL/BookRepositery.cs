using KutuphaneOtomasyon.Entity.Model;
using KutuphaneOtomasyon.WEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.DAL
{
    public class BookRepositery
    {
        public static List<WiewBook> GetALLBooks()
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                return db.Book.Select(p => new WiewBook
                {
                    BookID = p.BookID,
                    BookName = p.BookName,
                    BookSubject = p.BookSubject,
                    PageCount = p.PageCount,
                    IsRented = p.IsRented,
                    ShelfNumber = p.ShelfNumber,
                    WriterName = p.Writer.WriterName,
                }).ToList();


            }

        }
        public static void AddBook(Book book)

        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                db.Book.Add(book);
                db.SaveChanges();

            }
        }
        public static void DeleteBook(Book result)
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                
            }


        }
    }
}




       
