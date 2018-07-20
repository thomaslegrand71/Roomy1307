namespace Roomy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class name : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Name", c => c.String(nullable: false));
            DropColumn("dbo.Categories", "Nom");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Nom", c => c.String(nullable: false));
            DropColumn("dbo.Categories", "Name");
        }
    }
}
