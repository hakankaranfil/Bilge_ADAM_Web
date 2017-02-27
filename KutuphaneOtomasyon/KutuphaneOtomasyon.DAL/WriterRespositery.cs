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
        public static void AddWriter(Writer writer)

        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                db.Writer.Add(writer);
                db.SaveChanges();

            }
        }
        public static void DeleteWriter(int id)
        {
            using (KutuphaneDBContext db=new KutuphaneDBContext())
            {
                var result = db.Writer.Find(id);
                db.Writer.Remove(result);
                db.SaveChanges();
            }
        }
        public static void UpdateWriter(int id, string name)
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
                var result = db.Writer.Find(id);
                result.WriterName = name;
                db.SaveChanges();
            }
        }
             public static Writer GetWriter(int id)
        {
            using (KutuphaneDBContext db = new KutuphaneDBContext())
            {
              return  db.Writer.Find(id);

            }
        }

    }
}
