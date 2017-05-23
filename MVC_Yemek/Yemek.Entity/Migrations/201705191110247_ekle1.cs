namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductPrice = c.Int(nullable: false),
                        ProductType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID);
            
            DropTable("dbo.Dessert");
            DropTable("dbo.MainCourse");
            DropTable("dbo.Menu");
            DropTable("dbo.Salad");
            DropTable("dbo.Soup");
            DropTable("dbo.Staff");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        StaffID = c.Int(nullable: false, identity: true),
                        StaffName = c.String(),
                        StaffEmail = c.String(),
                        StaffPassword = c.String(),
                    })
                .PrimaryKey(t => t.StaffID);
            
            CreateTable(
                "dbo.Soup",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Salad",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MenuID);
            
            CreateTable(
                "dbo.MainCourse",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Dessert",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.Product");
            DropTable("dbo.Admin");
        }
    }
}
