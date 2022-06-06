namespace TheBestTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatesCats2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CategoryTimes", "Activity_Id", "dbo.Categories");
            DropForeignKey("dbo.CategoryTimes", "TimeBlock_Id", "dbo.TimeBlocks");
            DropIndex("dbo.CategoryTimes", new[] { "Activity_Id" });
            DropIndex("dbo.CategoryTimes", new[] { "TimeBlock_Id" });
            AddColumn("dbo.CategoryTimes", "CategoryName", c => c.String());
            AddColumn("dbo.CategoryTimes", "TimeBlock", c => c.String());
            DropColumn("dbo.CategoryTimes", "Activity_Id");
            DropColumn("dbo.CategoryTimes", "TimeBlock_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CategoryTimes", "TimeBlock_Id", c => c.Int());
            AddColumn("dbo.CategoryTimes", "Activity_Id", c => c.Int());
            DropColumn("dbo.CategoryTimes", "TimeBlock");
            DropColumn("dbo.CategoryTimes", "CategoryName");
            CreateIndex("dbo.CategoryTimes", "TimeBlock_Id");
            CreateIndex("dbo.CategoryTimes", "Activity_Id");
            AddForeignKey("dbo.CategoryTimes", "TimeBlock_Id", "dbo.TimeBlocks", "Id");
            AddForeignKey("dbo.CategoryTimes", "Activity_Id", "dbo.Categories", "Id");
        }
    }
}
