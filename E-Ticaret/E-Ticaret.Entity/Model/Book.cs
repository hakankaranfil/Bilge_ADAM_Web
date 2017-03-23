using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entity.Model
{
  public  class Book
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookSubject { get; set; }
        public int PageCount { get; set; }
        public int WriterID { get; set; }
        public decimal Price { get; set; }
        public string BookPhotoURL { get; set; }
        public Writer Writer { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
