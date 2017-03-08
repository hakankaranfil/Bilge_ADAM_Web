namespace MVCCRUD_Simple.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ekle1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Motors", "IsRented", c => c.Boolean(nullable: false));
            AddColumn("dbo.Motors", "IsDeleted", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Motors", "IsDeleted");
            DropColumn("dbo.Motors", "IsRented");
        }
    }
}
