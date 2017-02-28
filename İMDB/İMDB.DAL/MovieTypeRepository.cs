using İMDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İMDB.DAL
{
    public class MovieTypeRepository
    {
        public static List<MovieType> GetAllMovieType()
        {
            using (IMDBDB db = new IMDBDB())
            {
                return db.MovieType.ToList();
            }
        }
    }
}
