using İMDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İMDB.DAL
{
    public class DirectorRepository
    {
        public static void AddDirector(Director director)
        {
            using (IMDBDB db = new IMDBDB())
            {
                db.Director.Add(director);
                db.SaveChanges();
            }
        }
        public static List<Director> GetAllDirector()
        {
            using (IMDBDB db = new IMDBDB())
            {
                return db.Director.ToList();
            }
        }
    }
}

