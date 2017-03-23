namespace E_Ticaret.Entity.DBConnection
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ETicaretContext : DbContext
    {
        public ETicaretContext()
            : base("name=ETicaretDB")
        {
        }



        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Writer> Writer { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Sale> Sale{ get; set; }
        public virtual DbSet<Category> Category { get; set; }


    }

 
}