namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle8 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Product", "IsSelected");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Product", "IsSelected", c => c.Boolean());
        }
    }
}
