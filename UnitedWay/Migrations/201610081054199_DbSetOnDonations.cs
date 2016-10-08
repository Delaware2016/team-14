namespace UnitedWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbSetOnDonations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        UserId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Donations");
        }
    }
}
