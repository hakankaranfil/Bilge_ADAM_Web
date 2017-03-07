namespace MVCCRUD.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarContext : DbContext
    {
     
        public CarContext()
            : base("name=CarContext")
        {
        }



        public virtual DbSet<Car> Car { get; set; }
    }

}