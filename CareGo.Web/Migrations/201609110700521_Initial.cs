namespace CareGo.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Details = c.String(maxLength: 250),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Routes",
                c => new
                    {
                        RouteId = c.Int(nullable: false, identity: true),
                        DepartureId = c.Int(nullable: false),
                        DestinationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RouteId)
                .ForeignKey("dbo.Cities", t => t.DepartureId, cascadeDelete: false)
                .ForeignKey("dbo.Cities", t => t.DestinationId, cascadeDelete: false)
                .Index(t => t.DepartureId)
                .Index(t => t.DestinationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Routes", "DestinationId", "dbo.Cities");
            DropForeignKey("dbo.Routes", "DepartureId", "dbo.Cities");
            DropIndex("dbo.Routes", new[] { "DestinationId" });
            DropIndex("dbo.Routes", new[] { "DepartureId" });
            DropTable("dbo.Routes");
            DropTable("dbo.Cities");
        }
    }
}
