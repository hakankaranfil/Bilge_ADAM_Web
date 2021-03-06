namespace Yemek.Entity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ekle18 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Concent",
                c => new
                    {
                        ConcentID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        EMail = c.String(),
                        Message = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.ConcentID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Concent");
        }
    }
}
