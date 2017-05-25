namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menu", "IsDelete", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menu", "IsDelete");
        }
    }
}
