namespace MonstiePocket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Monsties",
                c => new
                    {
                        MonstieNumber = c.Short(nullable: false, identity: true),
                        Icon = c.String(),
                        Egg = c.String(),
                        Type = c.String(),
                        Name = c.String(),
                        Genus = c.String(),
                        MonstieRarity = c.Byte(nullable: true),
                        Habitat = c.String(),
                        RiderAction1 = c.String(),
                        RiderAction2 = c.String(),
                        Status = c.String(),
                        EggRarity = c.String(),
                    })
                .PrimaryKey(t => t.MonstieNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Monsties");
        }
    }
}
