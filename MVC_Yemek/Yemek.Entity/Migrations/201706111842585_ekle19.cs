namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle19 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Concent", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Concent", "EMail", c => c.String(nullable: false));
            AlterColumn("dbo.Concent", "Message", c => c.String(nullable: false));
            AlterColumn("dbo.Concent", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Concent", "Phone", c => c.String());
            AlterColumn("dbo.Concent", "Message", c => c.String());
            AlterColumn("dbo.Concent", "EMail", c => c.String());
            AlterColumn("dbo.Concent", "Name", c => c.String());
        }
    }
}
