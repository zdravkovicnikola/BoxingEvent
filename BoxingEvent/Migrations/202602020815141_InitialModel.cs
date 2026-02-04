namespace BoxingEvent.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GrejnoTeloes",
                c => new
                    {
                        GrejnoTeloId = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        Tip = c.String(),
                        Snaga = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.GrejnoTeloId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GrejnoTeloes");
        }
    }
}
