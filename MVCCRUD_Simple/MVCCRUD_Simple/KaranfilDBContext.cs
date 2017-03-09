namespace MVCCRUD_Simple
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KaranfilDBContext1 : DbContext
    {
      
        public KaranfilDBContext1()
            : base("name=KaranfilDBContext1")
        {
        }


        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }

    }

}