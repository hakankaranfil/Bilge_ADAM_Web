using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İMDB.Entity
{
 public   class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieSubject { get; set; }
        public DateTime RealiseDate { get; set; }
        public int MovieRating { get; set; }
        public int MovieTypeID { get; set; }
        public int DirectorID { get; set; }

        public MovieType MovieType { get; set; }
        public Director Director { get; set; }

    }
}
