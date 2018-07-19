namespace Roomy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Capacity = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Price = c.String(nullable: false),
                        Description = c.String(),
                        CreatedAt = c.String(nullable: false),
                        UserID = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rooms", "UserID", "dbo.Users");
            DropForeignKey("dbo.Rooms", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Rooms", new[] { "CategoryID" });
            DropIndex("dbo.Rooms", new[] { "UserID" });
            DropTable("dbo.Rooms");
            DropTable("dbo.Categories");
        }
    }
}
