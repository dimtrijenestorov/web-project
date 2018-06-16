namespace TaxiService.MSSQLRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        StreetName = c.String(nullable: false),
                        StreetNumber = c.Int(nullable: false),
                        City = c.String(nullable: false),
                        PostNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        YearOfProduction = c.Int(nullable: false),
                        RegistrationNumber = c.String(nullable: false),
                        TaxiNumber = c.String(nullable: false),
                        CarType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Content = c.String(nullable: false),
                        Quality = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        X = c.Single(nullable: false),
                        Y = c.Single(nullable: false),
                        AddressId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Addresses", t => t.AddressId)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Rides",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ArivalId = c.Guid(nullable: false),
                        DestinationId = c.Guid(nullable: false),
                        CarType = c.String(nullable: false),
                        Total = c.Single(nullable: false),
                        CommentId = c.Guid(nullable: false),
                        State = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.ArivalId)
                .ForeignKey("dbo.Comments", t => t.CommentId)
                .ForeignKey("dbo.Locations", t => t.DestinationId)
                .Index(t => t.ArivalId)
                .Index(t => t.DestinationId)
                .Index(t => t.CommentId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false),
                        Name = c.String(),
                        LastName = c.String(),
                        Sex = c.String(nullable: false),
                        JMBG = c.String(nullable: false),
                        PhoneNumber = c.String(),
                        EMail = c.String(nullable: false),
                        Role = c.String(nullable: false),
                        RideId = c.Guid(nullable: false),
                        LocationId = c.Guid(),
                        CarId = c.Guid(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Username)
                .ForeignKey("dbo.Rides", t => t.RideId)
                .ForeignKey("dbo.Cars", t => t.CarId)
                .ForeignKey("dbo.Locations", t => t.LocationId)
                .Index(t => t.RideId)
                .Index(t => t.LocationId)
                .Index(t => t.CarId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "LocationId", "dbo.Locations");
            DropForeignKey("dbo.Users", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Users", "RideId", "dbo.Rides");
            DropForeignKey("dbo.Rides", "DestinationId", "dbo.Locations");
            DropForeignKey("dbo.Rides", "CommentId", "dbo.Comments");
            DropForeignKey("dbo.Rides", "ArivalId", "dbo.Locations");
            DropForeignKey("dbo.Locations", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Users", new[] { "CarId" });
            DropIndex("dbo.Users", new[] { "LocationId" });
            DropIndex("dbo.Users", new[] { "RideId" });
            DropIndex("dbo.Rides", new[] { "CommentId" });
            DropIndex("dbo.Rides", new[] { "DestinationId" });
            DropIndex("dbo.Rides", new[] { "ArivalId" });
            DropIndex("dbo.Locations", new[] { "AddressId" });
            DropTable("dbo.Users");
            DropTable("dbo.Rides");
            DropTable("dbo.Locations");
            DropTable("dbo.Comments");
            DropTable("dbo.Cars");
            DropTable("dbo.Addresses");
        }
    }
}
