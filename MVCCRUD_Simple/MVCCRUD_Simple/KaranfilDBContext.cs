namespace MVCCRUD_Simple
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KaranfilDBContext : DbContext
    {
      
        public KaranfilDBContext()
            : base("name=KaranfilDBContext")
        {
        }


        public virtual DbSet<Car> Car { get; set; }
        public virtual DbSet<Motor> Motor { get; set; }
    }

}