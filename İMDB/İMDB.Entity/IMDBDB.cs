namespace İMDB.Entity
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class IMDBDB : DbContext
    {

        public IMDBDB()
            : base("name=IMDBDB")
        {
        }



        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<Director> Director { get; set; }
        public virtual DbSet<MovieType> MovieType { get; set; }
    }


}