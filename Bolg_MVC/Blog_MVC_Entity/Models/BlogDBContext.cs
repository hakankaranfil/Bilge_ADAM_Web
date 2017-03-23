namespace Blog_MVC_Entity.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BlogDBContext : DbContext
    {
        public BlogDBContext()
            : base("name=BlogDBContext")
        {
        }



        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Post> Post { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<Category> Category{ get; set; }
    }


}