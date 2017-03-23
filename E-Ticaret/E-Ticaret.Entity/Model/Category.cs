using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entity.Model
{
   public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public List<Book> Books { get; set; }
    }
}
