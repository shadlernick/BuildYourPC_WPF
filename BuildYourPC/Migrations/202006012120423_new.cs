namespace BuildYourPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CPUs", "Socket", c => c.String());
            DropColumn("dbo.CPUs", "Chipset");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CPUs", "Chipset", c => c.String());
            DropColumn("dbo.CPUs", "Socket");
        }
    }
}
