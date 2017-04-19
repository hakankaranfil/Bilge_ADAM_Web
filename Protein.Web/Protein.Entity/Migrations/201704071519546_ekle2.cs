namespace Protein.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Mail", c => c.String());
            DropColumn("dbo.Customers", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "UserName", c => c.String());
            DropColumn("dbo.Customers", "Mail");
        }
    }
}
