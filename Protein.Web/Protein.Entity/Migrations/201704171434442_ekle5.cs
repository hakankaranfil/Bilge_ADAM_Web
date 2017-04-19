namespace Protein.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle5 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Admins", newName: "Admin");
            RenameTable(name: "dbo.Brands", newName: "Brand");
            RenameTable(name: "dbo.Products", newName: "Product");
            RenameTable(name: "dbo.Categories", newName: "Category");
            RenameTable(name: "dbo.ShoppingCarts", newName: "ShoppingCart");
            RenameTable(name: "dbo.Customers", newName: "Customer");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Customer", newName: "Customers");
            RenameTable(name: "dbo.ShoppingCart", newName: "ShoppingCarts");
            RenameTable(name: "dbo.Category", newName: "Categories");
            RenameTable(name: "dbo.Product", newName: "Products");
            RenameTable(name: "dbo.Brand", newName: "Brands");
            RenameTable(name: "dbo.Admin", newName: "Admins");
        }
    }
}
