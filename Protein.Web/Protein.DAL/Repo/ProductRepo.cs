using Protein.Entity;
using Protein.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.DAL
{
  public  class ProductRepo
    {
        public static List<Product> GetAllForHome()
        {
            using (ProteinDBContext db=new ProteinDBContext())
            {
                return db.Product.ToList();
            }
        }
            
    }
}
