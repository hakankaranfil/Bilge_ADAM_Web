namespace Protein.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Customer_CustomerID", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "Customer_CustomerID" });
            AddColumn("dbo.Customers", "UserName", c => c.String());
            AddColumn("dbo.Customers", "Password", c => c.String());
            DropColumn("dbo.Products", "Customer_CustomerID");
            DropColumn("dbo.Customers", "CustomerName");
            DropColumn("dbo.Customers", "Total");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Total", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Customers", "CustomerName", c => c.String());
            AddColumn("dbo.Products", "Customer_CustomerID", c => c.Int());
            DropColumn("dbo.Customers", "Password");
            DropColumn("dbo.Customers", "UserName");
            CreateIndex("dbo.Products", "Customer_CustomerID");
            AddForeignKey("dbo.Products", "Customer_CustomerID", "dbo.Customers", "CustomerID");
        }
    }
}
