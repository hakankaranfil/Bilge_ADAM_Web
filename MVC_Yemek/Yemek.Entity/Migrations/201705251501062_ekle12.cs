namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle12 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customer", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customer", "Password", c => c.String());
        }
    }
}
