namespace TheBestTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Foregroundcolor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ForegroundColor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "ForegroundColor");
        }
    }
}
