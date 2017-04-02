namespace Protein.Entity
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ProteinDBContext : DbContext
    {
        public ProteinDBContext()
            : base("name=ProteinDB")
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category{ get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }

    }
}