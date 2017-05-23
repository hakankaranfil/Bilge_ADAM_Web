namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "IsSelected", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "IsSelected");
        }
    }
}
