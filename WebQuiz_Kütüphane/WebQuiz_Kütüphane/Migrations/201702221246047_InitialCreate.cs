namespace WebQuiz_Kütüphane.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.KiralananKitaps",
                c => new
                    {
                        KiralananKitapID = c.Int(nullable: false, identity: true),
                        KitapID = c.Int(nullable: false),
                        KullaniciID = c.Int(nullable: false),
                        KullaniciAdi = c.String(),
                        KitapAdi = c.String(),
                        Durum = c.Boolean(nullable: false),
                        AlisTarihi = c.DateTime(nullable: false),
                        IadeTarihi = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KiralananKitapID)
                .ForeignKey("dbo.Kitaps", t => t.KitapID, cascadeDelete: true)
                .ForeignKey("dbo.Kullanicis", t => t.KullaniciID, cascadeDelete: true)
                .Index(t => t.KitapID)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.Kitaps",
                c => new
                    {
                        KitapID = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(),
                        KitapKonu = c.String(),
                        Durum = c.Boolean(nullable: false),
                        KitapSayfa = c.String(),
                    })
                .PrimaryKey(t => t.KitapID);
            
            CreateTable(
                "dbo.Kullanicis",
                c => new
                    {
                        KullaniciID = c.Int(nullable: false, identity: true),
                        KullaniciAdi = c.String(),
                        KullaniciAdres = c.String(),
                        KullaniciTel = c.String(),
                    })
                .PrimaryKey(t => t.KullaniciID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KiralananKitaps", "KullaniciID", "dbo.Kullanicis");
            DropForeignKey("dbo.KiralananKitaps", "KitapID", "dbo.Kitaps");
            DropIndex("dbo.KiralananKitaps", new[] { "KullaniciID" });
            DropIndex("dbo.KiralananKitaps", new[] { "KitapID" });
            DropTable("dbo.Kullanicis");
            DropTable("dbo.Kitaps");
            DropTable("dbo.KiralananKitaps");
        }
    }
}
