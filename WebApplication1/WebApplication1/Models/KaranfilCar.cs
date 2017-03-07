namespace WebApplication1.Models
{
    using Controllers;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KaranfilCar : DbContext
    {

        public KaranfilCar()
            : base("name=KaranfilCar")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Car> Car { get; set; }
    }


}