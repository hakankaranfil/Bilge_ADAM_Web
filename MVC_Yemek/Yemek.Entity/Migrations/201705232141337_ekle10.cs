namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        MenuID = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        Datetime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MenuID)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Menu", "ProductID", "dbo.Product");
            DropIndex("dbo.Menu", new[] { "ProductID" });
            DropTable("dbo.Menu");
        }
    }
}
