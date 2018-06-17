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
                        Id = c.String(nullable: false, maxLength: 128),
                        YearOfProduction = c.Int(nullable: false),
                        RegistrationNumber = c.String(nullable: false),
                        TaxiNumber = c.String(nullable: false),
                        CarType = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
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
                        Banned = c.Boolean(nullable: false),
                        UbersLocationId = c.Guid(),
                        CarId = c.Guid(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Username)
                .ForeignKey("dbo.Locations", t => t.UbersLocationId)
                .ForeignKey("dbo.Rides", t => t.RideId)
                .Index(t => t.RideId)
                .Index(t => t.UbersLocationId);
            
            CreateTable(
                "dbo.Rides",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        ArivalId = c.Guid(nullable: false),
                        DestinationId = c.Guid(nullable: false),
                        CarType = c.String(nullable: false),
                        CustomerId = c.String(maxLength: 128),
                        DispetcherId = c.String(maxLength: 128),
                        UberDriverId = c.String(maxLength: 128),
                        Total = c.Single(nullable: false),
                        CommentId = c.Guid(nullable: false),
                        State = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.ArivalId)
                .ForeignKey("dbo.Locations", t => t.DestinationId)
                .ForeignKey("dbo.Users", t => t.CustomerId)
                .ForeignKey("dbo.Users", t => t.DispetcherId)
                .ForeignKey("dbo.Users", t => t.UberDriverId)
                .Index(t => t.ArivalId)
                .Index(t => t.DestinationId)
                .Index(t => t.CustomerId)
                .Index(t => t.DispetcherId)
                .Index(t => t.UberDriverId);
            
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
                "dbo.Comments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Timestamp = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Content = c.String(nullable: false),
                        Quality = c.Int(nullable: false),
                        CustomerId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.CustomerId)
                .ForeignKey("dbo.Rides", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rides", "UberDriverId", "dbo.Users");
            DropForeignKey("dbo.Users", "RideId", "dbo.Rides");
            DropForeignKey("dbo.Rides", "DispetcherId", "dbo.Users");
            DropForeignKey("dbo.Rides", "CustomerId", "dbo.Users");
            DropForeignKey("dbo.Cars", "Id", "dbo.Users");
            DropForeignKey("dbo.Comments", "Id", "dbo.Rides");
            DropForeignKey("dbo.Comments", "CustomerId", "dbo.Users");
            DropForeignKey("dbo.Users", "UbersLocationId", "dbo.Locations");
            DropForeignKey("dbo.Rides", "DestinationId", "dbo.Locations");
            DropForeignKey("dbo.Rides", "ArivalId", "dbo.Locations");
            DropForeignKey("dbo.Locations", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Comments", new[] { "CustomerId" });
            DropIndex("dbo.Comments", new[] { "Id" });
            DropIndex("dbo.Locations", new[] { "AddressId" });
            DropIndex("dbo.Rides", new[] { "UberDriverId" });
            DropIndex("dbo.Rides", new[] { "DispetcherId" });
            DropIndex("dbo.Rides", new[] { "CustomerId" });
            DropIndex("dbo.Rides", new[] { "DestinationId" });
            DropIndex("dbo.Rides", new[] { "ArivalId" });
            DropIndex("dbo.Users", new[] { "UbersLocationId" });
            DropIndex("dbo.Users", new[] { "RideId" });
            DropIndex("dbo.Cars", new[] { "Id" });
            DropTable("dbo.Comments");
            DropTable("dbo.Locations");
            DropTable("dbo.Rides");
            DropTable("dbo.Users");
            DropTable("dbo.Cars");
            DropTable("dbo.Addresses");
        }
    }
}
