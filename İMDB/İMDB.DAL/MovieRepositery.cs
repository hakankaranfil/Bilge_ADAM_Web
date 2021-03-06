﻿using İMDB.Entity;
using İMDB.Entity.Wiew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İMDB.DAL
{
    public class MovieRepositery
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
                return db.Movie.Where(b => b.DirectorID == directorid).Select(b => new WiewDirectorMovie
                {
                    MovieID = b.MovieID,
                    MovieName = b.MovieName,
                    DirectorID = b.DirectorID,
                    DirectorName = b.Director.DirectorName,
                }).ToList();
            }
        }
        public static List<WiewMovie> GetAllDRating()
        {
            using (IMDBDB db = new IMDBDB())
            {
                return db.Movie.OrderByDescending(b => b.MovieRating).Select(b => new WiewMovie
                {
                    MovieID = b.MovieID,
                    MovieName = b.MovieName,
                    DirectorID = b.DirectorID,
                    DirectorName = b.Director.DirectorName,
                    MovieRating = b.MovieRating,
                    MovieSubject = b.MovieSubject,
                    MovieTypeName = b.MovieType.MovieTypeName
                }).ToList();
            }
        }
        public static List<WiewMovie> GetAllMovieType(int id)
        {
            using (IMDBDB db = new IMDBDB())
            {
                return db.Movie.Where(b => b.MovieTypeID == id).Select(b => new WiewMovie
                {
                    MovieID = b.MovieID,
                    MovieName = b.MovieName,
                    DirectorID = b.DirectorID,
                    DirectorName = b.Director.DirectorName,
                    MovieRating = b.MovieRating,
                    MovieSubject = b.MovieSubject,
                    MovieTypeName = b.MovieType.MovieTypeName
                }).ToList();
            }
        }
        public static void UpdateMovie(int id, string name,string subject,int rating,int director,int type,DateTime realise)
        {
            using (IMDBDB db = new IMDBDB())
            {
                var result = db.Movie.Find(id);
                result.MovieName = name;
                result.MovieSubject = subject;
                result.MovieRating = rating;
                result.DirectorID = director;
                result.MovieTypeID = type;
                result.RealiseDate = realise;
                db.SaveChanges();
            }
        }
        public static Movie GetMovie(int id)
        {
            using (IMDBDB db = new IMDBDB())
            {
                return db.Movie.Find(id);
            }
        }


    }

}



