using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KutuphaneOtomasyon.WEB.Models
{
    public class WiewBook
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookSubject { get; set; }
        public string WriterName { get; set; }


        public int PageCount { get; set; }
        public int WriterID { get; set; }
        public int ShelfNumber { get; set; }
        public string IsRented { get; set; }
    }
}