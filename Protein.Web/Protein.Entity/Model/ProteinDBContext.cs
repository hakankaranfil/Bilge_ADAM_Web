namespace Protein.Entity
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class ProteinDBContext : DbContext
    {
        public ProteinDBContext()
            : base("name=ProteinDB")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//Databasede yer alan tablolarýmýzýn sonundaki s harfini silmemiz için
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category{ get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Custom>Custom { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCart { get; set; }

    }
}