using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İMDB.Entity
{
  public  class WiewMovie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }
        public string MovieSubject { get; set; }
        public DateTime RealiseDate { get; set; }
        public int MovieRating { get; set; }
        public string MovieTypeName { get; set; }
        public string DirectorName { get; set; }
    }
}
