﻿namespace BuildYourPC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hz : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CPUs", "Frequency", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CPUs", "Frequency", c => c.Int(nullable: false));
        }
    }
}
