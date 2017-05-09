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
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//Databasede yer alan tablolarýmýzýn sonundaki s harfini silmemiz için
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Dessert> Desserts { get; set; }
        public virtual DbSet<MainCourse> MainCourses { get; set; }
        public virtual DbSet<Salad> Salads { get; set; }
        public virtual DbSet<Soup> Soups { get; set; }
        public virtual DbSet<Menu> Menu { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Staff> Staffs { get; set; }
    }
}