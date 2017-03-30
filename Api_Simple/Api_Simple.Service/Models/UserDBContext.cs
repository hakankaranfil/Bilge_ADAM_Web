namespace Api_Simple.Service.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class UserDBContext : DbContext
    {

        public UserDBContext()
            : base("name=UserDBContext")
        {
        }



        public virtual DbSet<User> User { get; set; }
        public class Confirigation : CreateDatabaseIfNotExists<UserDBContext>
        {
            protected override void Seed(UserDBContext context)
            {
                context.User.Add(new User()
                {
                    FirstName = "Hakan",
                    LastName = "KARANFÝL"
                });
                context.SaveChanges();
            }
        }


    }
}