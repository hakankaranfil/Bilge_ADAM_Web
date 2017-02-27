using KutuphaneOtomasyon.Entity.Model;
using KutuphaneOtomasyon.Entity.WiewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.DAL
{
    public class RentRespositery

    {
        public static List<WiewRent> GetALLRent()
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                return db.Rent.Select(p => new WiewRent
                {
                    BookName = p.Book.BookName,
                    UserName = p.User.UserName,


                }).ToList();


            }
        }
    }
}
