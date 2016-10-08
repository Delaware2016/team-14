namespace UnitedWay.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewColumnsToApplicant : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "State", c => c.String(maxLength: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "State", c => c.String());
        }
    }
}
