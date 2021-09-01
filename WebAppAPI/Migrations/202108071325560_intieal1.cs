namespace WebAppAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intieal1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserFName = c.String(),
                        UserMName = c.String(),
                        UserLName = c.String(),
                        UserMobNo = c.String(),
                        UserEmailId = c.String(),
                        UserAltNo = c.String(),
                        UserPanNo = c.String(),
                        UserAdhNo = c.String(),
                        SourceChannelId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
