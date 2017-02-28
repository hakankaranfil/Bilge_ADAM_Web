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
        public static void DeleteDirector(int id)
        {
            using (IMDBDB db = new IMDBDB())
            {
                var result = db.Director.Find(id);
                db.Director.Remove(result);
                db.SaveChanges();

            }
        }
        public static Director GetDirector(int id)
        {
            using (IMDBDB db = new IMDBDB())
            {
                return db.Director.Find(id);
            }
        }
        public static void UpdateDirector(int id, string name)
        {
            using (IMDBDB db = new IMDBDB())
            {
                var result = db.Director.Find(id);
                result.DirectorName = name;
                db.SaveChanges();
            }
        }
    }
}


