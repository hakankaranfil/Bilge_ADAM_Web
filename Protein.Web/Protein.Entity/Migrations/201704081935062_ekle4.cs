namespace Protein.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Password", c => c.String());
            AlterColumn("dbo.Customers", "Email", c => c.String());
        }
    }
}
