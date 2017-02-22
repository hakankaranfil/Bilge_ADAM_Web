namespace WebQuiz_Kütüphane
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Kutuphane : DbContext
    {
 
        public Kutuphane()
            : base("name=Kutuphane")
        {
        }



        public virtual DbSet<Kullanici> Kullanici{ get; set; }
        public virtual DbSet<Kitap> Kitap { get; set; }
        public virtual DbSet<KiralananKitap> KiralananKitap { get; set; }
    }

    
}