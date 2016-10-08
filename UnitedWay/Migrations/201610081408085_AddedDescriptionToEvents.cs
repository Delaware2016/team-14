namespace UnitedWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDescriptionToEvents : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VolunteerEvents", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VolunteerEvents", "Description");
        }
    }
}
