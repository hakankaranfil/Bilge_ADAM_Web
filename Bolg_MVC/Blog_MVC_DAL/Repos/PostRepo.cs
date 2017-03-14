using Blog_MVC_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC_DAL.Repos
{
  public  class PostRepo
    {
        public static List<Post> GetAll()
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Post.ToList();

            }
        }
           
    }
}
