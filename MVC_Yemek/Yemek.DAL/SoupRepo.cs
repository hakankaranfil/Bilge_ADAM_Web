using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yemek.Entity.Model;

namespace Yemek.DAL
{
  public  class SoupRepo
    {
        public static List<Soup> GetAllSoup()
        {
            using (YemekDBContext db = new YemekDBContext())
            {
                return db.Soups.ToList();
            }
        }
    }
}
