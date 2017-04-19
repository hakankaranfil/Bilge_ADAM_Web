namespace Protein.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        BrandID = c.Int(nullable: false, identity: true),
                        BrandName = c.String(),
                    })
                .PrimaryKey(t => t.BrandID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductContent = c.String(),
                        Price = c.Int(nullable: false),
                        ProductPhoto = c.String(),
                        CategoryID = c.Int(nullable: false),
                        BrandID = c.Int(nullable: false),
                        Customer_CustomerID = c.Int(),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Brands", t => t.BrandID, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerID)
                .Index(t => t.CategoryID)
                .Index(t => t.BrandID)
                .Index(t => t.Customer_CustomerID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(),
                        Address = c.String(),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.ShoppingCarts",
                c => new
                    {
                        ShoppingCartID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        ProductName = c.String(),
                        ProductContent = c.String(),
                        Price = c.Int(nullable: false),
                        ProductCount = c.Int(nullable: false),
                        ProductPhoto = c.String(),
                    })
                .PrimaryKey(t => t.ShoppingCartID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Customer_CustomerID", "dbo.Customers");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Products", "BrandID", "dbo.Brands");
            DropIndex("dbo.Products", new[] { "Customer_CustomerID" });
            DropIndex("dbo.Products", new[] { "BrandID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.ShoppingCarts");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
            DropTable("dbo.Products");
            DropTable("dbo.Brands");
            DropTable("dbo.Admins");
        }
    }
}
