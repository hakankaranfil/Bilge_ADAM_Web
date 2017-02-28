using İMDB.Entity;
using İMDB.Entity.Wiew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İMDB.DAL
{
    public class MovieRepository
    {
        public static List<WiewMovie> GetAllMovie()
        {
            using (IMDBDB db = new IMDBDB())
            {
                return db.Movie.Select(b => new WiewMovie
                {
                    MovieID = b.MovieID,
                    MovieName = b.MovieName,
                    MovieSubject = b.MovieSubject,
                    RealiseDate = b.RealiseDate,
                    MovieRating = b.MovieRating,
                    MovieTypeName = b.MovieType.MovieTypeName,
                    DirectorName = b.Director.DirectorName,
                }).ToList();
            }
        }
        public static void AddMovie(Movie movie)
        {
            using (IMDBDB db = new IMDBDB())
            {
                db.Movie.Add(movie);
                db.SaveChanges();
            }
        }
        public static void DeleteMovie(int id)
        {
            using (IMDBDB db = new IMDBDB())
            {
                var result = db.Movie.Find(id);
                db.Movie.Remove(result);
                db.SaveChanges();

            }
        }
        public static List<WiewDirectorMovie> GetAllDMovies(int directorid)
        {
            using (IMDBDB db = new IMDBDB())
            {
                return db.Movie.Where(b=>b.DirectorID==directorid).Select(b => new WiewDirectorMovie
                {
                    MovieID = b.MovieID,
                    MovieName = b.MovieName,
                    DirectorID=b.DirectorID,
                    DirectorName = b.Director.DirectorName,
                }).ToList();
            }
        }
 
        }

        }
    


