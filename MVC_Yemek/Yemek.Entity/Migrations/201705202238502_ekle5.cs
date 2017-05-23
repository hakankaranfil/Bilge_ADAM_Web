namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "IsSelected", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Product", "IsSelected", c => c.Boolean());
        }
    }
}
