namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle13 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "Email", c => c.String());
        }
    }
}
