namespace BuildYourPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedsomecomponentsinfo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CPUs", "ThreadsCount", c => c.Int(nullable: false));
            AddColumn("dbo.CPUs", "CMOS", c => c.Int(nullable: false));
            AddColumn("dbo.GraphicCards", "DirectX", c => c.String());
            AddColumn("dbo.Memories", "FormFactor", c => c.String());
            AddColumn("dbo.Memories", "ShpindelSpeed", c => c.Int(nullable: false));
            AddColumn("dbo.Memories", "AverageFoundingSpeed", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.CPUs", "RamStrings");
            DropColumn("dbo.Users", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Name", c => c.String());
            AddColumn("dbo.CPUs", "RamStrings", c => c.Int(nullable: false));
            DropColumn("dbo.Memories", "AverageFoundingSpeed");
            DropColumn("dbo.Memories", "ShpindelSpeed");
            DropColumn("dbo.Memories", "FormFactor");
            DropColumn("dbo.GraphicCards", "DirectX");
            DropColumn("dbo.CPUs", "CMOS");
            DropColumn("dbo.CPUs", "ThreadsCount");
        }
    }
}
