namespace ZooPark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 200),
                        Gender = c.Int(nullable: false),
                        HavingOwner = c.Boolean(nullable: false),
                        DOB = c.DateTime(nullable: false),
                        Mass = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Species = c.String(nullable: false),
                        FoodId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Food", t => t.FoodId)
                .Index(t => t.FoodId);
            
            CreateTable(
                "dbo.Food",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        ManufactureDate = c.DateTime(nullable: false),
                        ExpirationDate = c.DateTime(),
                        Calories = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Keepers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        SurName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.KeeperAnimals",
                c => new
                    {
                        Keeper_Id = c.Int(nullable: false),
                        Animal_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Keeper_Id, t.Animal_Id })
                .ForeignKey("dbo.Keepers", t => t.Keeper_Id, cascadeDelete: true)
                .ForeignKey("dbo.Animals", t => t.Animal_Id, cascadeDelete: true)
                .Index(t => t.Keeper_Id)
                .Index(t => t.Animal_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KeeperAnimals", "Animal_Id", "dbo.Animals");
            DropForeignKey("dbo.KeeperAnimals", "Keeper_Id", "dbo.Keepers");
            DropForeignKey("dbo.Animals", "FoodId", "dbo.Food");
            DropIndex("dbo.KeeperAnimals", new[] { "Animal_Id" });
            DropIndex("dbo.KeeperAnimals", new[] { "Keeper_Id" });
            DropIndex("dbo.Animals", new[] { "FoodId" });
            DropTable("dbo.KeeperAnimals");
            DropTable("dbo.Keepers");
            DropTable("dbo.Food");
            DropTable("dbo.Animals");
        }
    }
}
