using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.Entity.Model
{
   public class Brand
    {
        public int BrandID { get; set; }
        public string BrandName { get; set; }
        public List<Product> Product { get; set; }
    }
}
