namespace Roomy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class foce : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Nom", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "Nom", c => c.String());
        }
    }
}
