namespace BuildYourPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Computers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cpu_Id = c.Int(),
                        GraphicCard_Id = c.Int(),
                        Memory_Id = c.Int(),
                        Motherboard_Id = c.Int(),
                        PowerSupply_Id = c.Int(),
                        RAM_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CPUs", t => t.Cpu_Id)
                .ForeignKey("dbo.GraphicCards", t => t.GraphicCard_Id)
                .ForeignKey("dbo.Memories", t => t.Memory_Id)
                .ForeignKey("dbo.Motherboards", t => t.Motherboard_Id)
                .ForeignKey("dbo.PowerSupplies", t => t.PowerSupply_Id)
                .ForeignKey("dbo.RAMs", t => t.RAM_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Cpu_Id)
                .Index(t => t.GraphicCard_Id)
                .Index(t => t.Memory_Id)
                .Index(t => t.Motherboard_Id)
                .Index(t => t.PowerSupply_Id)
                .Index(t => t.RAM_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.CPUs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        PowerConsumption = c.Int(nullable: false),
                        CoresCount = c.Int(nullable: false),
                        Frequency = c.Int(nullable: false),
                        Chipset = c.String(),
                        RamAge = c.String(),
                        RamFrequency = c.Int(nullable: false),
                        RamStrings = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.GraphicCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        PowerConsumption = c.Int(nullable: false),
                        GRAMCount = c.Int(nullable: false),
                        GRAMAge = c.String(),
                        GPU = c.String(),
                        Interfaces = c.String(),
                        PowerType = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Memories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        Amount = c.String(),
                        Type = c.String(),
                        ConnectionInterface = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Motherboards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        Chipset = c.String(),
                        Socket = c.String(),
                        RAMAge = c.String(),
                        RAMStrings = c.Int(nullable: false),
                        RAMSockets = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PowerSupplies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        ProtectionLevel = c.String(),
                        Power = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RAMs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PowerClass = c.String(),
                        Year = c.String(),
                        Frequency = c.Int(nullable: false),
                        Age = c.String(),
                        Amount = c.Int(nullable: false),
                        Pieces = c.Int(nullable: false),
                        Timings = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Computers", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Computers", "RAM_Id", "dbo.RAMs");
            DropForeignKey("dbo.Computers", "PowerSupply_Id", "dbo.PowerSupplies");
            DropForeignKey("dbo.Computers", "Motherboard_Id", "dbo.Motherboards");
            DropForeignKey("dbo.Computers", "Memory_Id", "dbo.Memories");
            DropForeignKey("dbo.Computers", "GraphicCard_Id", "dbo.GraphicCards");
            DropForeignKey("dbo.Computers", "Cpu_Id", "dbo.CPUs");
            DropIndex("dbo.Computers", new[] { "User_Id" });
            DropIndex("dbo.Computers", new[] { "RAM_Id" });
            DropIndex("dbo.Computers", new[] { "PowerSupply_Id" });
            DropIndex("dbo.Computers", new[] { "Motherboard_Id" });
            DropIndex("dbo.Computers", new[] { "Memory_Id" });
            DropIndex("dbo.Computers", new[] { "GraphicCard_Id" });
            DropIndex("dbo.Computers", new[] { "Cpu_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.RAMs");
            DropTable("dbo.PowerSupplies");
            DropTable("dbo.Motherboards");
            DropTable("dbo.Memories");
            DropTable("dbo.GraphicCards");
            DropTable("dbo.CPUs");
            DropTable("dbo.Computers");
        }
    }
}
