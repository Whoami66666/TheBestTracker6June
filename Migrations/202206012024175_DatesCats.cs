namespace TheBestTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatesCats : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoryTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        Activity_Id = c.Int(),
                        TimeBlock_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.Activity_Id)
                .ForeignKey("dbo.TimeBlocks", t => t.TimeBlock_Id)
                .Index(t => t.Activity_Id)
                .Index(t => t.TimeBlock_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoryTimes", "TimeBlock_Id", "dbo.TimeBlocks");
            DropForeignKey("dbo.CategoryTimes", "Activity_Id", "dbo.Categories");
            DropIndex("dbo.CategoryTimes", new[] { "TimeBlock_Id" });
            DropIndex("dbo.CategoryTimes", new[] { "Activity_Id" });
            DropTable("dbo.CategoryTimes");
        }
    }
}
