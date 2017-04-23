using Protein.Entity;
using Protein.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protein.DAL.Repo
{
  public  class CustomRepo
    {
        public static void AddCustom(Custom cs)
        {
            using (ProteinDBContext db = new ProteinDBContext())
            {
                db.Custom.Add(cs);
                db.SaveChanges();
            }
        }
    }
}
