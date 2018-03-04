namespace BookAppointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetFieldRequirement : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Businesses", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Businesses", "Location", c => c.String(nullable: false));
            AlterColumn("dbo.ServiceProvideds", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.ServiceProvideds", "Description", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ServiceProvideds", "Description", c => c.String());
            AlterColumn("dbo.ServiceProvideds", "Name", c => c.String());
            AlterColumn("dbo.Businesses", "Location", c => c.String());
            AlterColumn("dbo.Businesses", "Name", c => c.String());
        }
    }
}
