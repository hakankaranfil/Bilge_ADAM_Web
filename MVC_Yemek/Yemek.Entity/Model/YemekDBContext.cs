namespace Yemek.Entity.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class YemekDBContext : DbContext
    {
        public YemekDBContext()
            : base("name=YemekDBContext")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//Databasede yer alan tablolar�m�z�n sonundaki s harfini silmemiz i�in
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }

    }
}