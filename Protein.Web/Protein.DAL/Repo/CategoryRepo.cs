using Protein.Entity;
using Protein.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.DAL
{
  public  class CategoryRepo
    {
        public static List<Category> GetAllForHome()
        {
            using (ProteinDBContext db = new ProteinDBContext())
            {
                return db.Category.ToList();
            }
        }
    }
}
