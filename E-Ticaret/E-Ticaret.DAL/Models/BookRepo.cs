﻿using E_Ticaret.Entity.DBConnection;
using E_Ticaret.Entity.Model;
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
            using (ETicaretContext db = new ETicaretContext())
            {
                return db.Book.
                    Select(b => new ViewBookForHome
                    {
                        BookID = b.BookID,
                        WriterID = b.WriterID,
                        BookName = b.BookName,
                        WriterName = b.Writer.WriterName,
                        Price = b.Price,
                        BookPhotoURL = b.BookPhotoURL
                    }).ToList();
            }
        }
        public static List<ViewBookForHome> SearchAll(string search)
        {
            using (ETicaretContext db = new ETicaretContext())
            {
               return  db.Book.
                Select(b => new ViewBookForHome
                {
                    BookID = b.BookID,
                    WriterID = b.WriterID,
                    BookName = b.BookName,
                    WriterName = b.Writer.WriterName,
                    Price = b.Price,
                    BookPhotoURL = b.BookPhotoURL
                }).Where(n => n.BookName.Contains(search)).ToList();
                //name.Where(m => m.BookName.Contains(search));
              
                //var name = db.Book.Where(n => n.BookName.Contains(search));
                //return name.ToList();


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
        public static List<ViewBookForCategory> GetAllBook(int id)
        {
            using (ETicaretContext db = new ETicaretContext())
            {
                return db.Book.Where(b => b.CategoryID == id)
                        .Select(b => new ViewBookForCategory
                        {
                            BookID = b.BookID,
                            WriterID = b.WriterID,
                            BookName = b.BookName,
                            WriterName = b.Writer.WriterName,
                            Price = b.Price,
                            BookPhotoURL = b.BookPhotoURL,
                            CategoryID = b.CategoryID,
                        }).ToList();

            }
        }
        public static List<ViewBookForHome> GetAllForWriter(int id)
        {
            using (ETicaretContext db = new ETicaretContext())
            {
                return db.Book.Where(w => w.WriterID == id)
                    .Select(b => new ViewBookForHome
                    {
                        BookID = b.BookID,
                        WriterID = b.WriterID,
                        BookName = b.BookName,
                        WriterName = b.Writer.WriterName,
                        Price = b.Price,
                        BookPhotoURL = b.BookPhotoURL
                    }).ToList();
            }
        }
        public static ViewBookForHome GetBookForShop(int id)
        {
            using (ETicaretContext db = new ETicaretContext())
            {
                return db.Book.Where(b => b.BookID == id)
                   .Select(b => new ViewBookForHome
                   {
                       BookID = b.BookID,
                       WriterID = b.WriterID,
                       BookName = b.BookName,
                       WriterName = b.Writer.WriterName,
                       Price = b.Price,
                       BookPhotoURL = b.BookPhotoURL
                   }).FirstOrDefault();


            }

        }
    }
}

