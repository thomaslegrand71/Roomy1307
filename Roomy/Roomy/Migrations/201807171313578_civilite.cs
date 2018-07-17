namespace Roomy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class civilite : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Civilities",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Label = c.String(nullable: false, maxLength: 15),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CivilityID = c.Int(nullable: false),
                        Lastname = c.String(nullable: false, maxLength: 50),
                        Firstname = c.String(),
                        Mail = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Password = c.String(nullable: false),
                        ConfirmedPassword = c.String(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Civilities", t => t.CivilityID, cascadeDelete: true)
                .Index(t => t.CivilityID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "CivilityID", "dbo.Civilities");
            DropIndex("dbo.Users", new[] { "CivilityID" });
            DropTable("dbo.Users");
            DropTable("dbo.Civilities");
        }
    }
}
