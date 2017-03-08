namespace MVCCRUD_Simple.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ekle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Motors",
                c => new
                    {
                        MotorID = c.Int(nullable: false, identity: true),
                        MotorBrand = c.String(),
                        MotorModel = c.String(),
                        MotorAge = c.String(),
                    })
                .PrimaryKey(t => t.MotorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Motors");
        }
    }
}
