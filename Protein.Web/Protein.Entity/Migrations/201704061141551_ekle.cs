namespace Protein.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.ShoppingCarts", "ProductID");
            AddForeignKey("dbo.ShoppingCarts", "ProductID", "dbo.Products", "ProductID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ShoppingCarts", "ProductID", "dbo.Products");
            DropIndex("dbo.ShoppingCarts", new[] { "ProductID" });
        }
    }
}
