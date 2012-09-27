namespace SampleWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtraOAuthData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TwitterData",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Name = c.String(),
                        Location = c.String(),
                        Description = c.String(),
                        Url = c.String(),
                        AccessToken = c.String(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserProfile", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.GoogleData",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Country = c.String(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserProfile", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.FacebookData",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Id = c.String(),
                        Name = c.String(),
                        Link = c.String(),
                        Gender = c.String(),
                        AccessToken = c.String(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserProfile", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.FacebookData", new[] { "UserId" });
            DropIndex("dbo.GoogleData", new[] { "UserId" });
            DropIndex("dbo.TwitterData", new[] { "UserId" });
            DropForeignKey("dbo.FacebookData", "UserId", "dbo.UserProfile");
            DropForeignKey("dbo.GoogleData", "UserId", "dbo.UserProfile");
            DropForeignKey("dbo.TwitterData", "UserId", "dbo.UserProfile");
            DropTable("dbo.FacebookData");
            DropTable("dbo.GoogleData");
            DropTable("dbo.TwitterData");
        }
    }
}
