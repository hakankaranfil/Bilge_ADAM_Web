namespace Protein.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle9 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customer", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customer", "Phone", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Customer", "Password", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "Name", c => c.String(nullable: false));
        }
    }
}
