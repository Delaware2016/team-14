namespace UnitedWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstDraftOfInterests : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "HealthInterest", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "ChildrenInterest", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "FundraisingInterest", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "FundraisingInterest");
            DropColumn("dbo.AspNetUsers", "ChildrenInterest");
            DropColumn("dbo.AspNetUsers", "HealthInterest");
        }
    }
}
