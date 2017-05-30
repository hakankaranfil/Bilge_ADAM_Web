namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle16 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Message", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "Message");
        }
    }
}
