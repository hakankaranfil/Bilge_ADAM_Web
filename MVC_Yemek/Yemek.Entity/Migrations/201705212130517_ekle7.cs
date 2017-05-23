namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "IsSelected", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "IsSelected");
        }
    }
}
