using E_Ticaret.Entity.DBConnection;
using E_Ticaret.Entity.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DAL.Models
{
   public class BookRepo
    {
        public static List<ViewBookForHome> GetAllForHome()
        {
            using (ETicaretContext db=new ETicaretContext())
            {
                return db.Book.
                    Select(b => new ViewBookForHome
                    {
                        BookID =b.BookID,
                        WriterID=b.WriterID,
                        BookName=b.BookName,
                        WriterName=b.Writer.WriterName,
                        Price=b.Price,
                        BookPhotoURL=b.BookPhotoURL
                    }).ToList();
            }
        }
        public static ViewBookForDetails Get(int id)
        {
            using (ETicaretContext db = new ETicaretContext())
            {
                return db.Book.Where(b => b.BookID == id)
                    .Select(b => new ViewBookForDetails
                    {
                        BookID = b.BookID,
                        WriterID = b.WriterID,
                        BookName = b.BookName,
                        WriterName = b.Writer.WriterName,
                        Price = b.Price,
                        BookSubject = b.BookSubject,
                        PageCount = b.PageCount,
                        BookPhotoURL = b.BookPhotoURL
                    }).FirstOrDefault();
            }
        }

    }
}
