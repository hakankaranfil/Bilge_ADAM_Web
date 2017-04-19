namespace Protein.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Name", c => c.String());
            AddColumn("dbo.Customers", "Surname", c => c.String());
            AddColumn("dbo.Customers", "Phone", c => c.String());
            AddColumn("dbo.Customers", "Email", c => c.String());
            DropColumn("dbo.Customers", "Mail");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Mail", c => c.String());
            DropColumn("dbo.Customers", "Email");
            DropColumn("dbo.Customers", "Phone");
            DropColumn("dbo.Customers", "Surname");
            DropColumn("dbo.Customers", "Name");
        }
    }
}
