using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticaret.Entity.Model.ViewModel
{
    public class ViewBookForHome
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string WriterName { get; set; }
        public int WriterID { get; set; }
        public decimal Price { get; set; }
        public string BookPhotoURL { get; set; }
        public int BookCount { get; set; }
        public int TotalPrice { get; set; }
    }
}
