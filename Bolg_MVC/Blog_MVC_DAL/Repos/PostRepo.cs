using Blog_MVC_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog_MVC_DAL.Repos
{
    public class PostRepo
    {
        public static List<Post> GetAll()
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Post.Where(p => p.IsDeleted == false).OrderByDescending(p => p.PostDate).ToList();

            }
        }
        public static void Add(Post post)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                foreach (var itemTag in post.Tags)
                {
                    var result = db.Tag.Include("Posts").FirstOrDefault(t => t.Name == itemTag.Name);

                    if (result != null)
                    {
                        post.Tags = null;

                        result.Posts.Add(post);
                    }
                    else
                    {
                        itemTag.Posts = new List<Post>() { post };
                        db.Tag.Add(itemTag);
                    }
                }
                db.SaveChanges();
            }
        }
        public static Post Get(int Postid)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Post.Include("Tags").FirstOrDefault(p=>p.PostID==Postid);
            }

        }
        public static List<Post> GetALLRating()
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                return db.Post.OrderByDescending(p => p.PostDate).ToList();
            }
        }
        public static void Delete(int id)
        {
            using (BlogDBContext db = new BlogDBContext())
            {

                var result = db.Post.FirstOrDefault(p => p.PostID == id);
                result.IsDeleted = true;
                db.SaveChanges();

            }
        }
        public static void Uptade(Post post)
        {
            using (BlogDBContext db = new BlogDBContext())
            {
                Delete(post.PostID);
                Add(post);
                db.SaveChanges();
            }
               
            }
        }
    }

