namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle17 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mail",
                c => new
                    {
                        MailID = c.Int(nullable: false, identity: true),
                        Sifre = c.String(),
                        GonderilecekMail = c.String(),
                        Konu = c.String(),
                        GondericiMail = c.String(),
                        Admin_AdminID = c.Int(),
                        Customer_CustomerID = c.Int(),
                        Menu_MenuID = c.Int(),
                        Product_ProductID = c.Int(),
                    })
                .PrimaryKey(t => t.MailID)
                .ForeignKey("dbo.Admin", t => t.Admin_AdminID)
                .ForeignKey("dbo.Customer", t => t.Customer_CustomerID)
                .ForeignKey("dbo.Menu", t => t.Menu_MenuID)
                .ForeignKey("dbo.Product", t => t.Product_ProductID)
                .Index(t => t.Admin_AdminID)
                .Index(t => t.Customer_CustomerID)
                .Index(t => t.Menu_MenuID)
                .Index(t => t.Product_ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mail", "Product_ProductID", "dbo.Product");
            DropForeignKey("dbo.Mail", "Menu_MenuID", "dbo.Menu");
            DropForeignKey("dbo.Mail", "Customer_CustomerID", "dbo.Customer");
            DropForeignKey("dbo.Mail", "Admin_AdminID", "dbo.Admin");
            DropIndex("dbo.Mail", new[] { "Product_ProductID" });
            DropIndex("dbo.Mail", new[] { "Menu_MenuID" });
            DropIndex("dbo.Mail", new[] { "Customer_CustomerID" });
            DropIndex("dbo.Mail", new[] { "Admin_AdminID" });
            DropTable("dbo.Mail");
        }
    }
}
