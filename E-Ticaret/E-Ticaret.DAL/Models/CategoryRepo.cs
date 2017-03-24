using E_Ticaret.Entity.DBConnection;
using E_Ticaret.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.DAL.Models
{
    public class CategoryRepo
    {
        public static List<Category> GetAllForHome()
        {
            using (ETicaretContext db = new ETicaretContext())
            {
                return db.Category.ToList();
            }
        }
        public static string GetCategoryName(int id)
        {
            using (ETicaretContext db = new ETicaretContext())
            {
                return db.Category.Find(id).CategoryName;
        }
        }
    }
}
