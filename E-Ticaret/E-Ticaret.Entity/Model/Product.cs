using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entity.Model
{
   public class Product
    {
        public int ProductID { get; set; }

        public int BookID { get; set; }

        public string BookPhotoURL { get; set; }

        public string BookName { get; set; }

        public int BookCount { get; set; }

        public decimal Price { get; set; }

        public decimal TotalPrice
        {
            get { return Price * BookCount; }

        }
    }
}
