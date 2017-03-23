using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entity.Model
{
  public  class Writer
    {
        public int WriterID { get; set; }
        public string WriterName { get; set; }
        public List<Book>Books { get; set; }
    }
}
