namespace MVC_Rent_A_Car
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class CarDBContext : DbContext
    {
        // Your context has been configured to use a 'CarDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVC_Rent_A_Car.CarDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CarDBContext' 
        // connection string in the application configuration file.
        public CarDBContext()
            : base("name=CarDBContext")
        {
        }



        public virtual DbSet<Car> Car { get; set; }
    }

  
}