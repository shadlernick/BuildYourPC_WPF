namespace BuildYourPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedByUserflagadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CPUs", "AddedByUser", c => c.Boolean(nullable: false));
            AddColumn("dbo.GraphicCards", "AddedByUser", c => c.Boolean(nullable: false));
            AddColumn("dbo.Memories", "AddedByUser", c => c.Boolean(nullable: false));
            AddColumn("dbo.Motherboards", "AddedByUser", c => c.Boolean(nullable: false));
            AddColumn("dbo.PowerSupplies", "AddedByUser", c => c.Boolean(nullable: false));
            AddColumn("dbo.RAMs", "AddedByUser", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RAMs", "AddedByUser");
            DropColumn("dbo.PowerSupplies", "AddedByUser");
            DropColumn("dbo.Motherboards", "AddedByUser");
            DropColumn("dbo.Memories", "AddedByUser");
            DropColumn("dbo.GraphicCards", "AddedByUser");
            DropColumn("dbo.CPUs", "AddedByUser");
        }
    }
}
