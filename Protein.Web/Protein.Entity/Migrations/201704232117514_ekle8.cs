namespace Protein.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle8 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Customer", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "Phone", c => c.String());
            AlterColumn("dbo.Customer", "Surname", c => c.String());
            AlterColumn("dbo.Customer", "Name", c => c.String());
        }
    }
}
