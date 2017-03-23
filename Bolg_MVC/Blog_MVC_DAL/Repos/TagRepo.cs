using Blog_MVC_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC_DAL.Repos
{
    public class TagRepo
    {
        public static List<Tag> GetAll()
        {
            using (BlogDBContext db=new BlogDBContext())
            {
                return db.Tag.ToList();
            }
        }
        public static void Add(Tag tag)
        {
            using (BlogDBContext db=new BlogDBContext())
            {
                db.Tag.Add(tag);
                db.SaveChanges();
            }
        }
    }
}
