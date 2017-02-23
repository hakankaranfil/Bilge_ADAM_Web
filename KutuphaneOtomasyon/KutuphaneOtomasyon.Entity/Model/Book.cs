using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.Entity.Model
{
 public   class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookSubject { get; set; }

       
        public int PageCount { get; set; }
        public int WriterID { get; set; }
        public int ShelfNumber { get; set; }
        public string IsRented { get; set; }

        public Writer Writer { get; set; }
    }
}
