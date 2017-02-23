using KutuphaneOtomasyon.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneOtomasyon.DAL
{
   public class WriterRespositery
    {
        public static List<Writer> GetAllWriter()
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                return db.Writer.ToList();
            }
        }
           
    }
}
