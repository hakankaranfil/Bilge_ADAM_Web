using Protein.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.Entity.View
{
  public class ViewProductAndCategory
    {
        public IEnumerable< Category>  Category { get; set; }
        public IEnumerable <Product> Product { get; set; }
    }
}
