namespace MVCCRUD_Simple
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class KaranfilDBContext : DbContext
    {
        // Your context has been configured to use a 'KaranfilDBContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MVCCRUD_Simple.KaranfilDBContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'KaranfilDBContext' 
        // connection string in the application configuration file.
        public KaranfilDBContext()
            : base("name=KaranfilDBContext")
        {
        }


        public virtual DbSet<Car> Car { get; set; }
    }

}